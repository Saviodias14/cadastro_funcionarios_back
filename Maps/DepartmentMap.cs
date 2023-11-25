using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastro_funcionarios_back.Map;
using cadastro_funcionarios_back.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cadastro_funcionarios_back.Maps;
public class DepartmentMap : BaseMap<Department>
{
    public DepartmentMap() : base("departments")
    { }

    public override void Configure(EntityTypeBuilder<Department> builder)
    {
        base.Configure(builder);
        builder.HasIndex(x => x.Name).IsUnique();
        builder.Property(x => x.Name).HasColumnName("name").IsRequired().HasMaxLength(30);
    }
}
