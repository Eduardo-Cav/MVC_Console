using System;
using MVC_Console.Controllers;
using MVC_Console.Models;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController p = new ProdutoController();
            p.Cadastrar();
            p.ListarProdutos();
            
        }
    }
}
