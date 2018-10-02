using System;
using System.Collections;

namespace numerosenterosconpila
{
    public class Program
    {
        public static void Main()
        {
            int numero, suma = 0;
            Stack miPila = new Stack();
            miPila.Push(10);
            miPila.Push(11);
            miPila.Push(12);
            miPila.Push(13);
            for (int m = 0; m <= 3; m++)
            {

                numero = (int)miPila.Pop();
                suma = suma + numero;
            }
            Console.WriteLine(suma);
        
            Console.ReadKey();
        }
        
    }
}
