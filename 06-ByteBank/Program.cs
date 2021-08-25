using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";

            //como saldo virou private em ContaCorrente, não posso fazer a atribuição abaixo
            //conta.saldo = -10;

            //aparece 100 no console e não acontece nada - set
            conta.Saldo = -10;
            conta.Titular = cliente;

            //get
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);
            Console.ReadLine();
        }
    }
}
