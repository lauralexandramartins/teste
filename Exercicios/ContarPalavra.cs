/*namespace ContarPalavra
{
  public class Program
  {
    static void Main()
    {
      string texto = "Essa é uma string com algumas palavras.";
        
        string[] palavras = texto.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        
        Console.WriteLine("Quantidade de palavras: " + palavras.Length);
      Palavras p = new Palavras();
      string text = p.texto = "Laura Martins";
      int quant = p.NumeroPalavras(p.texto);
      Console.WriteLine($"O texto {text}, tem {quant} de palavras");
    }
    public class Palavras
    {
    public Palavras(string texto) 
        {
          this.texto = texto;
   
        }
              public string texto {get; set;}
      

      public int NumeroPalavras(string texto)
      {
        int contador = 0;
      bool DentroPalavra = false;

        foreach (char c in texto)
        {
          if (c != ' ' && !DentroPalavra)
          {
            contador++;
            DentroPalavra = true;
          }
            else if (c == ' ')
                    {
                        DentroPalavra = false;
                    }
         
        }
                return contador;
        }
      }
    }
}


*/
