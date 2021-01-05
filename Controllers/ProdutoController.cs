using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {
        //models
        Produto produto = new Produto();

        //views
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos(){
            
            produtoView.Listar(produto.Read());

        }
    }
}