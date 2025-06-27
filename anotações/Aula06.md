# Aula 06 – Estrutura Condicional: If-Else

## Conceito
A estrutura `if-else` permite que o programa tome decisões com base em condições.
Dessa forma, usei para ver se o numero que a pessoa escolher verificar si o numero é pare caso não for vai ser impar, mostrando via console ao usuario.

## Sintaxe:
```csharp
// IF = Si for verdadeiro 
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