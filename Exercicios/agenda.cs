/*namespace Agenda
{
  public class Program
  {
    static void Main()
    {
      bool continuar = true;
      Dictionary<string, string> agenda = new Dictionary<string, string>();
      while (continuar)
      {
        Console.WriteLine("Escolha uma opção: ");
        Console.WriteLine("Opção 1 - Adicionar um contato");
        Console.WriteLine("Opção 2 - Adicionar Vários contatos ");
        Console.WriteLine("Opção 3 - Alterar contato ");
        Console.WriteLine("Opção 4 - Deletar um contato ");
        Console.WriteLine("Opção 5 - Deletar vários contatos ");
        Console.WriteLine("Opção 6 - Listar um contato ");
        Console.WriteLine("Opção 7 - Listar vários contatos ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
          case 1:
            Agenda.CriarContato(agenda);
            break;
          case 2:
            Agenda.AdicionarVariosContatos(agenda);
            break;
          case 3:
            Agenda.AlterarContato(agenda);
            break;
          case 4:
            Agenda.DeletarUmContato(agenda);
            break;
          case 5:
            Agenda.DeletarVariosContatos(agenda);
            break;
          case 6:
            Agenda.ListarUmContato(agenda);
            break;
          case 7:
            Agenda.ListarTodosContatos(agenda);
            break;

          default:
            Console.WriteLine("Opção inválida!!!");
            break;
        }
        Console.ReadKey();
        if (continuar)
        {
          Console.WriteLine("\nDeseja continuar? (s/n)");
          string resposta = Console.ReadLine().ToLower();

          if (resposta != "s")
          {
            continuar = false;  // Sai do loop
            Console.WriteLine("Saindo...");


          }

        }
      }
    }

    public static class Agenda
    {
      public static void CriarContato(Dictionary<string, string> agenda)
      {
        Console.WriteLine("Digite o nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o número de telefone");
        string telefone = Console.ReadLine();

        agenda.TryAdd(nome, telefone);
        foreach (KeyValuePair<string, string> item in agenda)
        {
          agenda.TryAdd(item.Key, item.Value);
        }
        Console.WriteLine("Contato adicionado com sucesso!!");
      }

      public static void AdicionarVariosContatos(Dictionary<string, string> agenda)
      {
        Console.WriteLine("Quantos contatos você quer adicionar?");
        int quant = int.Parse(Console.ReadLine());

        for (int i = 0; i < quant; i++)
        {
          Console.WriteLine("Digite o nome:");
          string nome = Console.ReadLine();

          Console.WriteLine("Digite o número de telefone");
          string telefone = Console.ReadLine();

          agenda.TryAdd(nome, telefone);
          foreach (KeyValuePair<string, string> item in agenda)
          {
            agenda.TryAdd(item.Key, item.Value);
          }
          Console.WriteLine("Contatos adicionados com sucesso!!");
        }
      }

      public static void AlterarContato(Dictionary<string, string> agenda)
      {

        Console.WriteLine("Digite o nome do contato que deseja alterar");
        string nome = Console.ReadLine();


        if (agenda.ContainsKey(nome))
        {
          agenda.Remove(nome);
        }
        else
        {
          Console.WriteLine("Contato não existente");
        }
        Console.WriteLine("Digite o nome");
        string novoNome = Console.ReadLine();

        Console.WriteLine("Digite o telefone");
        string novoTelefone = Console.ReadLine();

        agenda.Add(novoNome, novoTelefone);
        foreach (KeyValuePair<string, string> item in agenda)
        {
          agenda.Add(item.Key, item.Value);
        }
        Console.WriteLine("Contato Atualizado!!");


      }

      public static void DeletarUmContato(Dictionary<string, string> agenda)
      {
        Console.WriteLine("Digite o nome do conato que deseja excluir: ");
        string nome = Console.ReadLine();

        if (agenda.ContainsKey(nome))
        {
          agenda.Remove(nome);
          Console.WriteLine("Conato removido");

        }
        else
        {
          Console.WriteLine("Contato Inexistente");
        }

      }
      public static void DeletarVariosContatos(Dictionary<string, string> agenda)
      {
        Console.WriteLine("Quantos contatos deseja excluir");
        int quant = int.Parse(Console.ReadLine());

        for (int i = 0; i < quant; i++)
        {
          Console.WriteLine("Digite o nome:");
          string nome = Console.ReadLine();

          if (agenda.ContainsKey(nome))
          {
            agenda.Remove(nome);
          }
          else
          {
            Console.WriteLine("Este contato não existe");
          }
        }
        Console.WriteLine("Contatos Removidos com sucesso!!");
      }
      public static void ListarUmContato(Dictionary<string, string> agenda)
      {
        Console.WriteLine("Digite o nome do Contato que deseja visualizar: ");
        string nome = Console.ReadLine();

        if (agenda.ContainsKey(nome))

        {
          string telefone = agenda[nome];
          Console.WriteLine($"Nome: {nome} - Telefone: {telefone}");
        }
        else
        {
          Console.WriteLine("Esse contato não existe em sua Lista!");
        }
      }
      public static void ListarTodosContatos(Dictionary<string, string> agenda)
      {
        foreach (KeyValuePair<string, string> item in agenda)
        {
          Console.WriteLine($"|Nome: {item.Key} - Telefone: {item.Value}|");
          Console.WriteLine("|-----------------------------------------|");
        }

      }
    }

  }

}

namespace Agenda
{
  public class Program
  {
    static void Main()
    {
      Dictionary<string, string> agenda = new Dictionary<string, string>();
     agenda.Add("Laua", "Ana");
     agenda.Add("Agenda", " anda");
     agenda.Remove("Agenda");
     agenda.Add("Carpir", "Ana");
     agenda.ContainsValue("Ana");
     agenda.Clear();
     foreach (KeyValuePair<string, string> item in agenda)
     {
          Console.WriteLine($"Nome: {item.Key} - Telefone: {item.Value}");
     }

    }
  }
}

*/
