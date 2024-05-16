/******************************************************************************
autores: cesar esteban 
        yojan garcia
fecha:16-05-2024
descripcion: Los avengers necesitamn un programa en c# para calcular la fuerza
necesaria para levantar un objeto en el planeta marte . completa el espacio en blanco
para solicitar al usuario la masa del objeto a levantar:

formula. FUERZA = MASA * GRAVEDAD

*******************************************************************************/
using System;
class program
{
  static void Main() 
  {
   Console.WriteLine("Ingrese la masa del objeto alevantar en kilogramos:");
double masaObjeto = double.Parse(Console.ReadLine());
double gravedad = 3.71;
double  fuerza =  masaObjeto * gravedad;

Console.WriteLine("La fuerza necesaria para levantar el objeto es de aproximadamente" + fuerza + "Newtons");

  }
}