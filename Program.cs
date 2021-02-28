using System;

namespace Trabajo_dos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombres = "";
            int edad = 0;
            double estatura = 0.0;
            int si = 0;

            Console.WriteLine("Ingrese su edad:");
            nombres = Console.ReadLine();
            edad = Convert.ToInt32(nombres);

            if (edad > 18)
            {
                Console.WriteLine("Usted No puede Utilizar el parque.");
                Console.WriteLine("¿Es usted un Representante?");
                nombres = Console.ReadLine();
                si = Convert.ToInt32(nombres);

                if (si == 1)
                {
                    Console.WriteLine("Puede acompañar a su hijo");
                    
                }
                else
                {
                    Console.WriteLine("Usted no puede ingresar al patio de juegos");
                   
                }
            }

            else
            {
                Console.WriteLine("Disfrute las instalaciones.");
                Console.WriteLine("Indique su estaturaen metros: ");
                nombres = Console.ReadLine();
                estatura = Convert.ToDouble(nombres);

                if (estatura < 1.5)
                {
                    Console.WriteLine("Usted Puede Usar todas las intalaciones del parque");
                }
                else
                {
                    Console.WriteLine("Usted solo puede usar el trampolín");
                }

            }

            Console.ReadKey(); 
        }
    }
}
