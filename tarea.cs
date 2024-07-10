/******************************************************************************
yojan felipe garcia carvajal
fecha: 10-07-2024
descripcion: un cliente solicita una mini app en consola
             que imprima frases de forma cada que es ejecutado
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      string[] frases = {
   "Nunca es demaciado tarde para ser lo que podrias haber sido",
   "Yo solo se que nada se",
   "La adversidad te hace reconocerte a ti mismo"
      };
     //aleatorio
     Random aleatorio = new Random();
     int posicion = aleatorio.Next(0,2);
     
     //imprimir frase aleatoria
    Console.WriteLine(frases[posicion]);
  }
}
