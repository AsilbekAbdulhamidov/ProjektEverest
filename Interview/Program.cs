using Interview.Context;
using Interview.Extation;
using Interview;
using Interview;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
StartUp(builder.Services, builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();


static void StartUp(IServiceCollection services, ConfigurationManager manager)
{
    services.AddControllers();
    services.AddDbContext<AppDbContext>(p => p.UseNpgsql(manager.GetConnectionString("Defaultconnection")));
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    services.AddService();
    services.AddRepostory();

    services.AddControllers();

   
    
}