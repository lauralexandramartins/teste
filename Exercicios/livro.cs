//  Exercício 3 – Sistema de Biblioteca (Encapsulamento + Interface)
// // Objetivo: Praticar encapsulamento e contrato via interface.
// // Instruções:
// // Crie uma interface IEmprestavel com método Emprestar().
// // Crie uma classe Livro com os atributos privados _titulo, _autor e método público Emprestar().
// // Faça Livro implementar IEmprestavel.
// // No Main(), instancie um Livro, defina os valores via construtor ou propriedades, e chame o método Emprestar()

// public interface IEmprestavel
// {
//   void Emprestar();
// }
// public class Livro : IEmprestavel
// {
//   private string _Titulo{get; set;}
//   public string Titulo
//   {
//     get 
//     {
//       return _Titulo;
//     }
//     set 
//     {
//       _Titulo = value;
//     }
//   }
//   private string _Autor{get; set;}
//   public string Autor 
//   {
//     get
//     {
//       return _Autor;
//     }
//     set
//     {
//       _Autor = value;
//     }
//   }
//   public Livro(string titulo, string autor)
//   {
//     this._Autor = autor;
//     this.Titulo = titulo;
//   }
//   public void Emprestar()
//   {
//     Console.WriteLine($"O livro {_Titulo}, pertence ao autor(a): {_Autor}");
//   }
// }
// public class Program
// {
//   static void Main()
//   {
//     List<IEmprestavel> emprestavels = new List<IEmprestavel>();
//     emprestavels.Add(new Livro("O Amor", "Mariana"));

//     foreach (var item in emprestavels)
//     {
//       item.Emprestar();
//     }
//   }
// }

