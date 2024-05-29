/******************************************************************************
AUTOR: yojan felipe garcia carvajal
FECHA:30-05-2024
DESCRIPCION:se solicita crear una minicalculadora que realice
-suma +
-resta - 
-multiplicacion *
-divicion /

debe terminar la ejecucion al usuario elegir opcion "salir"
*******************************************************************************/
using System;
  using System.Threading;
  
 class HelloWorld {
  static void Main(string[] args) {
      
      
      Console.WriteLine("bienvenido a la minicalculadora ");
      
     //pantalla bienvenida (imagen asccii)
     Console.WriteLine("|  \\/  | __ _| |_ ___ _ __ ___   /_/_| |_(_) ___ __ _ ___       ");
     Console.WriteLine("| |\\/| |/ _` | __/ _ \\ '_ ` _ \\ / _` | __| |/ __/ _` / __|      ");  
     Console.WriteLine("| |  | | (_| | ||  __/ | | | | | (_| | |_| | (_| (_| \\__ \\      ");
     Console.WriteLine("|_|  |_|\\__,_|\\__\\___|_| |_| |_|\\__,_|\\__|_|\\___\\__,_|___/      ");
     
      Thread.Sleep(3000);
     Console.Clear();
     
     
     Console.WriteLine("|  \\/  | __ _| |_ ___ _ __ ___   /_/_| |_(_) ___ __ _ ___       ");
     Console.WriteLine("| |\\/| |/ _` | __/ _ \\ '_ ` _ \\ / _` | __| |/ __/ _` / __|      ");  
     Console.WriteLine("| |  | | (_| | ||  __/ | | | | | (_| | |_| | (_| (_| \\__ \\      ");
     Console.WriteLine("|_|  |_|\\__,_|\\__\\___|_| |_| |_|\\__,_|\\__|_|\\___\\__,_|___/      ");
     
        Thread.Sleep (1000);
     Console.Clear();
     
     
    
       
       // mostar menu de opciones
       Console.WriteLine("Menú de opciones ");
       Console.WriteLine("Seleccionar la opción deseada: ");
       Console.WriteLine("1. Suma");
       Console.WriteLine("2. Resta");
       Console.WriteLine("3. Multiplicación");
       Console.WriteLine("4. Divisón");
       Console.WriteLine("5. Salir");
       //capturar valor del usuario
        Console.Write("Digitar opcion deseada: ");
       int opcion = Int32.Parse(Console.ReadLine());
       
       if(opcion == 5){
           goto Salir;
       }
       
       //capturar los numeros elejidos por el usuario
       Console.WriteLine("\ndijita el numero 1 ");
       int numero1 =Int32.Parse(Console.ReadLine());
       Console.WriteLine("\ndijita el numero 2 ");
       int numero2 =Int32.Parse(Console.ReadLine());
       
       //validar la opcion elegida
       if(opcion == 1){
         Console.WriteLine("la suma es: " + (numero1+numero2));
       }
       
       if(opcion == 2){
            Console.WriteLine("la resta es: "+(numero1+numero2));
       }
       
       if(opcion == 3){
            Console.WriteLine("la Multiplicación es: "+(numero1+numero2));
       }
       
        if(opcion == 4){
            if(numero1 != 0 || numero2 != 0){
                Console.WriteLine("la divicion es: "+(numero1+numero2));
            }
            else{
               Console.WriteLine("no se puede dividir por cero.");
            }
       }
       
           
        Salir:
           Console.WriteLine("saliendo del programa...");
       }
       
    }   
 
     
       