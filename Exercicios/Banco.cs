//public class Program
// {
//   static void Main()
//   {
//     Banco b = new Banco("Lorena", 22.90);

//     Console.WriteLine($"Olá,{b.nome}");
//     Console.WriteLine($"Seu saldo é de {b.saldo}");

//     b.Depositar(200.10);
//     Console.WriteLine($"Você acabou de fazer um depósito. O seu saldo atual é de {b.saldo}");

//     b.Sacar(165);
//     Console.WriteLine($"Você acabou de sacar, seu saldo Atual é de {b.saldo}");
   

//   }
//   public class Banco
//   {
//     public string nome{get; set;}
//     private double _saldo { get; set;}
//       public double saldo{
//       get
//       {
//         return _saldo;
//       }
//       set{
//         _saldo = value;
//         }
//     }
//     public Banco(string nome, double saldo )
//     {
//       this.nome = nome;
//       this._saldo = saldo;
//     }


//     public void Depositar(double valor)
//     {
//       if (valor > 0)
//       {
//         _saldo += valor;
//       }
//     }
//     public void Sacar(double valor)
//     {
//       if (valor > 0 && valor <= _saldo)
//       {
//         _saldo -= valor;
//       }
//     }
    

//   }
// }
