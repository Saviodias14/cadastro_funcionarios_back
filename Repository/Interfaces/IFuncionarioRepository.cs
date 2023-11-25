using cadastro_funcionario_back.models;

namespace cadastro_funcionarios_back.Repository.Interfaces;

public interface IFuncionarioRepository : IBaseRepository
{
    IEnumerable<Funcionario> Get();

    Funcionario GetById(int id);
}
