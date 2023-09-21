string nome;
int idade;
double salario;
char sexo;
char estadoCivil;

do
{
  Console.Write("Digite o nome (maior que 3 caracteres): ");
  nome = Console.ReadLine();

  if (nome.Length <= 3)

  {
    Console.WriteLine("O nome deve ter mais de 3 caracteres. Tente novamente.");
  }

} while (nome.Length <= 3);


do
{
  Console.Write("Digite a idade (entre 0 e 150): ");
} while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0 || idade > 150);


do
{
  Console.Write("Digite o salário (maior que zero): ");
} while (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0);


do
{
  Console.Write("Digite o sexo ('f' ou 'm'): ");
} while (!char.TryParse(Console.ReadLine(), out sexo) || (sexo != 'f' && sexo != 'm'));


do
{
  Console.Write("Digite o estado civil ('s', 'c', 'v' ou 'd'): ");
} while (!char.TryParse(Console.ReadLine(), out estadoCivil) || (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd'));

Console.WriteLine("------------------------------------------------");

Console.WriteLine("\nDados validados:");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Salário: " + salario);
Console.WriteLine("Sexo: " + sexo);
Console.WriteLine("Estado Civil: " + estadoCivil);

Console.WriteLine("-----------------");

Console.ReadLine();