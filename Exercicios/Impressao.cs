// // 🔹 Exercício 1 – Interface de Impressão
// // Objetivo: Criar uma interface e implementações diferentes.
// // Crie a interface IImprimivel com o método void Imprimir().
// // Crie as classes Relatorio, Etiqueta e Contrato que implementam essa interface.
// // Cada classe deve imprimir um texto diferente.
// // No Main(), adicione objetos das 3 classes em uma lista e use foreach para chamar Imprimir().

// public interface IImpressão
// {
//   void Imprimir();
// }
// public class Etiqueta : IImpressão
// {
//   public Etiqueta(int quant)
//   {
//     this.quant = quant;
//   }

//   public int quant { get; set; }

//   void IImpressão.Imprimir()
//   {
//     Console.WriteLine($"{quant} Etiquetas Imprimidas");
//   }
// }

// public class Contrato : IImpressão
// {
//   private int quant;

//   public Contrato(int quant)
//   {
//     this.quant = quant;
//   }

//   void IImpressão.Imprimir()
//   {
//     Console.WriteLine($"{quant} Contratos Imprimidos");
//   }
// }

// public class Relatorio : IImpressão
// {
//   private int quant;

//   public Relatorio(int quant)
//   {
//     this.quant = quant;
//   }

//   void IImpressão.Imprimir()
//   {
//     Console.WriteLine($"{quant} Relatórios Impressos");
//   }
// }
// public class Program
// {
//   static void Main()
//   {
//     List<IImpressão> impressãos = new List<IImpressão>();
//     Console.Write("Qual das opções você deseja imprimir (Etiqueta, Contrato, Relatório):  ");
//     string itens = Console.ReadLine();

//     Console.WriteLine("Digite a quantidade: ");
//     int quant = int.Parse(Console.ReadLine());

//     if (itens.ToLower() == "etiqueta")
//     {
//       impressãos.Add(new Etiqueta(quant));
//     }
//     else if (itens.ToLower() == "contrato")
//     {
//       impressãos.Add(new Contrato(quant));
//     }
//     else if (itens.ToLower() == "relatorio")
//     {
//       impressãos.Add(new Relatorio(quant));
//     }
//     else
//     {
//       Console.WriteLine("Opção inválida");
//     }

//     foreach (var item in impressãos)
//     {
//       item.Imprimir();
//     }

//   }
// }
