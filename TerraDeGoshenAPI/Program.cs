using TerraDeGoshenAPI.src.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services
    .AddGoogleCloudConfig(builder.Configuration)
    .AddCorsConfig()
    .AddSwaggerConfig()
    .AddAutoMapper(typeof(Program).Assembly)
    .AddAdapters()
    .AddServices()
    .AddRepositories(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();