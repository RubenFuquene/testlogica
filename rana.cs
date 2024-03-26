using System;

class Program {
  
  static void Main(string[] args) {
    int rocas = 3; // Cambia este valor para el número de rocas en el río
    int formas = ContarFormasDeCruzarRio(rocas);
    Console.WriteLine($"La rana puede cruzar el río con {rocas} rocas de {formas} formas diferentes:");
    MostrarFormasDeCruce(rocas);
  }

  static int ContarFormasDeCruzarRio(int rocas)
  {
    if (rocas <= 0)
    {
      return 0;
    }

    int[] formas = new int[rocas + 1];
    formas[0] = 1;

    for (int i = 1; i <= rocas; i++)
    {
      formas[i] = formas[i - 1];
      if (i >= 2)
      {
        formas[i] += formas[i - 2];
      }
      if (i >= 3)
      {
        formas[i] += formas[i - 3];
      }
    }

    return formas[rocas];
  }

  static void MostrarFormasDeCruce(int rocas)
  {
    MostrarFormas(rocas, "", 0);
  }

  static void MostrarFormas(int rocas, string formaActual, int rocasActuales)
  {
    if (rocasActuales == rocas)
    {
      Console.WriteLine(formaActual);
      return;
    }

    for (int i = 1; i <= 3; i++)
    {
      if (rocasActuales + i <= rocas)
      {
          if (formaActual != "")
        {
          MostrarFormas(rocas, formaActual + " " + i, rocasActuales + i);
        } else
        {
          MostrarFormas(rocas, i.ToString(), rocasActuales + i);
        }
      }
    }
  }
}
