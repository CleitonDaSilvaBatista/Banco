class ContaEmpresarial : ContaBancaria
{
    public decimal LimiteEmprestimo { get; private set; } = 10000m;

    public ContaEmpresarial(int numeroConta, string titular, decimal saldo)
        : base(numeroConta, titular, saldo)
    {
    }

    public override bool Sacar(decimal valor)
    {
        if (valor <= 0 || valor > Saldo + LimiteEmprestimo)
            return false;

        Saldo -= valor;
        return true;
    }

    public bool FazerEmprestimo(decimal valor)
    {
        if (valor <= 0 || valor > LimiteEmprestimo)
            return false;

        Saldo += valor;
        LimiteEmprestimo -= valor;

        return true;
    }
}
