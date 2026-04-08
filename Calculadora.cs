using System;

public class CalculadoraDesconto {

    public static void Main() {

        double valorProduto = 100.00;
        double desconto = 0.10; // 10% de desconto
        double valorFinal = valorProduto - (valorProduto * desconto);
        Console.WriteLine("O valor com desconto basico é: " + valorFinal);

    }

}
