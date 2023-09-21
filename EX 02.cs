string usuario;
string senha;

do
{
  Console.WriteLine("Digite seu usuário: ");
  usuario = Console.ReadLine();

  Console.WriteLine("Digite sua senha: ");
  senha = Console.ReadLine();

  if (senha == usuario)
  {
    Console.WriteLine("Senha igual ao usuário, digite outra senha!");
  }
  else
  {
    Console.WriteLine($"Bem-vindo, {usuario}!");
  }

} while (senha == usuario);

Console.ReadLine();

