using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            bool resultadoSaque2 = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque2);

            contaDoBruno.Depositar(550);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);
            
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
