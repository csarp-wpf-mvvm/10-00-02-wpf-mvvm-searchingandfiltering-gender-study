using Kreta.Backend.Context;
using Kreta.Backend.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Cors
builder.Services.ConfigureCors();
// InMemory context kofigurálása
builder.Services.ConfigureInMemoryContext();
// Repo konfigurálás
builder.Services.ConfigureRepoService();
// Assamblerek konfigurálása
builder.Services.ConfigureAssamblers();

var app = builder.Build();

// InMemory database data
using (var scope = app.Services.CreateAsyncScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<KretaInMemoryContext>();

    // InMemory test data
    dbContext.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Cors
app.UseCors("KretaCors");

app.UseAuthorization();

app.MapControllers();

app.Run();
