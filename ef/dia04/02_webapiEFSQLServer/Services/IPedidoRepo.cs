using _02_webapiEFSQLServer.Models;
namespace _02_webapiEFSQLServer.Services;
public interface IPedidoRepo{

    public Task<Pedido?> pedidoEspecifico(int id);
    public Task<Pedido> adicionaPedido(Pedido p);

}