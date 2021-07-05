using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System;
using System.Reflection;
using System.IO;
using Microsoft.OpenApi.Models;
using Microsoft.IdentityModel.Tokens;

namespace spmedgpAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services
                .AddSwaggerGen(c =>
               {

                   c.SwaggerDoc("v1", new OpenApiInfo
                   {

                       Version = "V1",
                       Title = "SP MedicalGroupAPI",
                       Description = "API para estudos direcionados à escola SENAI de informática"

                   });

               })
                .AddControllers()
                .AddNewtonsoftJson(options => {

                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

                }); 
            
                services.AddCors(options => {
                    options.AddPolicy("CorsPolicy",
                        builder => {
                            builder.WithOrigins("*.*.*.*:*", "http://localhost:3000", "http://localhost:19006", "http://localhost:19000", "http://10.0.0.109:19000" , "exp://10.0.0.118:19000", "http://10.0.0.118:19000", "http://10.0.0.1:16000", "10.0.1.1:8081")
                                                                        .AllowAnyHeader()
                                                                        .AllowAnyMethod();
                        }
                    );
                });



            services
                .AddAuthentication(options =>
                 {

                     options.DefaultAuthenticateScheme = "JwtBearer";
                     options.DefaultChallengeScheme = "JwtBearer";

                 })
                .AddJwtBearer("JwtBearer", options =>
                {

                    options.TokenValidationParameters = new TokenValidationParameters
                    {

                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("CHAVESEGURANCASPMEDGP") ),
                        ValidIssuer = "spmedgp.webApi",
                        ValidAudience = "spmedgp.webApi",
                        ClockSkew = TimeSpan.FromMinutes(30)
                    };

                });
           

        }

        private void AddAuthentication(Action<object> p)
        {
            throw new NotImplementedException();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {

                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SpMedGp V1");
                c.RoutePrefix= string.Empty;

            });

            app.UseRouting();

            app.UseCors("CorsPolicy");

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
