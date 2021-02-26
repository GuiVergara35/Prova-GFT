using System;
namespace EX3
{
   public class Investimento
    {
        public double valorInicial { get; set; }
        public double jurosMensais { get; set; }

        public virtual double calcularLucro(int meses){
            return (valorInicial * Math.Pow(1 + jurosMensais, meses) - valorInicial);
            
        }
    }
}