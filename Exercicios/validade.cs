// using System;
// using System.Collections.Generic;

// public interface Validade
// {
//     void VerificarValidade();
// }

// public abstract class Produto : Validade
// {
//     private static int contadorId = 1;

//     private int _id;
//     public int Id
//     {
//         get { return _id; }
//         private set { _id = value; }
//     }

//     private string _nome = "";
//     public string Nome
//     {
//         get { return _nome; }
//         set { _nome = value; }
//     }

//     private DateTime _dataVencimento;
//     public DateTime DataVencimento
//     {
//         get { return _dataVencimento; }
//         set { _dataVencimento = value; }
//     }

//     private double _preco;
//     public double Preco
//     {
//         get { return _preco; }
//         set { _preco = value; }
//     }

//     public Produto(string nome, DateTime dataVencimento, double preco)
//     {
//         Id = contadorId++;
//         Nome = nome;
//         DataVencimento = dataVencimento;
//         Preco = preco;
//     }

//     public abstract double TotalProduto();

//     public virtual void ExibirInformacoes()
//     {
//         Console.WriteLine($"ID: {Id}, Nome: {Nome}, Preço: {Preco:C}, Validade: {DataVencimento.ToShortDateString()}");
//     }

//     public void VerificarValidade()
//     {
//         if (DateTime.Now > DataVencimento)
//         {
//             Console.WriteLine($" Produto {Nome} está fora da validade ({DataVencimento.ToShortDateString()})");
//         }
//         else
//         {
//             Console.WriteLine($" Produto {Nome} está na validade ({DataVencimento.ToShortDateString()})");
//         }
//     }
// }

// public class ProdutoAlimentício : Produto
// {
//     public ProdutoAlimentício(string nome, DateTime dataVencimento, double preco)
//         : base(nome, dataVencimento, preco) { }

//     public override double TotalProduto()
//     {
//         if (DataVencimento > DateTime.Now.AddMonths(1))
//         {
//             return Preco * 0.9; // 10% de desconto
//         }
//         return Preco;
//     }
// }

// public class ProdutoEletronico : Produto
// {
//     public ProdutoEletronico(string nome, DateTime dataVencimento, double preco)
//         : base(nome, dataVencimento, preco) { }

//     public override double TotalProduto()
//     {
//         return Preco * 0.85; // 15% de desconto fixo
//     }
// }

// public class GerenciarProduto
// {
//     private Dictionary<int, Produto> produtos;

//     public GerenciarProduto()
//     {
//         produtos = new Dictionary<int, Produto>();
//     }

//     public void AdicionarProduto(Produto produto)
//     {
//         produtos[produto.Id] = produto;
//     }

//     public void AlterarPreco(int id, double novoPreco)
//     {
//         if (produtos.ContainsKey(id))
//         {
//             produtos[id].Preco = novoPreco;
//             Console.WriteLine($" Preço do produto {id} atualizado para {novoPreco:C}");
//         }
//         else
//         {
//             Console.WriteLine(" Produto não encontrado!");
//         }
//     }

//     public void ExibirProduto()
//     {
//         foreach (var item in produtos.Values)
//         {
//             item.ExibirInformacoes();
//             Console.WriteLine($" Preço com desconto: {item.TotalProduto():C}");
//             item.VerificarValidade();
//             Console.WriteLine(new string('-', 50));
//         }
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         GerenciarProduto gerenciarProduto = new GerenciarProduto();

//         Produto produto = new ProdutoAlimentício("Bolo", new DateTime(2023, 9, 23), 30.99);
//         Produto produto1 = new ProdutoEletronico("Celular", new DateTime(2039, 3, 20), 4998.90);
//         Produto produto2 = new ProdutoAlimentício("Arroz", new DateTime(2025, 11, 3), 22.99);
//         Produto produto3 = new ProdutoEletronico("Televisão", new DateTime(2032, 8, 3), 2999.99);

//         gerenciarProduto.AdicionarProduto(produto);
//         gerenciarProduto.AdicionarProduto(produto1);
//         gerenciarProduto.AdicionarProduto(produto2);
//         gerenciarProduto.AdicionarProduto(produto3);

//         gerenciarProduto.AlterarPreco(1, 333.33);
//         gerenciarProduto.ExibirProduto();

    
//     }
// }
