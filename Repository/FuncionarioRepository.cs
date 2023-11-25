
using cadastro_funcionario_back.models;
using cadastro_funcionarios_back.Context;
using cadastro_funcionarios_back.Repository.Interfaces;

namespace cadastro_funcionarios_back.Repository;

public class FuncionarioRepository : BaseRepository, IFuncionarioRepository
{
    private readonly FuncionariosContext _context;
    public FuncionarioRepository(FuncionariosContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<Funcionario> Get()
    {
        return _context.Funcionarios.ToList();
    }

    public Funcionario GetById(int id)
    {
        throw new NotImplementedException();
    }
}
