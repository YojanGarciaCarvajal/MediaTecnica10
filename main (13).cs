/******************************************************************************
Yojan felipe garcia carvajal
fecha 10-07-2024
Descripcion:los personajes de friends estan 
            organizando un evento y nesecitan
            un programa en C# para imprimir los nombres de los asistentes 
            chandler, joey, monica, rachel, ross, phoebe.
*******************************************************************************/
using System;
class HelloWorld {
   static void Main() {
      
    //declaracion y asignacion de un vector dinamico
     string[] asistentes = {
        "Chandler",  
        "Joey",
        "Monica",
        "Rachel",
        "Ross" ,
        "Phoebe"};
        
    /*imprimir un dato del vector de manera dinamica
     recorrer imprimiendo el vector */
     for (int p = 0; p < 6; p++){
        Console.WriteLine(asistentes[p]);
     }
  }
}