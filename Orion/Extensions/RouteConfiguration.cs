﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Orion.Handlers;

namespace Orion.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureWebApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpContextAccessor();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<IClaimHandler, ClaimHandler>();

            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(configuration["WebApi:Url"])
            };
            services.AddSingleton(httpClient);
        }

        public static void ConfigureRouter(this IServiceCollection services)
        {
            services.AddMvc()
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AddPageRoute("/EndUser/Home", "Index.html");
                    options.Conventions.AddPageRoute("/EndUser/main-products", "main-products.html");
                    options.Conventions.AddPageRoute("/EndUser/raw", "raw.html");
                    options.Conventions.AddPageRoute("/EndUser/Sign", "Sign.html");
                    options.Conventions.AddPageRoute("/EndUser/orionForm", "orionForm.html");
                    options.Conventions.AddPageRoute("/EndUser/details", "details.html");
                    options.Conventions.AddPageRoute("/EndUser/visa", "visa.html");
                    options.Conventions.AddPageRoute("/EndUser/checkout", "checkout.html");
                    options.Conventions.AddPageRoute("/EndUser/childProfile", "childProfile.html");
                    options.Conventions.AddPageRoute("/EndUser/donate", "donate.html");
                    options.Conventions.AddPageRoute("/EndUser/feedback", "feedback.html");
                    options.Conventions.AddPageRoute("/EndUser/orphanage", "orphanage.html");
                    options.Conventions.AddPageRoute("/EndUser/Home", "Home.html");


                    options.Conventions.AddPageRoute("/Supervisor/AddProduct", "AddProduct.html");
                    options.Conventions.AddPageRoute("/Supervisor/childsProfile", "childsProfile.html");
                    options.Conventions.AddPageRoute("/Supervisor/editPro", "editPro.html");
                    options.Conventions.AddPageRoute("/Supervisor/editProFreelancer", "editProFreelancer.html");
                    options.Conventions.AddPageRoute("/Supervisor/superProfile", "superProfile.html");
                    options.Conventions.AddPageRoute("/Supervisor/superSignIn", "superSignIn.html");
                    options.Conventions.AddPageRoute("/Supervisor/superSignup", "superSignup.html");


                    options.Conventions.AddPageRoute("/Admin/addCategory", "addCategory.html");
                    options.Conventions.AddPageRoute("/Admin/addProd", "addProd.html");
                    options.Conventions.AddPageRoute("/Admin/adminMaterial", "adminMaterial.html");
                    options.Conventions.AddPageRoute("/Admin/adminRegister", "adminRegister.html");
                    options.Conventions.AddPageRoute("/Admin/editOrphanage", "editOrphanage.html");
                    options.Conventions.AddPageRoute("/Admin/adminSign", "adminSign.html");
                    options.Conventions.AddPageRoute("/Admin/feedback", "feedback.html");
                    options.Conventions.AddPageRoute("/Admin/newOrphanage", "newOrphanage.html");
                    options.Conventions.AddPageRoute("/Admin/orphanage", "orphanage.html");
              });
        }
        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.IncludeErrorDetails = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"]
                };
            });
        }
    }
}
