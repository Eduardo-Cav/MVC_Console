using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos){
            
            foreach (var item in produtos)
            {
                Console.WriteLine($"Código do produto = {item.Codigo}");
                Console.WriteLine($"Nome = {item.Nome}");
                Console.WriteLine($"Preco = R$ {item.Preco}");
                Console.WriteLine();
            }
            
        }
            public Produto CadastrarProduto(){
                
                Produto product = new Produto();

                Console.WriteLine($"Digite o código do produto: ");
                product.Codigo = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o nome do produto: ");
                product.Nome = Console.ReadLine();
                
                Console.WriteLine($"Digite o preço do produto:");
                product.Preco = float.Parse(Console.ReadLine());
                Console.WriteLine();
                

                return product;           
            }
    }
}