using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideportal.backend.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ideportal.backend
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
            services.AddSwaggerDocument();

            var connectionString = Configuration.GetConnectionString("DBconnection");
            services.AddDbContext<ProjectDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddDbContext<SubmitDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddDbContext<AdminDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });



            //services.AddCors(c =>
            //{
            //    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            //});


            //services.AddCors(c =>
            //{
            //    c.AddPolicy("AllowOrigin", options => options.WithOrigins("https://localhost:8080"));
            //});



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(options => options.AllowAnyOrigin()
                                    .AllowAnyHeader()
                                    .AllowAnyMethod()
                                    
            );


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseStaticFiles();

            //app.UseCors("VueCorsPolicy");
            //{
            //    options.WithOrigins("http://localhost:8080"));
            //builder.AllowAnyOrigin();
            //builder.AllowAnyMethod();
            //builder.AllowAnyHeader();
            //});
        }
    }
}
