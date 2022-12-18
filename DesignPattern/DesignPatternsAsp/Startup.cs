using DesignPatternsAsp.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Earn;

namespace DesignPatternsAsp
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
            // inyección 
            services.Configure<MyConfig>(Configuration.GetSection("MyConfig"));
            // Hay otra forma de inyectarlo de forma transitoria o Transient que esto va a ser un objeto para cada servicio,
            // cada solicitud, cada controlador va a tener un objeto, es decir, en el objeto que esté utilizando en el controlador, en un constructor.
            // No es el mismo objeto que esté utilizando en otro constructor.
            // A diferencia de Singleton, si lo inyectamos de forma singleton, sí sería el mismo objeto.
            services.AddTransient( (factory) =>
            {
                return new LocalEarnFactory(Configuration.GetSection("MyConfig").GetValue<decimal>("LocalPercentage"));
            });

            services.AddTransient((factory) =>
            {
                return new ForeignEarnFactory(
                    Configuration.GetSection("MyConfig").GetValue<decimal>("ForeignPercentage"),
                    Configuration.GetSection("MyConfig").GetValue<decimal>("Extra"));
            });
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
