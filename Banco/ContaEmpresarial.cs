class ContaEmpresarial : ContaBancaria
{
    public decimal LimiteEmprestimo { get; private set; } = 10000m;

    public ContaEmpresarial(string holder, decimal balance)
        : base(holder, balance)
    {
    }

    public override bool Sacar(decimal valor)
    {
        if (valor <= 0 || valor > Balance + LimiteEmprestimo)
            return false;

        Balance -= valor;
        return true;
    }
}