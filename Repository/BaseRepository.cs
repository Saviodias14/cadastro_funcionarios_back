using cadastro_funcionarios_back.Context;
using cadastro_funcionarios_back.Repository.Interfaces;

namespace cadastro_funcionarios_back.Repository;

public class BaseRepository : IBaseRepository
{
    private readonly FuncionariosContext _context;
    public BaseRepository(FuncionariosContext context)
    {
        _context = context;
    }
    public void Add<T>(T entity) where T : class
    {
        throw new NotImplementedException();
    }

    public void Delete<T>(T entity) where T : class
    {
        throw new NotImplementedException();
    }

    public bool SaveChanges()
    {
        throw new NotImplementedException();
    }

    public void Update<T>(T entity) where T : class
    {
        throw new NotImplementedException();
    }
}
