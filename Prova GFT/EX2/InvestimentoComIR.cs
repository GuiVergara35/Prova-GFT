using System;
namespace EX2
{
    public class InvestimentoComIR : Investimento
    {
        public InvestimentoComIR(double valorInicial, double jurosMensais) : base(valorInicial, jurosMensais)
        {
            
        }

        public override double calcularLucro(int meses){
            double desconto = 0;
            if(meses < 6){
                desconto = 22.5;
            } else if (meses < 12){
                desconto = 20;
            } else if (meses < 24){
                desconto = 17.5;
            } else {
                desconto = 15;
            }
            double lucroFinal= (valorInicial * Math.Pow(1 + jurosMensais, meses) - valorInicial);

            return lucroFinal - (lucroFinal * (desconto/100));
        }
        
            
        }
        
    }
