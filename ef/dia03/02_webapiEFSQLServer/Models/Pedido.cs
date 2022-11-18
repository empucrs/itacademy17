namespace _02_webapiEFSQLServer.Models;

public class Pedido
{
    public int id {get; set;}

    public DateTime dataDaAquisicao {get;set;}
    public Cliente cliente {get; set;}=null!;  

    public List<Produto> produtos {get; set;}=null!;
    public List<Item> itens {get; set;}=null!;
    
}
