
// // 🔹 Exercício 1 – Sistema de Veículos (Herança + Polimorfismo)
// // Objetivo: Criar uma hierarquia de veículos com comportamento comum.

// // Instruções:
// // Crie uma classe abstrata chamada Veiculo com a propriedade Modelo e um método abstrato ExibirInfo().
// // Crie duas classes filhas:
// // Carro: sobrescreve ExibirInfo() exibindo "Carro: [Modelo]".
// // Moto: sobrescreve ExibirInfo() exibindo "Moto: [Modelo]".
// // No Main(), crie uma lista de Veiculo, adicione um carro e uma moto, e use foreach para exibir as informações.

// public abstract class Veiculo
// {
//   public string Modelo{get; set;}

//   public abstract void ExibirInfo();
// }
// public class Carro : Veiculo
// {
//   private string Modelo;

//   public Carro(string modelo)
//   {
//     this.Modelo = modelo;
//   }

//   public override void ExibirInfo()
//   {
//     Console.WriteLine($"Carro: [{Modelo}]");  
//   }
// }

// public class Moto : Veiculo
// {
//   private string modelo;

//   public Moto(string modelo)
//   {
//     this.modelo = modelo;
//   }

//   public override void ExibirInfo()
//   {
//     Console.WriteLine($"Moto: [{modelo}]");
//   }
// }
// public class Program
// {
//   static void Main()
//   {
//     List<Veiculo> veiculos = new List<Veiculo>();
//     veiculos.Add(new Carro("Jeep"));
//     veiculos.Add(new Moto("XR2500"));

//     foreach (var item in veiculos)
//     {
//       item.ExibirInfo();
//     }
//   }
// }
