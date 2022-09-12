using Autofac;
using Metas.Application.Interface;
using Metas.Application.Service;
using Metas.DomainCore.Interface;
using Metas.DomainCore.Service;
using Metas.Infrastructure;
using Metas.Infrastructure.Interface;
using Metas.Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Metas.API
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
            
            
            //nivekl1
            services.AddScoped<IAplicationServiceCliente, AplicationServiceCliente>();
            services.AddScoped<IAplicationServiceColaborador, AplicationServiceColaborador>();
            services.AddScoped<IAplicationServiceCiclo, AplicationServiceCilo>();
            services.AddScoped<IAplicationServiceUser, AplicationServiceUser>();
            services.AddScoped<IAplicationServiceRepresetante, AplicationServiceRepresetante>();
            //

            //nivel2
            services.AddScoped<IServiceCliente, ServiceCliente>();
            services.AddScoped<IServiceColaborador, Servicecolaborador>();
            services.AddScoped<IServiceCilo, ServiceCiclo>();
            services.AddScoped<IServiceUser, ServiceUser>();
            services.AddScoped<IServiceRepresentante, ServiceRepresentante>();

            //* nivek 3
            services.AddScoped<IRepositoryCliente, RepositoryCliente>();
            services.AddScoped<IRepositoryColaborador, RepositoryColaborador>();
            services.AddScoped<IRepositoryCiclo, RepositoryCiclo>();
            services.AddScoped<IRepositoryUser, RepositoryUser>();
            services.AddScoped<IRepositoryRepresentante, RepositoryRepresentante>();

            services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Api Gerdau/Metas", Version = "v1" })

                );

            //------------------------
            services.AddAuthentication("CookieAuthentication")
            .AddCookie("CookieAuthentication", config =>
            {
            config.Cookie.Name = "UserLoginCookie";
            config.LoginPath = "/Login/UserLogin";
            config.AccessDeniedPath = "/Login/AccessDenied";
            });

            services.AddControllersWithViews();
            //--------------------------




        }

        public void ConfigiureContainer(ContainerBuilder Bilder)
        {

            Bilder.RegisterModule(new ModuleIOC());
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
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Gerdau/Metas");

                //c.RoutePrefix = string.Empty;
            });

           
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            
            //cookies
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            

        }
    }
}
