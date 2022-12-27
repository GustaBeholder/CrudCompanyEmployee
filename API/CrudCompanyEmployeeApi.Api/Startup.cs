using CrudCompanyEmployeeApi.Service.DependencyInjection;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.OpenApi.Models;

using System.Text.Json.Serialization;

namespace CrudCompanyEmployeeApi.Api
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
            services.AddSingleton(Configuration);
            
            services.AddHttpClient();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHealthChecks();

            ConfigureBindingsDependencyInjection.RegisterBindings(services, Configuration);

            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders =
                ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto | ForwardedHeaders.XForwardedHost;
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Crud Company/Employee - Gustavo Soares",
                    Description = "Documentação da API",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact() { Name = "Crud Company/Employee Dev Team", Email = "", Url = new Uri("https://example.com/terms") }
                });
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //c.IncludeXmlComments(xmlPath);
            });

            services.AddControllers(options =>
            {
                options.EnableEndpointRouting = false;
            })

            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });

        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            //app.UseHttpsRedirection();
            app.UseRouting();
            app.UseForwardedHeaders();
            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseResponseCompression();
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/health");
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "Crud Company/Employee - API");
            });
        }
    }
}
