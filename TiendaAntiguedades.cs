using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    Program program = new Program();
    Console.WriteLine (program.valorPosibleMasAlto(120));
  }

  public int valorPosibleMasAlto(int valorActual)
  {
    // Convierte el número en un arreglo de dígitos
    int[] digitos = valorActual.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

    // Ordena los dígitos en orden descendente
    Array.Sort(digitos);
    Array.Reverse(digitos);
    
    // Convierte el arreglo de dígitos en un número entero
    int nuevoValor = int.Parse(string.Join("", digitos));
    
    return nuevoValor;
  }
}