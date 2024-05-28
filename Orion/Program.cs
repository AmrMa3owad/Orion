using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Orion.Context;
using Orion.Domain.Models;
using Orion.Extensions;
using Orion.Infrastructure.Extentions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages().AddRazorPagesOptions(options => {
    options.Conventions.AddPageRoute("/Test", "Index.html");
}
    ); builder.Services.AddMvc();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("OrionDB")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureMapper();
builder.Services.AddControllersWithViews();
builder.Services.ConfigureHttpContext();
builder.Services.ConfigureInfrastructure();
builder.Services.ConfigureApiVersions();
builder.Services.ConfigureWebApi(builder.Configuration);
//builder.Services.ConfigureDbContext(builder.Configuration);
//builder.Services.ConfigureJWT(builder.Configuration);
builder.Services.ConfigureMapper();
builder.Services.ConfigureEmailSender(builder.Configuration);

//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Orion", Version = "v1" });
//});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

//app.UseSwagger();

//app.UseSwaggerUI(c =>
//{
//    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Orion v1");
//    c.RoutePrefix = string.Empty;
//});

app.MapRazorPages();
app.MapControllers();

app.Run();
