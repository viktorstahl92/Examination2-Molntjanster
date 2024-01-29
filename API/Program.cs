
using Microsoft.EntityFrameworkCore;
using Molntjanster.Data;
using Molntjanster.Entities;

namespace API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
        builder.Services.AddAutoMapper(typeof(Student));

        builder.Services.AddDbContext<MolntjansterContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MolntjansterContext") ?? throw new InvalidOperationException("Connection string 'MolntjansterContext' not found.")));

        builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
        {
            builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
        }));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseCors("corsapp");

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
