using API.ExtensionMethods;
using API.ValidateModel;
using AutoMapper;
using DAL.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Net;
using System.Text;

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

      //Automapper configuration
      services.AddAutoMapper();
      Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile.AutoMapperProfile>());

      //JWT configuration
      services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
          options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
          {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
          };
        });

      //MVC configuration
      services.AddMvc(config =>
      {
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
      else
      {
        app.UseExceptionHandler(builder =>
        {
          builder.Run(async context =>
          {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var error = context.Features.Get<IExceptionHandlerFeature>();
            if (error != null)
            {
              context.Response.AddApplicationError(error.Error.Message);
              await context.Response.WriteAsync(error.Error.Message);
            }
          });
        });
      }
      app.UseCors(q => q.AllowAnyOrigin()
      .AllowAnyMethod().AllowAnyHeader());

      app.UseAuthentication();
      app.UseMvc();
      app.UseDefaultFiles();
      app.UseStaticFiles();

    }
  }
}
