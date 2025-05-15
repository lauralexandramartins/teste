// namespace ListarNumeros
// {
//   public class Program
//   {
//     static void Main()
//     {
//       List<int> numero = new List<int>() { 2, 3, 4, 9 };

//       Estatistica est = new Estatistica();
//       est.Média(numero);
//       Estatistica.MaiorNumero(numero);
//       Estatistica.MenorNumero(numero);


//     }
//     public class Estatistica()
//     {

//       public double Média(List<int> numero)
//       {
//         double resultado = 0;
//         int soma = 0;
//         foreach (var item in numero)
//         {
//           soma += item;

//         }
//         resultado = soma / numero.Count;

//         Console.WriteLine($"A média dos números é {resultado}");
//         return resultado;
//       }
//       public static int MaiorNumero(List<int> numero)
//       {
//         int valor = 0;
//         foreach (var item in numero)
//         {
//             valor = numero[0];
//             if (item > valor)
//             {
//               valor = item;
//           }
//         }
//         Console.WriteLine($"O maior número é {valor}");
//         return valor;
//       }
//       public static int MenorNumero(List<int> numeros)
//       {
//         int valores = 0;
//         foreach (var item in numeros)
//         {
//         valores = numeros[0];
//         if (item <  valores)
//         {
//           valores = item;
//         }
//           }
//           Console.WriteLine($"O menor número é {valores}");
//           return valores;
//         }
//       }
//     }
//   }

//   double nim = 0;
//       int max = 0;
//       int min = 0;
//       List<int> numero = new List<int>() { 2, 3, 4, 9 };
//       nim = (double)numero.Average();
//       max= numero.Max();

//       min = numero.Min();

//       Console.WriteLine($"média {nim}");
//       Console.WriteLine($" maior {max}");
//       Console.WriteLine($"menror {min}");



