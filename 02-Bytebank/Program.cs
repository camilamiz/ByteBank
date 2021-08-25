using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";

            Console.WriteLine(conta.titular);

            //vem zerado quando não atribuímos nada, tem um valor padrão atribuído pela máquina virtual
            //saldo está com 100 como default
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.agencia);
            
            Console.ReadLine();
        }
    }
}
