/******************************************************************************
AUTOR:yojan felipe garcia carvajal
FECHA:7-06-2024
DESCRIPCION:  Toy Story
     Los juguetes de Andy están 
     jugando a las escondidas. Pide al 
     usuario las ubicaciones donde buscar 
     y usa estructuras "si" para determinar 
     si los juguetes están en la ubicación 
     correcta o no. Reportar la cantidad 
     total de juguetes que fueron encontrados 
     al finalizar 4 rondas.
*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      //variables//
      int ubicacionJuguetes;
      int jugueteEncontrado=0;
             while (jugueteEncontrado < 4) 
             {
              // preguntar ubicaciones al usuario
              Console.WriteLine ("seleccione la ubicacion deseada");
              Console.WriteLine ("1. sala");
             Console.WriteLine ("2. cocina");
             Console.WriteLine ("3. mesa");
             Console.WriteLine ("4. sillon");
             Console.WriteLine("5. habitacion");
             Console.WriteLine("6.cochera");
             ubicacionJuguetes = Int32.Parse (Console.ReadLine());
             // validar ubicaciones con estructura IF
                  if (ubicacionJuguetes == 1){
                 Console.WriteLine ("Felicidades, encontraste a Rex ");
                 jugueteEncontrado=jugueteEncontrado + 1;
                  }
                 if (ubicacionJuguetes == 2){
                 Console.WriteLine ("Felicidades, encontraste a Buzz Lightyear ");
                 jugueteEncontrado=jugueteEncontrado + 1;
                 }
                 
                 if (ubicacionJuguetes== 3){
                 Console.WriteLine("Felicidades, encontraste a Slinky");
                 jugueteEncontrado=jugueteEncontrado + 1;
                 }
                 
                  if (ubicacionJuguetes== 4){
                 Console.WriteLine("Felicidades, encontraste a Sheriff Woody");
                 jugueteEncontrado=jugueteEncontrado + 1;
                 }
                 if (ubicacionJuguetes== 5){
                 Console.WriteLine("no hay juguetes");
                 }
                 if (ubicacionJuguetes== 6){
                 Console.WriteLine("no hay juguetes");
                 }
                  //mostrar juguetes encontrados //
           Console.WriteLine("el total de juguetes encontrados es " +(jugueteEncontrado));   
           // fin
             }
        }
    }
