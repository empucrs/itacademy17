using _02_webapiEFSQLServer.Models;
namespace _02_webapiEFSQLServer.Services;
public interface IClienteRepo{

    public Task<Cliente?> clienteEspecifico(int id);

}