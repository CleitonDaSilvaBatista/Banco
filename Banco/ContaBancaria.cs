abstract class ContaBancaria
{
    public string Holder { get; protected set; }
    public decimal Balance { get; protected set; }

    protected ContaBancaria(string holder, decimal balance)
    {
        Holder = holder;
        Balance = balance;
    }

    public void ShowInfo()
    {
        Console.WriteLine("\n------------------- Informações da Conta -------------------");
        Console.WriteLine($"Titular: {Holder}");
        Console.WriteLine($"Saldo atual: R$ {Balance:F2}");
    }

    public virtual bool Sacar(decimal valor)
    {
        if (valor <= 0 || valor > Balance)
            return false;

        Balance -= valor;
        return true;
    }

    public virtual bool Depositar(decimal valor)
    {
        if (valor <= 0)
            return false;

        Balance += valor;
        return true;
    }
}