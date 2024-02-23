using Microsoft.EntityFrameworkCore;
using Sample.Content;

namespace Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<AuthProjectContext>(options =>
            {
                options.UseSqlite("Data Source=auth.db");
            });

            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}
