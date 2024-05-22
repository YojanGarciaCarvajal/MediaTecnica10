/****************************************************
AUTOR:yojan felipe garcia carvajal 
FECHA:22-05-2024
DESCRIPCION: programa con descripcion para habilitar 
             votacion de personas
****************************************************/
using System;
class HelloWorld {
  static void Main() {
      // variables
      int edad;
      int valorMatricula;
      
       Console.WriteLine(" digite su edad: ");
        edad = Int32.Parse(Console.ReadLine());
     
       Console.WriteLine("digite valor de matricula: ");
       valorMatricula = Int32.Parse(Console.ReadLine());

     // validacion
     if(edad>=18){
         Console.WriteLine("felicidades, usted puede votar");
         Console.WriteLine("usted pagara de matricula: " + (valorMatricula * 0.85));
      }
   }
}
