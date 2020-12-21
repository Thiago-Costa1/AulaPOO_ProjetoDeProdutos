using System;
using System.Collections.Generic;

namespace Nova_pasta.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario Usuario = new Usuario();

        public List<Produto> ListaDeProduto = new List<Produto>();


        public void Cadastrar()
        {

            Produto novoProduto = new Produto();

            Console.WriteLine($"Digite o código do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());


            Console.WriteLine($"Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.Now;

            novoProduto.DataCadastro = DateTime.Now;



            // Chamamos um método do objeto/propriedade "Marca"
            novoProduto.Marca = Marca.Cadastrar();

            // Utilizamos o próprio método construtor para atribuir um objeto completo de usuário
            novoProduto.Usuario = new Usuario();

            ListaDeProduto.Add(novoProduto);
        }

        public void Listar()
        {

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Produto item in ListaDeProduto)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: R$ {item.Preco}");
                Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado Por: {item.Usuario.Nome}");
            }

            Console.ResetColor();
        }

        public void Deletar(int cod)
        {
            Produto prodDelete = ListaDeProduto.Find(p => p.Codigo == cod);
            ListaDeProduto.Remove(prodDelete);
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Deletado com sucesso!");


            Console.ResetColor();

        }



    }
}