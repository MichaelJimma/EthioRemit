using API.ExtensionMethods;
using API.ValidateModel;
using AutoMapper;
using DAL.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment environment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //Register Db context
            services.AddDbContext<EthioRemitContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("EthioRemitConnection")));

            services.AddOptions();
            services.AddAutoMapper();
            Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile.AutoMapperProfile>());

            services.AddMvc(config => {
                config.ReturnHttpNotAcceptable = true;//ReturnHttpNotAcceptable forces the reesponse to match exactly the supported content type.
                config.Filters.Add(typeof(ValidateModelFilter));
            });

            services.AddCors();

            //Register other services
            services.Register();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(q => q.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseMvc();
        }
    }
}
