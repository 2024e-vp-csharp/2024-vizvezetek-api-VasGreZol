using Microsoft.EntityFrameworkCore;
using Vizvezetek.API.Context;
using Vizvezetek.API.Controllers;

namespace Vizvezetek.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<VizvezetekContext>(x =>
                x.UseMySql(builder.Configuration.GetConnectionString("VizvezetekDB"),
                ServerVersion.Parse("10.4.28-mariadb")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}