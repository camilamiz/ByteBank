using System;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set;  }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        //static - propriedade pertencente à classe, todos os objetos partilham dessa informação
        //o get é público e o set é privado
        //desta forma, evitamos que alguém faça por exemplo ContaCorrente.TotalDeContasCriadas = 1000;
        public  static int TotalDeContasCriadas { get;  private set; }

        //fazer com que o número da conta seja somente leitura
        //qualquer lugar fora do construtor não consegue atribuir um novo valor ao numero da conta
        public int Numero { get; }
        public int Agencia { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        //constructor
        //agencia e numero são obrigatorios
        public ContaCorrente(int agencia, int numero)
        {
             
            if (agencia <= 0)
            {
                //nameof é um operador que transforma a variavel numero em uma string "numero". Isso ajuda muito se tivermos que mudar
                //o nome da varíavel, por exemplo, não ficando uma stringe stática. Serve para classes, argumentos, variáveis, etc.
                throw new ArgumentException("O argumento agencia deve ser maio que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maio que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            //infere que estamos chamando ContaCorrente.TotalDeContasCriadas, pois estamos dentro da classe
            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor); 
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorTransferenciasNaoPermitidas++;
                //e fica como uma inner exception
                throw new OperacaoFinanceiraException("Operação não realizada", e);
            }
            contaDestino.Depositar(valor);
        }
    }
}
