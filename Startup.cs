using EmailSentimentAnalysisWebsite.Domain;
using EmailSentimentAnalysisWebsite.Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmailSentimentAnalysisWebsite
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });

            ConfigureDependencies(services);
        }

        private void ConfigureDependencies(IServiceCollection services)
        {
            services.AddScoped(typeof(IEmailQueryService), typeof(EmailQueryService));
            var config = GetConfig();
            services.AddSingleton(typeof(AppSettingsConfig), config);
        }

        private AppSettingsConfig GetConfig()
        {
            var endpoint = (string)Configuration.GetValue(typeof(string), "ApiEndpoint");
            var useDummyValue = (string)Configuration.GetValue(typeof(string), "UseDummyData");
            var useDummyFlag = !string.IsNullOrWhiteSpace(useDummyValue) && useDummyValue.ToLowerInvariant() == "true";
            var config = new AppSettingsConfig { ApiEndpoint = endpoint, UseDummyData = useDummyFlag };
            return config;
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
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
