/******************************************************************************

AUTOR:yojan felipe garcia carvajal
FECHA:30-05-2024
DESCRIPCION: 
   preferencias segun el generos
  -si es un hombre menor de edad sus preferencias son:
   figuras de accion, criaturas, serie TV
  -si es hombre mayor de edad sus preferencias son:
   cine,pincnic y filantropia
  -si es mujer menor de edad sus preferencias son:
   muñecas, maquillaje,series TV
  -si es mujer mayor de edad sus preferencias son:
   maquilaje, series TV , cine , filantropia.
*******************************************************************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al programa de preferencias.");
        Console.Write("Por favor ingrese su género (hombre/mujer): ");
        string genero = Console.ReadLine();

        Console.Write("Por favor ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSus preferencias son:");

        if (genero == "hombre")
        {
            if (edad < 18)
            {
                Console.WriteLine("- Figuras de acción Caricaturas Series TV");
               
            }
            else
            {
                Console.WriteLine("- Cine picnic Filantropía");
             
            }
        }
        else if (genero == "mujer")
        {
            if (edad < 18)
            {
                Console.WriteLine("- Muñecas Maquillaje Series TV");
               
            }
            else
            {
                Console.WriteLine("- Maquillaje Series TV Cine Filantropía");
               
            }
        }
        else
        {
            Console.WriteLine("Género no reconocido.");
        }
    }
}
