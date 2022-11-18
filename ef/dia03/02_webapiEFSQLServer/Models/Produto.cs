namespace _02_webapiEFSQLServer.Models;

public class Produto
{
    public int id {get; set;}
    public string nome{get; set;}=null!;
    public string? descricao{get;set;}
    public int valorUnitario {get; set;}
    //public List<Item> itens {get; set;}=null!;
    public List<Pedido> pedidos {get; set;}=null!;    
    public List<Item> itens {get; set;} = null!;
    
}
