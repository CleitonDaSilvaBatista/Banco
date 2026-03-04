class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(int numeroConta, string titular, decimal saldo)
        : base(numeroConta, titular, saldo)
    {
    }

    public void AplicarRendimento(decimal percentual)
    {
        if (percentual <= 0)
            return;

        Saldo += Saldo * percentual / 100;
    }
}
