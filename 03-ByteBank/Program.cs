using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //lugar x da memória do computador
            ContaCorrente contadaGabriela = new ContaCorrente();
            contadaGabriela.titular = "Gabriela";
            contadaGabriela.agencia = 863;
            contadaGabriela.numero = 863452;

            //lugar y da memória do computador
            ContaCorrente contadaGabrielaCosta = new ContaCorrente();
            contadaGabrielaCosta.titular = "Gabriela";
            contadaGabrielaCosta.agencia = 863;
            contadaGabrielaCosta.numero = 863452;

            //variáveis de referência - estamos referenciando o endereço do objeto na memória do computador
            //logo, é false pois os endereços são diferentes
            Console.WriteLine("Igualdade de tipo de referência: "+ (contadaGabriela == contadaGabrielaCosta)); //false

            int idade = 27;
            int idadeMaisUmaVez = 27;

            //variáveis de valor
            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez)); //true

            //se fizermos
            contadaGabriela = contadaGabrielaCosta;
            Console.WriteLine(contadaGabriela == contadaGabrielaCosta); //true

            contadaGabriela.saldo = 300;
            //mas como mudamos a referência da contadaGabrielaCosta para a contadaGabriela, ambas apontarão 300
            Console.WriteLine(contadaGabriela.saldo); //300
            Console.WriteLine(contadaGabrielaCosta.saldo); //300

            Console.ReadLine();
        }
    }
}
