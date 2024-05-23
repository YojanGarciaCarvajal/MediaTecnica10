/*********************************************************************
AUTOR:yojan felipe garcia carvajal 
FECHA:22-05-2024
DESCRIPCION:  TONY STARK, IRON MAN, QUIERE SABER CUANTO 
              DINERO DEBE TENER PARA COMPRAR X COMILLAS c/u A $300, PERO EN LA TIENDA
              LE DAN DESCUENTOS SEGUN CANTIDAD SI COMPRA:
              1 SIN DESCUENTOS
              2 DESCUENTO DEL 30%
              3 DESCUENTO DEL 50$
**********************************************************************/
using System;

class Program{
    static void Main(){
      int cantidadTornillos;
      int valorTornillos;
      
       Console.WriteLine("cantidad de tornillos que va a llevar");
       cantidadTornillos = Int32.Parse(Console.ReadLine());
       valorTornillos = 300;
       
      if (cantidadTornillos >= 5){
          Console.WriteLine("el valor de los tornillos es: " + (valorTornillos * 0.70));
      }
       if (cantidadTornillos >= 10){
        Console.WriteLine("el valor de los tornillos es: " + (valorTornillos * 0.50));
         Console.WriteLine("el valor de los tornillos es: " + (valorTornillos * 0.50 * cantidadTornillos));
       }
    }
    
}