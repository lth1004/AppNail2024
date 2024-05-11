using FluentValidation;
using Microsoft.EntityFrameworkCore;
using NailApp.API.Models;
using NailApp.API.Validators;
using NailApp.Data;
using NailApp.Data.Authorization;
using NailApp.Data.Helpers;
using NailApp.Data.Interfaces;
using NailApp.Data.Repositories;
using NailApp.Services.Interfaces;
using NailApp.Services.Services;

namespace NailApp.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            // configure strongly typed settings object
            services.AddTransient(typeof(IJwtUtils), typeof(JwtUtils));
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionNailDB")));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IUserRepository), typeof(UserRepository));
            services.AddTransient(typeof(IUserService), typeof(UserService));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers();
            services.AddTransient<IValidator<User>, CreateUserRequestValidator>();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

                // custom jwt auth middleware
                app.UseMiddleware<JwtMiddleware>();
                endpoints.MapControllers();
            });
        }

    }
}
