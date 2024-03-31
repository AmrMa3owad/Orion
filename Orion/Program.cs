using Microsoft.EntityFrameworkCore;
using Orion.Context;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddMvc();
builder.Services.AddDbContext<AppDbContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("OrionDB")));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Orion", Version = "v1" });
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSwagger();


app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Orion v1");
    c.RoutePrefix = string.Empty;
});

app.MapRazorPages();
app.MapControllers();

app.Run();
