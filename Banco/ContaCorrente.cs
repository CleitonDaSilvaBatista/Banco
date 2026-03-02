class ContaCorrente : ContaBancaria
{
    private const decimal TaxaSaque = 5m;

    public ContaCorrente(string holder, decimal balance)
        : base(holder, balance)
    {
    }

    public override bool Sacar(decimal valor)
    {
        decimal valorTotal = valor + TaxaSaque;

        if (valor <= 0 || valorTotal > Balance)
            return false;

        Balance -= valorTotal;
        return true;
    }
}