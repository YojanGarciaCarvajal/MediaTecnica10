

using System;
class Miprimerlector  {
  static void Main() {
    
    // declaracion y asignacion de un vector
    string[] nombres = {"yojan", "maria", "alverto"};
    
    // imprimir un dato del vector de manera directa 
    Console.WriteLine(nombres[0]);
    
    /*imprimir un dato del vector de manera dinamica
      recorer y imprimiendo el vactor*/
     for (int i = 0; i <= 2; i++) {
         Console.WriteLine(nombres[i]);
     }

  }
}