using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.Configuration;
using TheEye.Business.Abstract;
using TheEye.Business.Concrete;
using TheEye.DataAccess.Abstract;
using TheEye.DataAccess.Concrete.EntityFramework;
using TheEye.WebUl.Filters;
using TheEye.WebUl.Models;

namespace TheEye.WebUl
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICompanyService, CompanyManager>();
            services.AddScoped<ICompanyDal, EfCompanyDal>();
            services.AddScoped<ICarParkService, CarParkManager>();
            services.AddScoped<ICarParkDal, EfCarParkDal>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IPetrolStationService, PetrolStationManager>();
            services.AddScoped<IPetrolStationDal, EfPetrolStationDal>();
            services.AddScoped<IMedicineService, MedicineManager>();
            services.AddScoped<IMedicineDal, EfMedicineDal>();
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.Configure<ServiceModal>(Configuration.GetSection("Service"));

            services.AddScoped<LoginFilter>();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
                options.Cookie.HttpOnly = true;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseMvcWithDefaultRoute();
            app.UseStatusCodePages();
            app.UseMvc();
        }
    }
}