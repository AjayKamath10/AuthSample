using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Sample.Content;
using Sample.Services;
using System.Text;

namespace Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuerSigningKey = true,
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration.GetValue<string>("ServerSecret"))),
                       ValidateIssuer = false,
                       ValidateAudience = false
                   };
               });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireClaim("Roles", "admin"));
                options.AddPolicy("Manager", policy => policy.RequireClaim("Roles", "manager", "admin"));
                options.AddPolicy("Finance", policy => policy.RequireClaim("Roles", "finance"));
            });


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
