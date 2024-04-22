// 3 - Faça um programa que leia um vetor de caracteres de 10 posições e converta as vogais de minusculo para maiusculo

char[] word = new char[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite a {i + 1}ª letra: ");
    word[i] = Console.ReadLine().First();

    switch (word[i])
    {
        case 'a':
            word[i] = 'A';
            break;
        case 'e':
            word[i] = 'E';
            break;
        case 'i':
            word[i] = 'I';
            break;
        case 'o':
            word[i] = 'O';
            break;
        case 'u':
            word[i] = 'U';
            break;
    }
}

Console.WriteLine("\nPalavra convertida: ");
Console.Write(word);