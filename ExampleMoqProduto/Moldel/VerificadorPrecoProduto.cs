using ExampleMoqProduto.Interfaces;

namespace ExampleMoqProduto.Moldel
{
    public class VerificadorPrecoProduto : IVerificadorPrecoProduto
    {
       public string VerificaPrecoProduto(Produto p)
       {
           if(p.Preco > 100)
                return "Produto Caro!";
           else if(p.Preco <= 100 && p.Preco > 40)
                return "Produto na média de preço!";
           else
                return "Produto Barato!";
       }
    }
}