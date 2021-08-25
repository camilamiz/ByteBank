
public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    //quando retorna algo é uma função
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
            return false;

        this.saldo -= valor;
        return true;
    }

    //esta função não retorna nada, é um método
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        //manter no começo do método as condições que retornarão antecipadamente - é uma boa prática
        if (this.saldo < valor)
            return false;

        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}
