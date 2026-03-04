<<<<<<< HEAD
﻿ContaCorrente contaCorrente = new ContaCorrente(1, "Cleiton", 20000);
ContaPoupanca contaPoupanca = new ContaPoupanca(2, "João Pedro", 15000);
ContaEmpresarial contaEmpresarial = new ContaEmpresarial(3, "Caio Henrique", 15000);
=======
ContaCorrente contaCorrente = new ContaCorrente("Cleiton", 20000);
ContaPoupanca contaPoupanca = new ContaPoupanca("João Pedro", 15000);
ContaEmpresarial contaEmpresarial = new ContaEmpresarial("Caio Henrique", 15000);
>>>>>>> 29208596ce5fd3a87ee41bef11fe1605237d9282

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
        Console.WriteLine("\n------------------- Menu Principal -------------------");
        Console.WriteLine("1 - Conta Corrente");
        Console.WriteLine("2 - Conta Poupança");
        Console.WriteLine("3 - Conta Empresarial");
        Console.WriteLine("4 - Sair");
        Console.Write("\nEscolha: ");

        if (!int.TryParse(Console.ReadLine(), out int opcao))
            continue;

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
                Console.ReadKey();
                break;
        }
    }
}

void MenuContaCorrente()
{
    while (true)
    {
        Console.Clear();
        contaCorrente.ShowInfo();

        Console.WriteLine("\n1 - Sacar");
        Console.WriteLine("2 - Depositar");
        Console.WriteLine("3 - Ver Saldo");
        Console.WriteLine("4 - Voltar");
        Console.WriteLine("5 - Sair");
        Console.Write("\nEscolha: ");

        if (!int.TryParse(Console.ReadLine(), out int opcao))
            continue;

        switch (opcao)
        {
            case 1:
                Console.Write("Valor do saque: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal saque))
                {
                    if (contaCorrente.Sacar(saque))
                        Console.WriteLine("Saque realizado com sucesso!");
                    else
                        Console.WriteLine("Operação não permitida.");
                }
                break;

            case 2:
                Console.Write("Valor do depósito: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal deposito))
                {
                    if (contaCorrente.Depositar(deposito))
                        Console.WriteLine("Depósito realizado com sucesso!");
                    else
                        Console.WriteLine("Valor inválido.");
                }
                break;

            case 3:
                contaCorrente.ShowInfo();
                break;

            case 4:
                return;

            case 5:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.ReadKey();
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

        if (!int.TryParse(Console.ReadLine(), out int opcao))
            continue;

        switch (opcao)
        {
            case 1:
                Console.Write("Valor do saque: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal saque))
                {
                    if (contaPoupanca.Sacar(saque))
                        Console.WriteLine("Saque realizado!");
                    else
                        Console.WriteLine("Operação não permitida.");
                }
                break;

            case 2:
                Console.Write("Valor do depósito: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal deposito))
                {
                    if (contaPoupanca.Depositar(deposito))
                        Console.WriteLine("Depósito realizado!");
                    else
                        Console.WriteLine("Valor inválido.");
                }
                break;

            case 3:
                Console.Write("Percentual de rendimento (%): ");
                if (decimal.TryParse(Console.ReadLine(), out decimal percentual))
                {
                    contaPoupanca.AplicarRendimento(percentual);
                    Console.WriteLine("Rendimento aplicado!");
                }
                break;

            case 4:
                contaPoupanca.ShowInfo();
                break;

            case 5:
                return;

            case 6:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.ReadKey();
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

        if (!int.TryParse(Console.ReadLine(), out int opcao))
            continue;

        switch (opcao)
        {
            case 1:
                Console.Write("Valor do saque: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal saque))
                {
                    if (contaEmpresarial.Sacar(saque))
                        Console.WriteLine("Saque realizado!");
                    else
                        Console.WriteLine("Operação não permitida.");
                }
                break;

            case 2:
                Console.Write("Valor do depósito: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal deposito))
                {
                    if (contaEmpresarial.Depositar(deposito))
                        Console.WriteLine("Depósito realizado!");
                    else
                        Console.WriteLine("Valor inválido.");
                }
                break;
            case 3:
                Console.Write("Valor do empréstimo: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal valorEmprestimo))
                {
                    if (contaEmpresarial.FazerEmprestimo(valorEmprestimo))
                        Console.WriteLine("Empréstimo aprovado!");
                    else
                        Console.WriteLine("Valor inválido ou acima do limite.");
                }
                break;
            case 4:
                contaCorrente.ShowInfo();
                return;

            case 5:
                return;
            case 6:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.ReadKey();
    }
}

MenuPrincipal();
