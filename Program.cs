string frase;
string repeticao;

Console.WriteLine("Digite uma frase para o Cebolinha repetir:");
frase = Console.ReadLine()!;
Console.WriteLine("Cebolinha:");
repeticao = frase
            .Replace("r", "l")
            .Replace("R", "L");
Console.WriteLine($"{repeticao}");
