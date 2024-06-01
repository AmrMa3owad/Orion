using Microsoft.EntityFrameworkCore;
using Orion.Context;
using Orion.Extensions;
using Orion.Infrastructure.Extentions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.ConfigureRouter();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("OrionDB")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureMapper();
builder.Services.AddControllersWithViews();
builder.Services.ConfigureHttpContext();
builder.Services.ConfigureInfrastructure();
builder.Services.ConfigureApiVersions();
builder.Services.ConfigureWebApi(builder.Configuration);
builder.Services.ConfigureEmailSender(builder.Configuration);


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); 
app.UseAuthorization();
app.MapRazorPages();
app.MapControllers();

app.Run();
