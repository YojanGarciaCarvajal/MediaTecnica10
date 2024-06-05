/******************************************************************************
FECHA 6-06-2024
AUTOR yojan felipe garcia carvajal
DESCRIPCION:programa de aprendisaje ciclos o bucles calcular promedio de las nota.
        el docente brinda 4 notas y debe  carcular el promedio
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      //variable
      int nota = 0;
      int promedio = 0;
      
      //bienbenida ala aplicacion
       Console.WriteLine("bienbenido a miniapp promedio de notas ");
      //solicitud de notas
      for (int i =0; i <= 3; i++)
   {
       Console.WriteLine("Docente, porfavor ingrese la nota " + i + ", luego presione enter ");
       nota = nota + Int32.Parse(Console.ReadLine());
   }
     promedio = nota / 4;
     //MOSTRAR PROMEDIO
     Console.WriteLine("promedio es: " +  promedio);
  }
}
















