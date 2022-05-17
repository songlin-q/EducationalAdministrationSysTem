
using EducationalAdministrationSysTem.API.Model.Context;
using SqlSugar;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
// Add services to the container.
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