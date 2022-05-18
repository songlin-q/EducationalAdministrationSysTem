
using Autofac;
using Autofac.Extensions.DependencyInjection;
using EducationalAdministrationSystem.API.Common.Helper;
using EducationalAdministrationSysTem.API.IRepository.Base;
using EducationalAdministrationSysTem.API.IServices.Base;
using EducationalAdministrationSysTem.API.Model.Context;
using EducationalAdministrationSysTem.API.Services.Base;
using EducationalAdministrationSysTem.API.Setup;
using SqlSugar;
using System.Reflection;

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

app.UseSwagger();
app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "EducationSystem v1"); });
app.UseAuthorization();//权限认证

app.MapControllers();//这个在使用控制器的时候是必要的，不然swagger不会执行到控制器中的接口
app.UseStatusCodePages();
app.UseHttpsRedirection();
app.UseRouting();//使用路由
app.Run();