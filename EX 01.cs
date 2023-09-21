using System.IO.Compression;

double nota = 0;
do
{
  Console.WriteLine("Digite uma nota, entre  0 e 10: ");
  nota = Convert.ToDouble(Console.ReadLine());
  if (nota < 1 || nota > 10)
  {
    Console.WriteLine("\nNota inválida!");
  }
} while (nota < 1 || nota > 10);

Console.WriteLine($"\nNota digitada: {nota}");

Console.ReadLine();