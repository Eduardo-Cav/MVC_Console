using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Produto(){
            //Verificar se a pasta existe
            string pasta = PATH.Split("/")[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            //Verificar se o arquivo existe
            if(!File.Exists(PATH)){
                File.Create(PATH);
            }
        }

        public List<Produto> Read(){
            
            //lista criada pra armazenar os produtos
            List<Produto> products = new List<Produto>();

            //Leitura de linhas do csv
            string[] linhas = File.ReadAllLines(PATH);

            //Passagem pelas linhas
            foreach (var item in linhas)
            {
                //Seperação dos elementos
                string[] atributos = item.Split(";");
                // 1;JBL;5000,00
                // 0 = code
                // 2 = name
                // 2 = price

                Produto prod = new Produto();

                //passamos para um objeto do tipo produto
                prod.Codigo = int.Parse(atributos[0]);
                prod.Nome = (atributos[1]);
                prod.Preco = float.Parse(atributos[2]);

                products.Add(prod);
            }

            return products;
        }
        
        public void Inserir(Produto product){
            
            //array de linhas para inserir no csv
            string[] linhas = {PrepararLinhasCSV(product)};

            //insere linhas
            File.AppendAllLines(PATH, linhas); 
        }


        public string PrepararLinhasCSV(Produto produto){

            return $"{produto.Codigo};{produto.Nome};{produto.Preco}";
        }
        
    }
}