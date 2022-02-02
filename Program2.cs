using System;

namespace Proyecto_consola
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine ("Escriba algo");
            string cadena1 = Console.ReadLine();
            Console.Beep();
            Console.WriteLine ("Escriba otra cosa");
            string cadena2 = Console.ReadLine();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            bool Resultado = cadena1.Equals(cadena2); 
            Console.WriteLine (Resultado);
            Console.ReadLine();
            
          
          

    

        }
    
    } 
}
