using Microsoft.EntityFrameworkCore;
using SchoolApiService.Extensions;
using SchoolApiService.Settings;
using SchoolApp.DAL.SchoolContext;

namespace SchoolApiService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("Jwt"));
            var jwtSettings = builder.Configuration.GetSection("Jwt").Get<JwtSettings>();
            builder.Services.ConfigureCors();
            builder.Services.AddControllers();
            var connectionString = builder.Configuration.GetConnectionString("SqlServerConnection");
            builder.Services.AddDbContext<SchoolDbContext>(options =>
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("SchoolApp.DAL")));

            builder.Services.ConfigureIdentity();
            builder.Services.ConfigureAllServices();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAuth(jwtSettings);
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuth();
            app.MapControllers();

            app.Run();
        }
    }
}
