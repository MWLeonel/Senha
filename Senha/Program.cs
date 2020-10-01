using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;

            Console.Write("Digite sua senha: ");
            senha = Console.ReadLine();

            if (senha == "1234abcd")
            {
                Console.Write("\n");
                Console.WriteLine("Acesso Permitido!");

                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Acesso negado");

                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
        }
    }
}
