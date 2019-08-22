using System;

namespace CiclosFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Imprime los numeros de X hasta Y");
            Console.WriteLine("De donde arrancamos el ciclo: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("En donde termina el ciclo: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto: ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                for (int i = x; i > y; i -= z)
                {
                    Console.WriteLine("i =" + i);
                }
            }
            else if (x < y)
            {
                for (int i=x;i<=y;i+=z)
                {
                    Console.WriteLine("i =" + i);
                }
                
            }
            
            
        }
    }
}
