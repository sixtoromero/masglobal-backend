using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using masglobal.Application.Interface;
using masglobal.Application.Main;
using masglobal.Domain.Core;
using masglobal.Domain.Interface;
using masglobal.InfraStructure.Interface;
using masglobal.InfraStructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace masglobal.Services.WebAPIRest
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


            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowSpecificOrigin", builder =>
            //        builder.AllowAnyHeader()
            //               .AllowAnyMethod()
            //               .AllowAnyOrigin()
            //    );
            //});

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            //services.AddSingleton<IEmployeesApplication, EmployeesApplication>();
            //services.AddSingleton<IEmployeesDomain, EmployeesDomain>();
            //services.AddSingleton<IEmployeesRepository, EmployeesRepository>();

            services.AddScoped<IEmployeesApplication, EmployeesApplication>();
            services.AddScoped<IEmployeesDomain, EmployeesDomain>();
            services.AddScoped<IEmployeesRepository, EmployeesRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseCors("AllowSpecificOrigin");


        }
    }
}
