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
    conta = new Conta()
}