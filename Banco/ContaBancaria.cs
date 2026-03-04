abstract class ContaBancaria
{
    public int NumeroConta { get; protected set; }
    public string Titular { get; protected set; }
    public decimal Saldo { get; protected set; }

    protected ContaBancaria(int numeroConta, string titular, decimal saldo)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = saldo;
    }

    public void ShowInfo()
    {
        Console.WriteLine("\n------------------- Informações da Conta -------------------");
        Console.WriteLine($"Número da Conta: {NumeroConta}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
    }

    public virtual bool Sacar(decimal valor)
    {
        if (valor <= 0 || valor > Saldo)
            return false;

        Saldo -= valor;
        return true;
    }

    public virtual bool Depositar(decimal valor)
    {
        if (valor <= 0)
            return false;

        Saldo += valor;
        return true;
    }
}
