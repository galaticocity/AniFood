using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiAniFood.Models.Context;
using ApiAniFood.Repository.Class;
using ApiAniFood.Repository.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ApiAniFood {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddDbContext<CategoriaDbContext> (options =>
                options.UseMySql (Configuration.GetConnectionString ("MySqlConnectionString"))
            );
            services.AddDbContext<AlunoDbContext> (options =>
                options.UseMySql (Configuration.GetConnectionString ("MySqlConnectionString"))
            );
            services.AddDbContext<ProdutoDbContext> (options =>
                options.UseMySql (Configuration.GetConnectionString ("MySqlConnectionString"))
            );

            //services.AddTransient<ICategoriaRepository, CategoriaRepository> ();
            //services.AddTransient<IAlunoRepository, AlunoRepository> ();
            services.AddTransient<IProdutoRepository, ProdutoRepository> ();
            //services.AddTransient<IUsuarioRepository, UsuarioRepository> ();

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

            app.UseAuthentication ();
            app.UseHttpsRedirection ();
            app.UseMvc ();
        }
    }
}