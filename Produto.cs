namespace EF.Exemplo3;

public class Produto
{
    public int ProdutoID { get; set; }
    public string ProdutoNome { get; set; }
    public decimal ProdutoPreco { get; set; }
    public int ProdutoEstoque { get; set; }
    public bool ProdutoAtivo { get; set; }

    public Produto()
    {
    }
}