using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAlunos.Models;
using ApiAlunos.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ApiAlunos {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddDbContext<AlunoDbContext> (options =>
                options.UseMySql (Configuration.GetConnectionString ("MySqlConnetionString"))
            );
            services.AddTransient<IAlunoRepository, AlunoRepository> ();

            //permite requisições ORIGIN
            services.AddCors (o => o.AddPolicy ("MyPolicy", builder => {
                builder
                    .AllowAnyOrigin ()
                    .AllowAnyMethod ()
                    .AllowAnyHeader ()
                    .AllowCredentials ();
            }));

            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseHsts ();
            }

            app.UseCors ("MyPolicy");

            app.UseHttpsRedirection ();
            app.UseMvc ();
        }
    }
}