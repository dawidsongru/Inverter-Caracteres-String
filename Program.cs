// Inverter Caracteres de uma String
// Este aplicativo em C# permite inverter os caracteres de uma string fornecida pelo usuário.
// O usuário informa a string e o programa utiliza um algoritmo simples para inverter os caracteres.
// Versão: 1.0
// Autor: Dawidson Pereira Gaião
// Data: 12/03/2024



using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe uma string para inverter os caracteres: ");
        string input = Console.ReadLine();

        string reversedString = InverterString(input);

        Console.WriteLine($"String invertida: {reversedString}");
    }

    static string InverterString(string input)
    {
        char[] charArray = input.ToCharArray();

        int start = 0;
        int end = charArray.Length - 1;

        while (start < end)
        {
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;

            start++;
            end--;
        }

        return new string(charArray);
    }
}
