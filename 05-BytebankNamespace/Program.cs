using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BytebankNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "gabriela";
            //gabriela.profissao = "desenvolvedora c#";
            //gabriela.cpf = "123.456.700-88";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = gabriela;
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "123.456.700-88";
            conta.titular.profissao = "desenvolvedora c#";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            //conta.titular.nome = "Gabriela Costa";
            //tanto o conta.titular quanto o gabriela apontam para o mesmo objeto na
            //memória do computador, logo, se mudo o campo em um, muda no outro também

            //se não crio um Cliente antes e tento acessar conta.titular, o valor é null.
            //não aponta para nenhum lugar

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
