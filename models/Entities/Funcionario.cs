using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using cadastro_funcionarios_back.models;
using cadastro_funcionarios_back.models.Entities;
using Microsoft.EntityFrameworkCore;

namespace cadastro_funcionario_back.models;

public class Funcionario : Base
{
    public string? Name { get; set; }

    public string? Cpf { get; set; }

    public int DepartmentId { get; set; }

    public Department? Department { get; set; }

    public int Salary { get; set; }

    public DateTime Birthday { get; set; }
}
