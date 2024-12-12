using Domain.Model;
using Infrastructure.Extensions;

namespace TT_API;

 public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddInfrastructure(builder.Configuration);

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddAuthorization();

        builder.Services.AddSwaggerGen();

        builder.Services.AddSingleton(TimeProvider.System);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.MapIdentityApi<User>();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
