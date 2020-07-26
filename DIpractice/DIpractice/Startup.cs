using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DIpractice.Services;

namespace DIpractice
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
            services.AddControllersWithViews();
            
            services.AddSingleton<InfoService>();
            services.AddSingleton<IInfoService, InfoService>();
            
            services.AddMvc();

            //[DI(Dependency Injection)] 서비스 등록
            services.AddTransient<CopyrightService>();

            //[DI(Dependency Injection)] 서비스 등록
            services.AddTransient<ICopyrightService, CopyrightService>();
            //AddTransient : 매번 실행시마다 service와 service2가 다른 hashcode생성
            //AddSingleton : service와 service2가 같은 인스턴스,같은 hashcode가 생성되어 
            //               같은 개체로 인식
            //AddScoped    : AddSingleton과 같지만 새로고침 할때마다 새로 생성

            services.AddSingleton<CopyrightService>();//@inject 키워드로 뷰에 직접 클래스의 값 출력
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
