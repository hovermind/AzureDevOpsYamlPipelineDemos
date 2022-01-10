using XyzAPI.Repositories;
using XyzAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IArithmeticRepository, ArithmeticRepository>();
builder.Services.AddScoped<IArithmeticService, ArithmeticService>();

var app = builder.Build();

var apiBaseUriEnvVarKey = "API_BASE_URI";
var apiBaseUri = Environment.GetEnvironmentVariable(apiBaseUriEnvVarKey);
if (!string.IsNullOrEmpty(apiBaseUri))
{
    app.UsePathBase($"/api/{apiBaseUri}");
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
