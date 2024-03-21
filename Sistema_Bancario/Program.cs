using Sistema_Bancario;
using System.ComponentModel;
using System.Globalization;

Conta conta;

Console.Write("Digite o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Digite o nome do titular: ");
string titular = Console.ReadLine();
Console.Write("Digite se haverá depósito inicial [s/n]: ");
char resp = char.Parse(Console.ReadLine());

if (resp == 's' || resp == 'S')
{
    Console.WriteLine("Digite o valor do depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new Conta(numero, titular, depositoInicial);
}
else
{
    conta = new Conta(numero, titular);
}

Console.WriteLine($"\n--- Dados da conta ---\n{conta}");
Console.Write("Digite um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.CalcularDeposito(quantia);

Console.WriteLine($"\n--- Dados da conta atualizados ---\n{conta}");
Console.Write("Digite um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.CalcularSaque(quantia);
Console.WriteLine($"\n--- Dados da conta atualizados ---\n{conta}");