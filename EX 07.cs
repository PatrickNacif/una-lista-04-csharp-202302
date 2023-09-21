int Par = 0;
int Impar = 0;

for (int i = 1; i <= 10; i++)
{
  Console.Write("Digite o " + i + "º número inteiro: ");
  int numero = int.Parse(Console.ReadLine());

  if (numero % 2 == 0)
  {
    // O número é par
    Par++;
  }
  else
  {
    // O número é ímpar
    Impar++;
  }
}

Console.WriteLine("---------------------------------");

Console.WriteLine("Quantidade de números pares: " + Par);

Console.WriteLine("---------------------------------");
Console.WriteLine("Quantidade de números ímpares: " + Impar);

Console.ReadLine();