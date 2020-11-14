using System;
using BLL;
using DAL;
using DAL.Helper;
using DAL.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API
{
    public class Startup
    {
        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
               .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            services.AddControllers();
            services.AddTransient<IDatabaseHelper, DatabaseHelper>();
            services.AddTransient<IlinhvucRespo, linhvucRespo>();
            services.AddTransient<IlinhvucBuss, linhvucBuss>();
            services.AddTransient<IdonviRespo, donviRespo>();
            services.AddTransient<IdonviBuss, donviBuss>();
            services.AddTransient<IloainhiemvuRespo, loainhiemvuRespo>();
            services.AddTransient<InhiemvuRespo, nhiemvuRespo>();
            services.AddTransient<InhiemvuBuss, nhiemvuBuss>();
            //services.AddTransient<InhanvienRespo, nhanvienRespo>();
            //services.AddTransient<InhanvienBuss, nhanvienBuss>();
            services.AddTransient<IchucvuBuss, chucvuBuss>();
            services.AddTransient<IchucvuRespo, chucvuRespo>();
            services.AddTransient<IloaitintucRespo, loaitintucRespo>();
            services.AddTransient<IloaitintucBuss, loaitintucBuss>();
            services.AddTransient<ItintucRespo, tintucRespo>();
            services.AddTransient<ItintucBuss, tintucBuss>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseHttpsRedirection();
        }
    }
}
