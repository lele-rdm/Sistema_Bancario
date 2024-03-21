using Sistema_Bancario;
using System.ComponentModel;

Conta conta;

Console.WriteLine("Digite o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o nome do titular: ");
string titular = Console.ReadLine();
Console.WriteLine("Digite se haverá depósito inicial [s/n]: ");
char resp = char.Parse(Console.ReadLine());

if (resp == 's' || resp == 'S')
{
    Console.WriteLine("Digite o valor do depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine());
    conta = new Conta(numero, titular, depositoInicial);
}
else
{
    conta = new Conta(numero, titular);
}

Console.WriteLine($"\n--- Dados da conta ---\n{conta}");
