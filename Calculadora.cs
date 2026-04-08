using System;

public class CalculadoraDesconto 
{
    public static void Main() 
    {
        Console.WriteLine("--- Sistema de Cálculo de Descontos Profissional ---");
        
        Console.Write("Digite o valor do produto: ");
        if (!double.TryParse(Console.ReadLine(), out double valorProduto)) {
            Console.WriteLine("Erro: Valor do produto inválido.");
            return;
        }

        Console.Write("Digite a porcentagem de desconto (ex: 10 para 10%): ");
        if (!double.TryParse(Console.ReadLine(), out double porcentagem)) {
            Console.WriteLine("Erro: Valor de desconto inválido.");
            return;
        }

        double descontoDecimal = porcentagem / 100;
        double valorEconomizado = valorProduto * descontoDecimal;
        double valorFinal = valorProduto - valorEconomizado;

        Console.WriteLine("\n--- Resumo do Desconto ---");
        Console.WriteLine($"Valor Original:    {valorProduto:C2}");
        Console.WriteLine($"Desconto Aplicado: {porcentagem}%");
        Console.WriteLine($"Economia:          {valorEconomizado:C2}");
        Console.WriteLine("--------------------------");
        Console.WriteLine($"VALOR FINAL:       {valorFinal:C2}");
    }
}
