/*
yojan felipe garcia carvajal
fecha: 10-07-2024
*/
using System;
class Miprimerlector  {
  static void Main() {
    
    // declaracion
    string[] nombres = new string[3];
    
    //asignacion de un vector dinamico
    for (int i = 0; i <= 2; i++) {
      nombres[i] = Console.ReadLine();
    }

    /*imprimir un dato del vector de manera dinamica
      recorer y imprimiendo el vactor*/
     for (int i = 0; i <= 2; i++) {
         Console.WriteLine(nombres[i]);
     }
    
  }
}