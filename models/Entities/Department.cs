using cadastro_funcionario_back.models;
using cadastro_funcionarios_back.models.Entities;

namespace cadastro_funcionarios_back.models
{
    public class Department : Base
    {
        public string? Name { get; set; }

        // Relacionamento 1:N com Funcionarios
        public List<Funcionario>? Funcionarios { get; set; }
    }
}