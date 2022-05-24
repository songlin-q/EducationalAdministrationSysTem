
using Autofac;
using Autofac.Extensions.DependencyInjection;
using EducationalAdministrationSystem.API.Common.ConvertHelper;
using EducationalAdministrationSystem.API.Common.Helper;
using EducationalAdministrationSystem.API.Common.redis;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.Base;
using EducationalAdministrationSysTem.API.Model.Context;
using EducationalAdministrationSysTem.API.Model.ViewModel;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.Setup;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SqlSugar;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
// Add services to the container.
//将配置文件注册进行方便后面使用
builder.Services.AddSingleton(new EducationalAdministrationSystem.API.Common.Helper.AppSettings(builder.Configuration));

//注入autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());//注入autofac
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    //    builder.Register(c => new CallLogger()).Named<IInterceptor>("demotest");

    //builder.RegisterType<CallLogger>().AsSelf().InstancePerLifetimeScope();//注册拦截器

    var basePath = AppContext.BaseDirectory;
    var servicesDllFile = Path.Combine(basePath, "EducationalAdministrationSysTem.API.Services.dll");//获取注入项目绝对路径

    var repositoryDllFile = Path.Combine(basePath, "EducationalAdministrationSysTem.API.IRepository.dll");
    containerBuilder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency();//注册仓储
    var assemblysServices = Assembly.LoadFrom(servicesDllFile);//直接采用加载文件的方法
    var assemblysRepository = Assembly.LoadFrom(repositoryDllFile);//直接采用加载文件的方法
    containerBuilder.RegisterAssemblyTypes(assemblysServices)
              .AsImplementedInterfaces()
              .InstancePerLifetimeScope()
              .PropertiesAutowired();
    //.EnableInterfaceInterceptors();//启用拦截器

    containerBuilder.RegisterAssemblyTypes(assemblysRepository)
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope()
            .PropertiesAutowired();
    // .EnableInterfaceInterceptors();//绑定拦截器;.InterceptedBy(typeof(CallLogger))


});
#region jwt Bearer认证令牌认证

var _tokenParameter = AppSettings.app<tokenParameter>(new string[] { "JwtConfig" }).FirstOrDefault();//获取到appsettings中配置的信息并转换为model


var key = Encoding.ASCII.GetBytes(_tokenParameter.Secret);//获取到JWT加密的Key,这个值的长度不能太短，否则会出现错误

//组装令牌验证参数
var tokenValidationParams = new TokenValidationParameters
{
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(key),
    ValidateIssuer = false,
    ValidateAudience = false,
    ValidateLifetime = true,
    RequireExpirationTime = false,
    ClockSkew = TimeSpan.Zero
};

builder.Services.AddSingleton(tokenValidationParams);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(jwt =>
{
    jwt.SaveToken = true;
    jwt.TokenValidationParameters = tokenValidationParams;
});
#endregion

#region redis缓存
var section = builder.Configuration.GetSection("Redis:Default");
//连接字符串
string _connectionString = section.GetSection("Connection").Value;
//实例名称
string _instanceName = section.GetSection("InstanceName").Value;
//默认数据库 
int _defaultDB = int.Parse(section.GetSection("DefaultDB").Value ?? "0");
builder.Services.AddSingleton(new RedisHelper(_connectionString, _instanceName, _defaultDB).GetDatabase());//单例模式注入redis配置类
#endregion
 
#region 解决跨域问题 
string anyAllowSpecificOrigins = "any";//解决跨域 在下方还要进行使用
//解决跨域
builder.Services.AddCors(options =>
{
    options.AddPolicy(anyAllowSpecificOrigins, corsbuilder =>
    {
        var corsPath = builder.Configuration.GetSection("CorsPaths").GetChildren().Select(p => p.Value).ToArray();
        corsbuilder.WithOrigins(corsPath)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();//指定处理cookie
    });
});
#endregion

builder.Services.AddHttpClient();

builder.Services.AddControllers(options =>
{
    //options.Filters.Add<ExtentionTool.LoginAuthorzation>();
    //options.Filters.Add<Filter.TokenAuthorizeAttribute>(); // 添加身份验证过滤器 -- 菜单操作权限
})  //全局配置Json序列化处理
.AddJsonOptions(options =>
{
    //格式化日期时间格式
    options.JsonSerializerOptions.Converters.Add(new DatetimeJsonConverter());//自定义的输出格式：yyyy-MM-dd HH:mm:ss
                                                                              //数据格式首字母小写
                                                                              //options.JsonSerializerOptions.PropertyNamingPolicy =JsonNamingPolicy.CamelCase;
                                                                               //数据格式原样输出
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    //取消Unicode编码
    options.JsonSerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);
    //忽略空值
    //options.JsonSerializerOptions.IgnoreNullValues = true;
    //允许额外符号
    options.JsonSerializerOptions.AllowTrailingCommas = true;
    //反序列化过程中属性名称是否使用不区分大小写的比较
    options.JsonSerializerOptions.PropertyNameCaseInsensitive = false;
}
);


//注册swagger
builder.Services.AddSwaggerGen(s =>
{
    s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "教务管理系统接口文档",
        Version = "v1",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact()
        {
            Name = "EducationSystem",
            Email = "442534979@qq.com"
        }

    });
    s.OrderActionsBy(o => o.RelativePath);
    var xmlPath = Path.Combine(AppContext.BaseDirectory, "EducationalAdministrationSysTem.API.xml");
    s.IncludeXmlComments(xmlPath);//包含注释
});

//注册sqlsugar配置文件
builder.Services.AddSqlsugarSetup();


//注册sqlsugar
builder.Services.AddSingleton(sp => new SqlSugarContext(
    new SqlSugarClient(new ConnectionConfig()
    {
        ConnectionString = builder.Configuration.GetConnectionString("DbConnectionString"),
        DbType = DbType.SqlServer,//数据库类型
        IsAutoCloseConnection = true,//自动释放
    })
    ));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

}

app.UseCors(anyAllowSpecificOrigins);//支持跨域：允许特定来源的主机访问

app.UseHttpsRedirection();

app.UseSwagger();
app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "EducationSystem v1"); });
app.UseAuthentication();//JWT
app.UseAuthorization();//权限认证

app.MapControllers();//这个在使用控制器的时候是必要的，不然swagger不会执行到控制器中的接口
app.UseStatusCodePages();
app.UseHttpsRedirection();
app.UseRouting();//使用路由
app.Run();