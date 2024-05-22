/****************************************************
AUTOR:yojan felipe garcia carvajal 
FECHA:22-05-2024
DESCRIPCION:  TONY STARK, IRON MAN, QUIERE SABER CUANTO 
              DINERO DEBE TENER PARA COMPRAR X COMILLAS c/u A $300, PERO EN LA TIENDA
              LE DAN DESCUENTOS SEGUN CANTIDAD SI COMPRA:
              1 SIN DESCUENTOS
              2 DESCUENTO DEL 30%
              3 DESCUENTO DEL 50$
****************************************************/
using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine(CalcularCostoTornillos(3));  
        Console.WriteLine(CalcularCostoTornillos(6));  
        Console.WriteLine(CalcularCostoTornillos(12)); 
    }

    static double CalcularCostoTornillos(int cantidadTornillos)
    {
        const double Presio_Unitario = 300;
        double costoTotal;

        if (cantidadTornillos < 5)
        {
            costoTotal = cantidadTornillos * Presio_Unitario;
        }
        else if (cantidadTornillos >= 5 && cantidadTornillos < 10)
        {
            costoTotal = cantidadTornillos * Presio_Unitario * 0.7;
        }
        else 
        {
            costoTotal = cantidadTornillos * Presio_Unitario * 0.5;
        }

        return costoTotal;
    }
}