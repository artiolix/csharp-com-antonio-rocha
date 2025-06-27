namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite Um numero:");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite Outro numero:");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int sum = numero1 + numero2;
        int subtraction = numero1 - numero2;
        int multiplication = numero1 * numero2;
        int division = numero1 / numero2;
        int module = numero1 / numero2;
        Console.WriteLine("Seu numero de adição é: " + sum + "\n" + "Seu numero de subtração é: " + subtraction + "\n" +
                          "Seu numero de multiplicação é: " + multiplication + "\n" + "Seu numero de divisão é: " +
                          division + "\n" + "O resto da divisão é: " + module);
    }
}