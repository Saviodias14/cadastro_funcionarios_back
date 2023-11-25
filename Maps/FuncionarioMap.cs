using cadastro_funcionario_back.models;
using cadastro_funcionarios_back.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cadastro_funcionarios_back.Maps;

public class FuncionarioMap : BaseMap<Funcionario>
{
    public FuncionarioMap() : base("funcionarios")
    { }

    public override void Configure(EntityTypeBuilder<Funcionario> builder)
    {
        base.Configure(builder);
        builder.HasIndex(x => x.Cpf).IsUnique();
        builder.Property(x => x.Name).HasColumnName("name").IsRequired().HasMaxLength(50);
        builder.Property(x => x.Cpf).HasColumnName("cpf").IsRequired().HasMaxLength(11);
        builder.Property(x => x.DepartmentId).HasColumnName("department_id").IsRequired();
        builder.Property(x => x.Birthday).HasColumnName("birthday").IsRequired();
        builder.Property(x => x.Salary).HasColumnName("salary").IsRequired();
        builder.HasOne(x => x.Department).WithMany(x => x.Funcionarios).HasForeignKey(x => x.DepartmentId);
    }
}
