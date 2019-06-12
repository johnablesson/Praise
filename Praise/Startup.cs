using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Praize.Business.Managers;
using Praize.Business.Repositories;
using Praize.Business.Repositories.Interfaces;
using Praize.DataAccess;
using Praize.DataAccess.Entities;

namespace Praise
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
            services.AddDbContext<PraizeDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PraizeDB"), b => b.MigrationsAssembly("Praize.Api")));
            services.AddTransient<IAccountManager, AccountManager>();
            services.AddTransient<IRepository<User>, Repository<User>>();
            services.AddTransient<IRepository<Address>, Repository<Address>>();
            services.AddTransient<IRepository<PhoneNumber>, Repository<PhoneNumber>>();
            services.AddTransient<IAccountManager, AccountManager>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
