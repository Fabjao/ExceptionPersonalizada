using System;
using Exception.MinhaException;

namespace Exception
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Calcular();
        Console.WriteLine("Hello World!");
      }
      catch (DomainException e)
      {
        Console.WriteLine($"Erro {e.Message}");
      }

    }

    private static void Calcular()
    {
      throw new DomainException("Erro dentro do calcular");
    }
  }
}
