// 🔹 Exercício 2 – Sistema de Funcionários
// Objetivo: Usar herança + polimorfismo + encapsulamento.
// Crie uma classe base Funcionario com propriedade protegida Nome e método virtual ExibirDados().
// Crie duas classes filhas:
// // Gerente: sobrescreve ExibirDados() e exibe "Gerente: [Nome]"
// // Desenvolvedor: sobrescreve ExibirDados() e exibe "Dev: [Nome]"
// // No Main(), crie uma lista de Funcionario e adicione um Gerente e um Desenvolvedor.
// // Percorra a lista e chame ExibirDados() (polimorfismo).

// public interface IFuncionarios
// {
//   void ExibirDados();
// }

// public abstract class BaseFuncionario : IFuncionarios
// {
//   public abstract void ExibirDados();

// }

// public class Gerente : BaseFuncionario
// {
//   private string _NomeG { get; set; }
//   public string NomeG
//   {
//     get
//     {
//       return _NomeG;
//     }
//     set
//     {
//       _NomeG = value;
//     }
//   }
//   public Gerente(string nome)
//   {
//     this._NomeG = nome;
//   }
//   public override void ExibirDados()
//   {
//     Console.WriteLine($"Gerente: [{_NomeG}]");
//   }
// }

// public class Dev : BaseFuncionario
// {
//   private string _nomeDev { get; set; }
//   public string nomeDev
//   {
//     get
//     {
//       return _nomeDev;
//     }
//     set
//     {
//       _nomeDev = value;
//     }
//   }
//   public Dev(string nome)
//   {
//     this._nomeDev = nome;
//   }

//   public override void ExibirDados()
//   {
//     Console.WriteLine($"Nome Desenvolvedor: [{_nomeDev}]");
//   }
// }
// public class Program
// {
//   static void Main()
//   {
//     List<IFuncionarios> funcionarios = new List<IFuncionarios>();
//     funcionarios.Add(new Gerente("José Alcântara"));
//     funcionarios.Add(new Dev("Ana Maria"));
//     funcionarios.Add(new Dev("Maraisa"));
//     funcionarios.Add(new Dev("Clarice"));

//     foreach (var item in funcionarios)
//     {
//       item.ExibirDados();
//     }


//   }
// }
