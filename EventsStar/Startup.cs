using EventsStar.Application;
using EventsStar.Domain;
using EventsStar.EntityFrameworkCore;
using EventsStart.Infrastructure;
using Microsoft.OpenApi.Models;

namespace EventsStar
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
            services.AddApplication();
            services.AddDomainServices();
            services.AddEFCore(Configuration);
            services.AddInfrastructure();

            services.AddCors(options =>
            {
                //https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2
                options.AddDefaultPolicy(
                    builder => builder.WithOrigins("*")
                        .SetIsOriginAllowedToAllowWildcardSubdomains()
                        //Set the allowed HTTP methods
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Events Star", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Wizard v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }
}
