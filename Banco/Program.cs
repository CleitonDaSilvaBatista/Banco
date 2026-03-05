ContaCorrente contaCorrente = new ContaCorrente(1, "Cleiton", 20000);
ContaPoupanca contaPoupanca = new ContaPoupanca(2, "João Pedro", 15000);
ContaEmpresarial contaEmpresarial = new ContaEmpresarial(3, "Caio Henrique", 15000);

MenuPrincipal();

void MenuPrincipal()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine(@"
███████╗░█████╗░██████╗░██████╗░  ██████╗░░█████╗░███╗░░██╗██╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗████╗░██║██║░██╔╝
█████╗░░██║░░██║██████╔╝██║░░██║  ██████╦╝███████║██╔██╗██║█████═╝░
██╔══╝░░██║░░██║██╔══██╗██║░░██║  ██╔══██╗██╔══██║██║╚████║██╔═██╗░
██║░░░░░╚█████╔╝██║░░██║██████╔╝  ██████╦╝██║░░██║██║░╚███║██║░╚██╗
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝");

        Console.WriteLine("\n----------- Menu Principal -----------");
        Console.WriteLine("1 - Conta Corrente");
        Console.WriteLine("2 - Conta Poupança");
        Console.WriteLine("3 - Conta Empresarial");
        Console.WriteLine("4 - Sair");
        Console.Write("\nEscolha: ");

        try
        {
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    MenuContaCorrente();
                    break;

                case 2:
                    MenuContaPoupanca();
                    break;

                case 3:
                    MenuContaEmpresarial();
                    break;

                case 4:
                    Console.WriteLine("Encerrando sistema...");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    presstoback();
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Digite apenas números.");
            presstoback();
        }
    }
}

void MenuContaCorrente()
{
    while (true)
    {
        Console.Clear();
        contaCorrente.ShowInfo();
        Console.WriteLine($"Taxa de saque: R$ {ContaCorrente.TaxaSaque:F2}");

        Console.WriteLine("\n1 - Sacar");
        Console.WriteLine("2 - Depositar");
        Console.WriteLine("3 - Ver Saldo");
        Console.WriteLine("4 - Voltar");
        Console.WriteLine("5 - Sair");
        Console.Write("\nEscolha: ");

        try
        {
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Valor do saque: ");

                    try
                    {
                        decimal saque = decimal.Parse(Console.ReadLine());

                        if (contaCorrente.Sacar(saque))
                            Console.WriteLine("Saque realizado com sucesso!");
                        else
                            Console.WriteLine("Operação não permitida.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um valor numérico válido.");
                    }

                    presstoback();
                    break;

                case 2:
                    Console.Write("Valor do depósito: ");

                    try
                    {
                        decimal deposito = decimal.Parse(Console.ReadLine());

                        if (contaCorrente.Depositar(deposito))
                            Console.WriteLine("Depósito realizado com sucesso!");
                        else
                            Console.WriteLine("Valor inválido.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um valor numérico válido.");
                    }

                    presstoback();
                    break;

                case 3:
                    contaCorrente.ShowInfo();
                    presstoback();
                    break;

                case 4:
                    return;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    presstoback();
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Digite apenas números.");
            presstoback();
        }
    }
}

void MenuContaPoupanca()
{
    while (true)
    {
        Console.Clear();
        contaPoupanca.ShowInfo();

        Console.WriteLine("\n1 - Sacar");
        Console.WriteLine("2 - Depositar");
        Console.WriteLine("3 - Aplicar Rendimento");
        Console.WriteLine("4 - Ver Saldo");
        Console.WriteLine("5 - Voltar");
        Console.WriteLine("6 - Sair");
        Console.Write("\nEscolha: ");

        try
        {
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Valor do saque: ");

                    try
                    {
                        decimal saque = decimal.Parse(Console.ReadLine());

                        if (contaPoupanca.Sacar(saque))
                            Console.WriteLine("Saque realizado!");
                        else
                            Console.WriteLine("Operação não permitida.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um valor numérico válido.");
                    }

                    presstoback();
                    break;

                case 2:
                    Console.Write("Valor do depósito: ");

                    try
                    {
                        decimal deposito = decimal.Parse(Console.ReadLine());

                        if (contaPoupanca.Depositar(deposito))
                            Console.WriteLine("Depósito realizado!");
                        else
                            Console.WriteLine("Valor inválido.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um valor numérico válido.");
                    }

                    presstoback();
                    break;

                case 3:
                    Console.Write("Percentual de rendimento (%): ");

                    try
                    {
                        decimal percentual = decimal.Parse(Console.ReadLine());
                        contaPoupanca.AplicarRendimento(percentual);
                        Console.WriteLine("Rendimento aplicado!");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um valor numérico válido.");
                    }

                    presstoback();
                    break;

                case 4:
                    contaPoupanca.ShowInfo();
                    presstoback();
                    break;

                case 5:
                    return;

                case 6:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    presstoback();
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Digite apenas números.");
            presstoback();
        }
    }
}

void MenuContaEmpresarial()
{
    while (true)
    {
        Console.Clear();
        contaEmpresarial.ShowInfo();
        Console.WriteLine($"Limite disponível: R$ {contaEmpresarial.LimiteEmprestimo:F2}");

        Console.WriteLine("\n1 - Sacar");
        Console.WriteLine("2 - Depositar");
        Console.WriteLine("3 - Fazer Empréstimo");
        Console.WriteLine("4 - Ver Saldo");
        Console.WriteLine("5 - Voltar");
        Console.WriteLine("6 - Sair");
        Console.Write("\nEscolha: ");

        try
        {
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Valor do saque: ");

                    try
                    {
                        decimal saque = decimal.Parse(Console.ReadLine());

                        if (contaEmpresarial.Sacar(saque))
                            Console.WriteLine("Saque realizado!");
                        else
                            Console.WriteLine("Operação não permitida.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um valor numérico válido.");
                    }

                    presstoback();
                    break;

                case 2:
                    Console.Write("Valor do depósito: ");

                    try
                    {
                        decimal deposito = decimal.Parse(Console.ReadLine());

                        if (contaEmpresarial.Depositar(deposito))
                            Console.WriteLine("Depósito realizado!");
                        else
                            Console.WriteLine("Valor inválido.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um valor numérico válido.");
                    }

                    presstoback();
                    break;

                case 3:
                    Console.Write("Valor do empréstimo: ");

                    try
                    {
                        decimal valorEmprestimo = decimal.Parse(Console.ReadLine());

                        if (contaEmpresarial.FazerEmprestimo(valorEmprestimo))
                            Console.WriteLine("Empréstimo aprovado!");
                        else
                            Console.WriteLine("Valor inválido ou acima do limite.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um valor numérico válido.");
                    }

                    presstoback();
                    break;

                case 4:
                    contaEmpresarial.ShowInfo();
                    presstoback();
                    break;

                case 5:
                    return;

                case 6:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    presstoback();
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Digite apenas números.");
            presstoback();
        }
    }
}

void presstoback()
{
    Console.WriteLine("\nPressione qualquer tecla para voltar...");
    Console.ReadKey();
}
