/*
    Deseja-se farzer um programa que leia um conjunto de N números inteiros (N de 1 a 10)  e depois imprima esses números de forma organizada conforme exemplo. 
    Em seguida, informe qual foi o primeiro valor informado.
*/

using Generics;

ServicoDeImpressao<string> servicoDeImpressao = new();

Console.Write("Quantos números vai digitar? ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 0; i < n; i++) 
{
    string x = Console.ReadLine()!;
    servicoDeImpressao.AdiconarValor(x);
}

servicoDeImpressao.Imprimir();
Console.WriteLine("Primeiro elemento: " + servicoDeImpressao.PrimeiroElemento());

Console.ReadKey();