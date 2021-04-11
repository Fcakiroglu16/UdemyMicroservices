using FreeCourse.Gateway.DelegateHandlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Gateway
{
    public class Startup
    {
        private readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<TokenExhangeDelegateHandler>();
            services.AddAuthentication().AddJwtBearer("GatewayAuthenticationScheme", options =>
            {
                options.Authority = Configuration["IdentityServerURL"];
                options.Audience = "resource_gateway";
                options.RequireHttpsMetadata = false;
            });

            services.AddOcelot().AddDelegatingHandler<TokenExhangeDelegateHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        async public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            await app.UseOcelot();
        }
    }
}