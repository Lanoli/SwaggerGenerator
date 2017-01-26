using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Digipolis.Web;
using swaggerGenerator.Options;
using Digipolis.Web.Guidelines;
using Swashbuckle.Swagger.Model;
using Digipolis.Persoon.Api.Swagger;
using Digipolis.Web.Guidelines.Swagger;

namespace swaggerGenerator
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var appEnv = PlatformServices.Default.Application;
            ApplicationBasePath = appEnv.ApplicationBasePath;
            ConfigPath = Path.Combine(env.ContentRootPath, "_config");

            var builder = new ConfigurationBuilder()
                .SetBasePath(ConfigPath)
                .AddJsonFile("logging.json")
                .AddJsonFile("app.json")
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; private set; }
        public string ApplicationBasePath { get; private set; }
        public string ConfigPath { get; private set; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Check out ExampleController to find out how these configs are injected into other classes
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            services.AddMvc();
             //  .AddVersionEndpoint();

            services.AddBusinessServices();
            services.AddAutoMapper();

            services.AddSwaggerGen();

            services.ConfigureSwaggerGenDefaults().ConfigureSwaggerGen(x =>
            {
                //Override default settings here
                //...

                //Specify Api Versions here
                x.MultipleApiVersions(new Info[] { new Info
                    {
                        //Add Inline version
                        Version ="v4",
                        Title = "API Persoon",
                        Description = "Beheer van persoonsgegevens",
                        Contact = new Contact { Email = "Jos.Mostmans@digipolis.be", Name = "Jos Mostmans"},
                    }
                });

                x.DocumentFilter<AddExternalDocInfoDocumentFilter>(@"\\software.digipolis.local\Documentatie\Persoon\Persoon API\v4", "Documentatie");
                //x.DocumentFilter<AddCorrelationheaderRequiredDocumentFilter>();

                x.OperationFilter<AddCorrelationHeaderRequiredOperationFilter>();
                x.DocumentFilter<RemoveStatusPathDocumentFilter>();
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("ConsoleLogging"));
            loggerFactory.AddDebug(LogLevel.Debug);

            // CORS
            app.UseCors((policy) =>
            {
                policy.AllowAnyHeader();
                policy.AllowAnyMethod();
                policy.AllowAnyOrigin();
                policy.AllowCredentials();
            });

            app.UseExceptionHandling(options =>
            {
                // add your custom exception mappings here
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "api/{controller}/{id?}");
            });

            app.UseSwagger();
            app.UseSwaggerUi();
            app.UseSwaggerUiRedirect();
        }


    }
}
