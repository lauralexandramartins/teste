//public abstract class Animal
// {
//   public abstract void EmitirSom();
// }
// public class Cachorro : Animal
// {
//   private string nome;

//   public Cachorro(string nome)
//   {
//     this.nome = nome;
//   }


//   public override void EmitirSom()
//   {
//     Console.WriteLine($"O cachorro {nome} faz: 'AuAu'");
//   }
// }

// public class Gato : Animal
// {
//   private string nome;

//   public Gato(string nome)
//   {
//     this.nome = nome;
//   }


//   public override void EmitirSom()
//   {
//     Console.WriteLine($"O gato {nome} faz: 'MiauMiau'");
//   }
// }

// public class Vaca : Animal
// {
//   private string nome;

//   public Vaca(string nome)
//   {
//     this.nome = nome;
//   }

//   public override void EmitirSom()
//   {
//     Console.WriteLine($"A vaca {nome} faz: MuuMuu");
//   }
// }
// public class Program
// {
//   static void Main()
//   {
//     List<Animal> animals = new List<Animal>();
//     animals.Add(new Vaca("Ana"));
//     animals.Add(new Gato("Margarida"));
//     animals.Add(new Cachorro("Joyce"));

//     foreach (var item in animals)
//     {
//       item.EmitirSom();
//     }
//   }
// }
