using cadastro_funcionario_back.models;
using cadastro_funcionarios_back.models;
using Microsoft.EntityFrameworkCore;

namespace cadastro_funcionarios_back.Context;
public class FuncionariosContext : DbContext
{
    public FuncionariosContext(DbContextOptions<FuncionariosContext> options) : base(options) { }

    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
