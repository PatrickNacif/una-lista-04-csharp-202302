Console.WriteLine("Digite um número inteiro: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite mais um número inteiro: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Números no intervalo entre " + n1 + " e " + n2 + ":");

int menor_n = Math.Min(n1, n2);
int maior_n = Math.Max(n1, n2);

for (int i = menor_n; i <= maior_n; i++)
{
  Console.WriteLine(i);
}

Console.ReadLine();
