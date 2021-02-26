using System;
using System.Text;
using System.Linq;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            InvestimentoComIR investComIR = new InvestimentoComIR();

            investComIR.valorInicial = 5000;
            investComIR.jurosMensais = 0.012;

            Console.WriteLine( $" Para o investimento inicial de {investComIR.valorInicial} com juros mensais de {investComIR.jurosMensais} e desconto no IR, o lucro final será igual a R$ {Math.Round(investComIR.calcularLucro(17),2)}");

            InvestimentoSemIR investSemIR = new InvestimentoSemIR();

            investSemIR.valorInicial = 3000;
            investSemIR.jurosMensais = 0.0007;

            Console.WriteLine($"Para o investimento inicial de {investSemIR.valorInicial} com juros mensais de {investSemIR.jurosMensais} sem desconto no IR, o lucro final será igual a R$ {Math.Round(investSemIR.calcularLucro(10),2)}");
           
        }
    }
}
