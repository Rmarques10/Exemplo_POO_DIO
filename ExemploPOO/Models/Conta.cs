using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void creditar(decimal valor);
        public void ExivirSaldo()
        {
            Console.WriteLine( $"O seu saldo é : {saldo}");
        }
    }
}
