using System;

class Program {

  protected string chicoCompleto = "(-_-)";
  protected string chicoLateralDerecha = "_-)";
  protected string chicoLateralIzquierda = "(-_";
  protected string chicoParcialDerecha = "-_-)";
  protected string chicoParcialIzquierda = "(-_-";
  protected string chicoFinalDerecha = "-)";
  protected string chicoFinalIzquierda = "(-";
  
  public static void Main (string[] args) {
    Program program = new Program();
    Console.WriteLine(program.armarTurba(14));
  }

  public string armarTurba(int cantidadChicos)
  {
    string turba = this.chicoCompleto;
    int cantidadChicosParciales = 0; // Contador de chicos parciales
    
    if (cantidadChicos >= 1 && cantidadChicos <= 255)
    {
      for (int i = 1; i < cantidadChicos; i++)
      {
        // Agregar chicoFinalIzquierda en la penúltima posición si se cumplen las condiciones
        if (cantidadChicos > 7 && i == cantidadChicos - 2)
        {
          turba = this.chicoFinalIzquierda + turba;
        }
        // Agregar chicoFinalDerecha en la última posición si se cumplen las condiciones
        else if (cantidadChicos > 7 && i == cantidadChicos - 1)
        {
          turba += this.chicoFinalDerecha;
        }
        // Agregar chicoParcialIzquierda o chicoParcialDerecha en posiciones específicas
        else if ((((i - (6 * cantidadChicosParciales)) - 5) % 5 == 0 || ((i - (6 * cantidadChicosParciales)) - 6) % 6 == 0) && i >= 5)
        {
          if (i % 2 != 0)
          {
            turba = this.chicoParcialIzquierda + turba;
          }
          else 
          {
            turba += this.chicoParcialDerecha;
            cantidadChicosParciales++; // Incrementar el contador de chicos parciales
          }
        }
        // Agregar chicoLateralIzquierda o chicoLateralDerecha en otras posiciones  
        else
        {
          if (i % 2 != 0)
          {
            turba = this.chicoLateralIzquierda + turba;
          }else 
          {
            turba += this.chicoLateralDerecha;
          }
        }
      }
    }
    else
    {
      return "( O_o)"; // Mensaje para casos no válidos
    }

    return turba;
  }
}