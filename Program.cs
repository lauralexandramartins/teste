using System;
using System.Collections.Generic;

class TabelaFrequencia
{
    static void Main()
    {
        Console.WriteLine("Digite os dados separados por espaço:");
        string entrada = Console.ReadLine();
        string[] partes = entrada.Split(' ');
        List<int> dados = new List<int>();

        foreach (string parte in partes)
        {
            if (int.TryParse(parte, out int numero))
            {
                dados.Add(numero);
            }
        }

        // Ordenar os dados (Bubble Sort básico só pra não depender de LINQ)
        for (int i = 0; i < dados.Count - 1; i++)
        {
            for (int j = 0; j < dados.Count - 1 - i; j++)
            {
                if (dados[j] > dados[j + 1])
                {
                    int temp = dados[j];
                    dados[j] = dados[j + 1];
                    dados[j + 1] = temp;
                }
            }
        }

        // Criar dicionário de frequências
        Dictionary<int, int> frequencias = new Dictionary<int, int>();
        foreach (int numero in dados)
        {
            if (!frequencias.ContainsKey(numero))
                frequencias[numero] = 0;

            frequencias[numero]++;
        }

        int total = dados.Count;
        int acumulada = 0;
        double acumuladaRelativa = 0;

        Console.WriteLine("\nTabela de Frequência:");
        Console.WriteLine("xi\tni\tNi\tfi\tFi\tfi%");

        foreach (var par in frequencias)
        {
            int valor = par.Key;
            int ni = par.Value;
            acumulada += ni;
            double fi = (double)ni / total;
            acumuladaRelativa += fi;
            double fiPorcento = fi * 100;

            Console.WriteLine($"{valor}\t{ni}\t{acumulada}\t{fi:F2}\t{acumuladaRelativa:F2}\t{fiPorcento:F1}%");
        }
    }
}
