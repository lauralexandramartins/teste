// public interface Ipagamento
// {
//    void ProcessarPagamento();
   
// }
// public abstract class PagamentoBase : Ipagamento
// {
//   private double _valor {get; set;}
//   protected DateTime DataPagamento;

//   public double Obtervalor
//   {
//     get
//     {
//       return _valor;
//     }
//     set
//     {
//       _valor = value;
//     }
//   }
//   public PagamentoBase(double valor)
//   {
//     this._valor = valor;
//     this.DataPagamento = DateTime.Now;
//   }

//   public abstract void ProcessarPagamento();
 
// }

// public class PagamentoCartao : PagamentoBase
// {
//   public PagamentoCartao(double valor) : base(valor)
//   {
//     this.Obtervalor = valor;
//     this.DataPagamento = DateTime.Now;
//   }
//       public override void ProcessarPagamento()
//       {
//         Console.WriteLine($"Pagamento no cartão: R${Obtervalor:F2} em {DataPagamento}");
//       }

//   }
//   public class PagamentoBoleto:    
//   {
//     public PagamentoBoleto(double valor) : base(valor)
//     {
//       this.Obtervalor = valor;
//       this.DataPagamento = DateTime.Now;
//     }
//   public override void ProcessarPagamento()
//   {
//     Console.WriteLine($"Pagamento no Boleto: R${Obtervalor:F2} em {DataPagamento}");
//   }
//   }
// public class Program
// {
//   static void Main()
//   {
//     List<Ipagamento> ipagamentos = new List<Ipagamento>();
//     Console.WriteLine("Qual a forma de Pagamento? ");
//     string formap = Console.ReadLine();

//     Console.WriteLine("Informe o valor do pagamento: ");
//     double ip = double.Parse(Console.ReadLine());

//     if(formap.ToLower() == "boleto")
//     {
//       ipagamentos.Add(new PagamentoBoleto(ip));
//     }
//      else if (formap.ToLower() == "cartao")
//     {
//       ipagamentos.Add(new PagamentoBoleto(ip));
//     }
//     else
//     {
//       Console.WriteLine("Forma de Pagamento inesistente");
//     }

//     foreach (var item in ipagamentos)
//     {
//       item.ProcessarPagamento();
//     }
//   }
// }


