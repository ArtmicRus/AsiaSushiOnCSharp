using AsiaSushiOnCSharp.Application.Interfaces;
using AsiaSushiOnCSharp.Domain.InterfacesForRepo;
using AsiaSushiOnCSharp.Persistence;
using AsiaSushiOnCSharp.Persistence.Repositories;
using Microsoft.AspNetCore.Connections;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        builder.Services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
        {
            var connectionFactory = serviceProvider.GetRequiredService<IConnectionFactory>();

            options.UseNpgsql(connectionFactory.GetConnection(), npgSqlOptions =>
            {
                npgSqlOptions.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName);
            });

            options.EnableSensitiveDataLogging();
        });

        // Add to DI контейнер
        builder.Services.AddTransient<IApplicationDbContext, ApplicationDbContext>;
        builder.Services.AddTransient<IProductRepository, ProductRepository>;

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}