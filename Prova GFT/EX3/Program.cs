using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Digite o valor total a ser investido em R$:");
          double valorTotal = double.Parse(Console.ReadLine());

          InvestimentoComIR conta1 = new InvestimentoComIR();

          conta1.valorInicial = valorTotal;
          conta1.jurosMensais = 0.000035;

          InvestimentoSemIR conta2 = new InvestimentoSemIR();
          conta2.valorInicial = valorTotal;
          conta2.jurosMensais = 0.00003;

          for(int contador = 1; contador <= 36; contador++){
              Console.WriteLine($"Mês {contador} | Investimento sem IR: {Math.Round(conta2.calcularLucro(contador),2)} | Investimento com IR: {Math.Round(conta1.calcularLucro(contador),2)}");
          }

        }
    }
}
