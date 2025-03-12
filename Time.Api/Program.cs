using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

app.MapScalarApiReference();

app.UseHttpsRedirection();

app.MapGet("/time", () =>
{
    return Results.Ok(new
    {
        CurrentTime = DateTime.Now,
        TimeZone = "UTC"
    });
});

app.Run();