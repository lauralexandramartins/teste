//public class Program
// {
//   static void Main()
//   {
//     Produto p = new Produto("Notebook", "1995", 23);

//     p.NomeProduto = "Notebook";
//     p.Valor = 3333;
//     p.Código = "1995";
//   }

//   public class Produto
//   {
//     private string _NomeProduto { get; set; }
//     private string _Codigo { get; set; }

//     private double _valor { get; set; }

//     public Produto(string nomeProduto, string codigo, double valor)
//     {
//       this._NomeProduto = nomeProduto;
//       this._Codigo = codigo;
//       this._valor = valor;
//     }
//     public string NomeProduto
//     {
//       get
//       {
//         return _NomeProduto;
//       }
//       set
//       {
//         if (value != "Notebook")
//         {
//           Console.WriteLine("Nome Invalido");
//         }
//         else
//         {
        
//           _NomeProduto = value;
//         }

//       }
//     }
//     public string Código
//     {
//       get
//       {
//         return _Codigo;
//       }
//       set
//       {
//         if (value != "1995")
//         {
//           Console.WriteLine("Código Inválido");
//         }
//         else
//         {
//           _Codigo = value;
//         }
//       }
//     }
//     public double Valor
//     {
//       get
//       {
//         return _valor;
//       }
//       set
//       {
//         _valor = value;
//       }
//     }
//   }
// }
