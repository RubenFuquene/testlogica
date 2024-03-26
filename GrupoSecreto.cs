using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    List<int> listaIds = new List<int> { 10, 8, 66, 124, 12, 11, 2602, 36 };
    Program program = new Program();
    
    Console.WriteLine (program.detectarEspia(listaIds));
  }

  public int detectarEspia(List<int> listaIds)
  {
    int pares = 0;
    int impares = 0;
    int espia = -1;

    foreach (int id in listaIds)
    {
      if (id % 2 == 0) // Si la identificación es par
      {
        pares++;
        espia = pares == 1 ? id : espia; // Asigna el número par como espía provisionalmente
      }
      else // Si la identificación es impar
      {
        impares++;
        espia = impares == 1 ? id : espia; // Asigna el número impar como espía provisionalmente
      }
    }
    
    if (pares == 1 || impares == 1) // Si hay un único espía
    {
      return espia;
    }

    return -1;
  }
}