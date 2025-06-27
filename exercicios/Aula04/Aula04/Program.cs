using System;
namespace Aula04
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("------------- TELA DE CADASTRO -----------");
            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string password = Console.ReadLine();

            Console.Write("Digite seu sexo (M/F): ");
            char sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("------------- CONFIRMAR DADOS ------------");
            Console.WriteLine("Usuário relatado: " + name);
            Console.WriteLine("Senha relatada: " + password);
            Console.WriteLine("Sexo relatado: " + sexo);

            Console.WriteLine("Você deseja se cadastrar? (sim/não)");
            string resposta = Console.ReadLine()?.ToLower();

            if (resposta == "sim")
            {
                Console.WriteLine("Parabéns " + name + ", cadastro realizado com sucesso!");
                Console.WriteLine("----- CADASTRO REALIZADO COM SUCESSO! -----");
            }
            else if (resposta == "não")
            {
                Console.WriteLine("Cadastro cancelado.");
                Console.WriteLine("------------------------------------------");
            }
            else
            {
                Console.WriteLine("Resposta inválida.");
            }
        }
    }
}