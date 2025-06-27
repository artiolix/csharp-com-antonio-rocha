namespace Aula06;

public class Program
{
    public static void Main()
    {
       Console.WriteLine("===========Verificador De numero Pares e Impáres=========");
       Console.WriteLine("Digite um número:");
      int valorrecebido = Convert.ToInt32(Console.ReadLine());
      if (valorrecebido % 2 == 0)
      {
          Console.WriteLine($"O numero {valorrecebido} é par");
      }
      else
      {
          Console.WriteLine($"O numero {valorrecebido} é impar");
      }
    }
}