using AutoMapper;
using hightqual_it_backend.Tools;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hightqual_it_backend
{
        public class Startup
        {
            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public IConfiguration Configuration { get; }

            // This method gets called by the runtime. Use this method to add services to the container.
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddControllers();
                services.AddOurServices();
                services.AddAutoMapper(typeof(MappingProfile).Assembly);
                 services.AddCors(options =>
                 {
                    options.AddPolicy("allConnections", buider =>
                    {
                        buider.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                    });
                    options.AddPolicy("specialOrigin", builder =>
                    {
                        builder.WithMethods("GET").WithOrigins("http://localhost:3000");
                        builder.WithMethods("POST").WithOrigins("http://localhost:3000");
                        builder.WithMethods("DELETE").WithOrigins("http://localhost:3000");
                    });
                 });
            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                app.UseHttpsRedirection();

                app.UseRouting();


                app.UseCors();

                app.UseAuthentication();

                app.UseAuthorization();

                
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }
        }
    }
