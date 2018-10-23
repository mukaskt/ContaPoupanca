using System;

namespace Poupanca
{
    class ContaPoupanca
    {
        private decimal saldoPoupanca;
        private static double taxaDeJurosAnual;

        private const int MESES = 12;

        /// Cria uma nova conta poupança
        public ContaPoupanca()
        {
            saldoPoupanca = 0.0M;
            taxaDeJurosAnual = 0.0;
        }

        /// Cria uma nova Conta Poupança
        public ContaPoupanca(decimal saldoPoupanca)
        {
            this.saldoPoupanca = saldoPoupanca;
            taxaDeJurosAnual = 0.0;
        }

        /// Pega ou configura o saldo atual da poupança
        public decimal Saldo
        {
            get { return saldoPoupanca; }
            set { saldoPoupanca = value; }
        }
    
        /// Pega ou configura a taxa de juros atual da poupança
        public static double TaxaJuros
        {
            get { return taxaDeJurosAnual; }
            set { taxaDeJurosAnual = value; }
        }

        /// Calcula o juros mensais da poupança acrescidos do saldo atual
        public decimal CalcularJurosMensal()
        {
            decimal jurosMensal = (saldoPoupanca * (decimal)taxaDeJurosAnual) / MESES;
            return jurosMensal + saldoPoupanca;
        }

        /// Altera a taxa de juros da Conta Poupança
        public static void AlterarTaxaDeJuros(double taxaDeJuros)
        {
            taxaDeJurosAnual = taxaDeJuros;
        }

    } 

} 