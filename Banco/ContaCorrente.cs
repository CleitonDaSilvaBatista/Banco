class ContaCorrente : ContaBancaria
{
    private const decimal TaxaSaque = 5m;

    public ContaCorrente(int numeroConta, string titular, decimal saldo)
        : base(numeroConta, titular, saldo)
    {
    }

    public override bool Sacar(decimal valor)
    {
        decimal valorTotal = valor + TaxaSaque;

        if (valor <= 0 || valorTotal > Saldo)
            return false;

        Saldo -= valorTotal;
        return true;
    }
}
