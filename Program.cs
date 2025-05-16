public class Aluno
{
  public string Nome { get; set; } = "";
    public string Curso { get; set; }
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
                where alu.Nome == "A"
                orderby alu.Nome
                select new
                {
                  Nome = alu.Nome,
                  Frequencia = fre.Value
                };


    foreach (var item in busca)
    {
      Console.WriteLine(item);
    }

   
  }
}
