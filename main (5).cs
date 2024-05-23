/*********************************************************************
AUTOR:yojan felipe garcia carvajal 
FECHA:22-05-2024
DESCRIPCION: un docente requiere de un sistema de notas donde recibe 
4 calificaciones generando un promedio y luego determinado si gana o pierde
si su promedio es menor a 3 pierde
si es mayor gana 
si tiene un promedio mayor a 4.5 emitir mansaje:
"felicidades, te has ganado la beca"
**********************************************************************/
using System;

class Program{
    static void Main(){
    
    double calificacion1;
    double calificacion2;
    double  calificacion3;
    double calificacion4;
    
        Console.WriteLine("ingrese las calificacion 1 ");
        calificacion1 = Double.Parse(Console.ReadLine());
       
        Console.WriteLine("ingrese las calificacion 2 ");
        calificacion2 = Double.Parse(Console.ReadLine());
       
        Console.WriteLine("ingrese las calificacion 3 ");
        calificacion3 = Double.Parse(Console.ReadLine());
       
        Console.WriteLine("ingrese las calificacion 4 ");
        calificacion4 = Double.Parse(Console.ReadLine());
     
           if(calificacion1>=3.0){
               Console.WriteLine("felicidades has aprobado con: " + (calificacion1 + calificacion2 +calificacion3
               + calificacion4) / 4 );
           }
         if(calificacion1<=2.9){
              Console.WriteLine("lo siento has perdido la beca con: " + (calificacion1 + calificacion2 +calificacion3
               + calificacion4) / 4 );
         }
        
         if(calificacion1>=4.5){
               Console.WriteLine("felicidades has ganado la beca con: " + (calificacion1 + calificacion2 +calificacion3
               + calificacion4) / 4 );
           }
      
        
         if(calificacion1<=4.5){
               Console.WriteLine("lo siento has perdido la beca con: " + (calificacion1 + calificacion2 +calificacion3
               + calificacion4) / 4 );
           }
    }
}