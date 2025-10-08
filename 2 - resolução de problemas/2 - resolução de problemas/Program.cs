// See https://aka.ms/new-console-template for more information
using System;

public class NameCheck
{
    // Verifica se o nome alvo está no array usando Array.IndexOf com comparação case-insensitive
    public static int CheckInArray(string[] names, string target)
    {
        for (int i = 0; i < names.Length; i++)
        {
            if (string.Equals(names[i], target, StringComparison.OrdinalIgnoreCase))
            {
                return Array.IndexOf(names, names[i]);
            }
        }
        return -1;
    }

    // Exemplo de uso
    public static void Main(string[] args)
    {
        // Lista predefinida de nomes, incluindo "Carlos"
        string[] names = { "Ana", "Bruno", "Carlos", "Daniela", "Eduardo" };

        // Exibe a lista de nomes disponíveis
        Console.WriteLine("Lista de nomes disponíveis:");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{i}: {names[i]}");
        }

        // Solicita que o usuário digite o nome a ser procurado
        Console.Write("\nDigite o nome que deseja encontrar: ");
        string target = Console.ReadLine();

        // Realiza a verificação
        int result = CheckInArray(names, target);

        // Exibe o resultado
        Console.WriteLine(result != -1
            ? $"O nome '{target}' foi encontrado no índice {result}"
            : $"O nome '{target}' não foi encontrado na lista");
    }
}