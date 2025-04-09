using Store.Models;

namespace Store.ViewModels;

public class ProdutoVM
{
    public Produto Produto { get; set; }
    public List<Produto> Produtos { get; set; }
    
}
