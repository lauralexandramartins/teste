
// namespace Empresa
// {
//   public class Program
//   {
//     static void Main()
//     {
//       FuncionarioCLT clt = new FuncionarioCLT()
//       {
//         Nome = "Laura",
//         Salario = 2000
//       }; 

//       Autonomo aut = new Autonomo()
//       {
//         Nome = "João",
//         Salario = 2220,
//         HorasTrabalhadas = 8
        
//       };
//       Console.WriteLine("=== CLT ===");
//       Console.WriteLine($"Nome: {clt.Nome}");
//       Console.WriteLine($"Sálario: {clt.Salario}");

//       Console.WriteLine("");

//       Console.WriteLine("=== Autônomo === ");
//       Console.WriteLine($"Nome: {aut.Nome}");
//       Console.WriteLine($"Sálario: {aut.Salario}");

//     }
//   public abstract class Funcionário
//   {
//     private string _nome {get; set;}

//     public abstract double ValorSalário();
//     public virtual void MostrasInformacoes()
//     {
//       Console.WriteLine(Nome);
//     }

//     public string Nome
//     {
//       get
//     {
//       return _nome;
//     }
//     set
//     {
//       _nome = value;
//     }
//     }

   
//   }

//   class FuncionarioCLT : Funcionário
//   {
//     public  double Salario{get; set;}
//     public override double ValorSalário()
//     {
//       return Salario;
//     }
//   }
//   class Autonomo : Funcionário
//   {
//     private double _salário{get;set;}
//     private double _horasTrabalhadas{get;set;}
//     public override double ValorSalário()
//       {
//         return _salário*_horasTrabalhadas;
//       }
//       public override void MostrasInformacoes()
//       {
//         Console.WriteLine($"O Nome é {Nome}");
//       }
//   public double Salario
//   {
//     get
//     {
//       return _salário*_horasTrabalhadas;
//     }//     set
//     {
//       _salário = value;
//     }
//   }
//    public double HorasTrabalhadas
//     {
//       get
//       {
//         return _horasTrabalhadas;
//       }
//       set
//       {
//         _horasTrabalhadas = value;
//       }
//     }
//   }
//   }
// }
