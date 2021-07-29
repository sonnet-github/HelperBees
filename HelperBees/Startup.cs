//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.HttpsPolicy;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//using Microsoft.AspNetCore.Http;
//using JavaScriptEngineSwitcher.V8;
//using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
//using React.AspNet;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using React.AspNet;

namespace IntegrationTool
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

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddJsEngineSwitcher(options => options.DefaultEngineName = ChakraCoreJsEngine.EngineName)
                .AddChakraCore();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddReact();
            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            // Initialise ReactJS.NET. Must be before static files.
            app.UseReact(config =>
            {
                // If you want to use server-side rendering of React components,
                // add all the necessary JavaScript files here. This includes
                // your components as well as all of their dependencies.
                // See http://reactjs.net/ for more information. Example:
                config
                  .AddScript("~/js/remarkable.min.js")
                  .AddScript("~/js/tutorial.jsx")
                  .SetJsonSerializerSettings(new JsonSerializerSettings
                  {
                      StringEscapeHandling = StringEscapeHandling.EscapeHtml,
                      ContractResolver = new CamelCasePropertyNamesContractResolver()
                  });

                // If you use an external build too (for example, Babel, Webpack,
                // Browserify or Gulp), you can improve performance by disabling
                // ReactJS.NET's version of Babel and loading the pre-transpiled
                // scripts. Example:
                //config
                //  .SetLoadBabel(false)
                //  .AddScriptWithoutTransform("~/Scripts/bundle.server.js");
            });

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }

    //public class Startup
    //{
    //    public Startup(IConfiguration configuration)
    //    {
    //        Configuration = configuration;
    //    }

    //    public IConfiguration Configuration { get; }

    //    // This method gets called by the runtime. Use this method to add services to the container.
    //    public void ConfigureServices(IServiceCollection services)
    //    {
    //        //Start ReactJS
    //        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    //        services.AddReact();

    //        // Make sure a JS engine is registered, or you will get an error!
    //        services.AddJsEngineSwitcher(options => options.DefaultEngineName = V8JsEngine.EngineName)
    //          .AddV8();
    //        //End ReactJS

    //        services.AddControllersWithViews();
    //    }

    //    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    //    {
    //        if (env.IsDevelopment())
    //        {
    //            app.UseDeveloperExceptionPage();
    //        }
    //        else
    //        {
    //            app.UseExceptionHandler("/Home/Error");
    //            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //            app.UseHsts();
    //        }
    //        app.UseHttpsRedirection();


    //        //Start ReactJS
    //        // Initialise ReactJS.NET. Must be before static files.
    //        app.UseReact(config =>
    //        {
    //            // If you want to use server-side rendering of React components,
    //            // add all the necessary JavaScript files here. This includes
    //            // your components as well as all of their dependencies.
    //            // See http://reactjs.net/ for more information. Example:
    //            //config
    //            //  .AddScript("~/js/First.jsx")
    //            //  .AddScript("~/js/Second.jsx");

    //            // If you use an external build too (for example, Babel, Webpack,
    //            // Browserify or Gulp), you can improve performance by disabling
    //            // ReactJS.NET's version of Babel and loading the pre-transpiled
    //            // scripts. Example:
    //            //config
    //            //  .SetLoadBabel(false)
    //            //  .AddScriptWithoutTransform("~/js/bundle.server.js");
    //        });
    //        //End ReactJS

    //        app.UseStaticFiles();

    //        app.UseRouting();

    //        app.UseAuthorization();

    //        //app.UseEndpoints(endpoints =>
    //        //{
    //        //    endpoints.MapControllerRoute(
    //        //        name: "default",
    //        //        pattern: "{controller=Home}/{action=Index}/{id?}");
    //        //});

    //        app.UseEndpoints(endpoints =>
    //        {
    //            endpoints.MapControllerRoute(
    //                name: "default",
    //                pattern: "{controller=MemberPortal}/{action=Login}/{id?}");
    //        });
    //    }
    //}
}
