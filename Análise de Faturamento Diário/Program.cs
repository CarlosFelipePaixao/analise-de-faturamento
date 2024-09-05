using System;

class Program
{
    static void Main()
    {
        // Vetor de faturamento diário de um mês
        double[] faturamento = { 2000, 2400, 1500, 1800, 2100, 0, 0, 2700, 2200, 1900, 2500, 2800, 0, 0, 3000, 3200, 3100, 2000, 2200, 0, 0, 3500, 3300, 3700, 4000, 4200, 0, 0, 1800, 1900 };

        double menor = faturamento[0], maior = faturamento[0];
        double totalFaturamento = 0;
        int diasComFaturamento = 0, diasAcimaMedia = 0;

        // Calcula menor, maior e soma dos faturamentos
        for (int i = 0; i < faturamento.Length; i++)
        {
            if (faturamento[i] > 0)
            {
                if (faturamento[i] < menor) menor = faturamento[i];
                if (faturamento[i] > maior) maior = faturamento[i];
                totalFaturamento += faturamento[i];
                diasComFaturamento++;
            }
        }

        // Calcula a média mensal
        double mediaMensal = totalFaturamento / diasComFaturamento;

        // Conta dias com faturamento acima da média
        foreach (var valor in faturamento)
        {
            if (valor > mediaMensal) diasAcimaMedia++;
        }

        // Exibe os resultados
        Console.WriteLine($"Menor faturamento: R$ {menor:N2}");
        Console.WriteLine($"Maior faturamento: R$ {maior:N2}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");

        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}
