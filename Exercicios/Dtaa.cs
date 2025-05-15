//public interface Validar
// {
//     public void DataValidade();    
// }
// public class Produto : Validar
// {
//     private string _nome{get; set;}
//     public string Nome
//     {
//         get{return _nome;}
//         set{_nome = value;}
//     }
//     public DateTime dataValidade{get; set;}
//     public Produto(string nome, DateTime data)
//     {
//         this._nome = nome;
//         this.dataValidade = data;
//     }
//     public void DataValidade()
//   {
//     int anoValidade = 2026;
//     if(dataValidade.Year < anoValidade)
//     {
//         Console.WriteLine($"O Produto {_nome} fora da validade, ele já venceu em {dataValidade}");
//     }
//     else
//     {
//         Console.WriteLine($"O produto {_nome} Dentro da validade, ele só vence em {dataValidade}");
//     }
//   }
// }

// public class Datetime
// {
// }

// public class Program
// {
//     static void Main()
//     {
//         List<Produto> produtos = new List<Produto>();
//         produtos.Add(new Produto("Bolo", new DateTime (2025, 5, 1)));  // Data de validade: 1º de maio de 2025
//         produtos.Add(new Produto("Barra de Chocolate", new DateTime(2020, 10, 10))); // Data de validade: 10 de outubro de 2020
//         produtos.Add(new Produto("Arroz", new DateTime(2080, 1, 1)));  // Data de validade: 1º de janeiro de 2080
//         produtos.Add(new Produto("Pasta de Dente", new DateTime(2026, 12, 31))); // Data de validade: 31 de dezembro de 2026


//         foreach (var item in produtos)
//         {
//             item.DataValidade();
//         }
//     }
// }
