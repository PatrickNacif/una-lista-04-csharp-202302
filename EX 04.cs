double soma = 0;

for (int i = 1; i <= 5; i++)

{
  Console.WriteLine($"Digite o {i}º número: ");
  double numero = double.Parse(Console.ReadLine());
  soma += numero;
}

double media = soma / 5;

Console.WriteLine($"A soma dos números é: {soma}");
Console.WriteLine($"A média dos números é: {media}");

Console.ReadKey();