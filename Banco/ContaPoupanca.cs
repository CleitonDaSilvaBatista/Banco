class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(string holder, decimal balance)
        : base(holder, balance)
    {
    }

    public void AplicarRendimento(decimal percentual)
    {
        if (percentual <= 0)
            return;

        Balance += Balance * percentual / 100;
    }
}