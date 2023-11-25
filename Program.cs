using cadastro_funcionarios_back.Context;
using cadastro_funcionarios_back.Repository;
using cadastro_funcionarios_back.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IBaseRepository, BaseRepository>();
builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();

string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<FuncionariosContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
    assembly => assembly.MigrationsAssembly(typeof(FuncionariosContext).Assembly.FullName));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("V1", new OpenApiInfo { Title = "Funcionários", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Funcionários V1");
});
}
app.UseRouting();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

