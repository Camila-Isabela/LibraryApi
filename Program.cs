using LibraryApi.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Doc OpenAPI (Scalar)
builder.Services.AddOpenApi();

// Doc Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

builder.Services.AddSingleton<ILibraryService, LibraryService>();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
