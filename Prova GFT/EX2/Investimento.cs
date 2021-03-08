using System;
namespace EX2
{
    public class Investimento
    {
        internal double valorInicial;
        internal double jurosMensais;

        public Investimento(double valorInicial, double jurosMensais){
            this.valorInicial = valorInicial;
            this.jurosMensais = jurosMensais;
        }

        public double getvalorInicial(){
            return valorInicial;
        }

        public double getJurosMensais(){
            return jurosMensais;
        }

        public virtual double calcularLucro(int meses){
            return (valorInicial * Math.Pow(1 + jurosMensais, meses) - valorInicial);
        }
    }
}