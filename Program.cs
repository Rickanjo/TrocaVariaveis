//Exiba as variáveis na ordem que foram digitadas de forma a mostrar os nomes em ordem inversa.

String Nome1;
String Nome2;
String Auxiliar;

Console.WriteLine("----Troca de Variaveis----\n");

Console.Write("Nome 1:");
Nome1 = Console.ReadLine()!;

Console.Write("Nome 2:");
Nome2 = Console.ReadLine()!;

Auxiliar = Nome1;
Nome1 = Nome2;
Nome2 = Auxiliar;

Console.WriteLine($"\nApós as trocas de valores temos: ");

Console.WriteLine($"\nNome1 = {Nome1}");
Console.WriteLine($"Nome2 = {Nome2}");

