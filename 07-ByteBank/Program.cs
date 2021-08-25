using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("Catch no método Main");
            }
            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(514, 4578420);
            //    ContaCorrente conta2 = new ContaCorrente(515, 4578420);

            //conta2.Transferir(1000, conta);

            //conta.Depositar(50);
            //Console.WriteLine(conta.Saldo);
            //conta.Sacar(500);
            //conta.Sacar(-500);

            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Argumento com problema: " + e.ParamName);
            //    Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
            //}
            //catch(SaldoInsuficienteException e)
            //{
            //    Console.WriteLine(e.Saldo);
            //    Console.WriteLine(e.ValorSaque);

            //    Console.WriteLine(e.StackTrace);

            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Exceção do tipo SaldoInsuficienteException.");
            //}
            //catch (OperacaoFinanceiraException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //Console.WriteLine("Informações da InnerException(exceção interna): ");
            //Console.WriteLine(e.InnerException.Message);
            //Console.WriteLine(e.InnerException.StackTrace);
            //}

            //com constructor essa maneira de construir uma instância torna-se errada
            //ContaCorrente conta = new ContaCorrente();
            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //ContaCorrente conta = new ContaCorrente(867, 86712540);
            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            //ContaCorrente contaGabriela = new ContaCorrente(867, 86712520);

            //conta.Agencia = 876;
            //conta.Agencia = -10;
            //e se eu esquecer de colocar uma agência? Vamos usar constructors!

            //Console.WriteLine(conta.Agencia);
            //Console.WriteLine(conta.Numero);
            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            //ContaCorrente conta = new ContaCorrente(7480, 874150);
            //Console.WriteLine(ContaCorrente.TaxaOperacao);

            //Exemplo de trativa de erros
            //    try
            //    {
            //        Metodo();
            //    }
            //    catch (DivideByZeroException e)
            //    {
            //        Console.WriteLine("Não é possível divisão por 0!");
            //    }
            //    catch (Exception e)
            //    {

            //        Console.WriteLine(e.Message);
            //        Console.WriteLine(e.StackTrace);
            //    }
            //}

            //public static void Metodo()
            //{
            //    Dividir(10, 2);
            //    Dividir(10, 0);
            //}

            //public static int Dividir(int numero, int divisor)
            //{
            //    try
            //    {
            //        return numero / divisor;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Exceção com numero=" + numero + "e divisor=" + divisor);
            //        throw;
            //    }
            //ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            //faz a mesma função do código comentado abaixo
            //verifica se o leitor é null no bloco do finally
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            //---------//
            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally.");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }
    }
}

