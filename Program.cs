public class Aluno
{
  public string Nome { get; set; } = "";
  public string Curso { get; set; } = "";
}

public class Program
{
  static void Main()
  {
    List<Aluno> alunos = new List<Aluno>
{
    new Aluno { Nome = "Lucas", Curso = "Matemática" },
    new Aluno { Nome = "Júlia", Curso = "Física" },
    new Aluno { Nome = "Rafael", Curso = "Química" },
    new Aluno { Nome = "Camila", Curso = "Matemática" },
    new Aluno { Nome = "Camila", Curso = "Matemática" }
};

    Dictionary<string, int> frequencia = new Dictionary<string, int>
{
    { "Lucas", 18 },
    { "Júlia", 12 },
    { "Rafael", 15 },
    { "Camila", 20 }
};



    var busca = from alu in alunos
                join fre in frequencia on alu.Nome equals fre.Key
                orderby alu.Nome, fre.Value
                select new
                {
                  Nome = alu.Nome,
                  Frequencia = fre.Value
                };


    foreach (var item in busca)
    {
      Console.WriteLine(item);
    }
    List<int> number = new List<int> { 10, 5, 7, 20, 3, 8, 1, -1, -100 };
    int r = number.Last(num => num < 50);
    int g = number.Count();
    Console.WriteLine(g);
    var e = number.ToList();
      {
        
      }
      foreach (var item in e)
    {    Console.WriteLine(item);

    }

  }
}
