using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consul;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StockExchange.DataContext;
using StockExchange.Domain.Interfaces;
using StockExchange.Domain.Repository;
using StockExchange.Domain.Services;

namespace StockExchange
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
            services.AddControllers();
            var connection = Configuration.GetConnectionString("Constr");
            services.AddDbContext<SEContext>(options => options.UseSqlServer(connection));
            services.AddScoped<ISERepository, SERepository>();
            services.AddScoped<ISEServices, SEServices>();
            services.AddCors();
            services.AddSingleton<IConsulClient, ConsulClient>(options => new ConsulClient(config =>
            {
                config.Address = new Uri(Configuration["ConsulConfig:Host"]);
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var client = app.ApplicationServices.GetRequiredService<IConsulClient>();
            var registration = new AgentServiceRegistration()
            {
                Address = "localhost",
                Port = 61954,
                Name = Configuration["ConsulConfig:ServiceName"],
                ID = Configuration["ConsulConfig:ServiceId"]
            };
            var applifetime = app.ApplicationServices.GetRequiredService<IHostApplicationLifetime>();
            applifetime.ApplicationStarted.Register(() => client.Agent.ServiceRegister(registration).ConfigureAwait(true));
            applifetime.ApplicationStopped.Register(() => client.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true));
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
