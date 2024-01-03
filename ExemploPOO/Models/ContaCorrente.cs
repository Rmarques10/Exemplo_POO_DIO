using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal saldo;
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if(saldo >= valor) { 
            saldo -= valor;
                Console.WriteLine("Saque efetuado com sucesso.");
            }
            else
            {
                Console.WriteLine("O valor desejado é maior que seu saldo dísponivel");
            }
        }
        public void ExibirSaldo() 
        {
            Console.WriteLine($"Seu saldo dísponivel é: {saldo}");
        }
    }
}
