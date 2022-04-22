using System;

namespace Figura
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool Continuar = true;
            Figuras figura;
            int opcion = 0;
            while (Continuar)
            {
                try
                {
                    Console.WriteLine("Calculo areas figuras geometricas");
                    Console.WriteLine("1. Circulo");
                    Console.WriteLine("2. Rectangulo");
                    Console.WriteLine("3. Salir");
                    Console.WriteLine("Digite opción");
                    if (!int.TryParse(Console.ReadLine(), out opcion)) throw new FormatException();
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            figura = new Circulo();
                            figura.SolicitarDatos();
                            Console.WriteLine( figura.MostrarArea());
                            break;
                        case 2:
                            figura = new Rectangulo();
                            figura.SolicitarDatos();
                            Console.WriteLine(figura.MostrarArea());
                            break;
                        case 3: break;
                            Continuar = false;
                        default:
                            Console.WriteLine("Opcion Invalida!!");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ahh ingresado un dato invalido");
                    Console.ReadLine();
                    
                }
                Console.ReadLine();
                Console.Clear();
               
               

            }

        }
    }
}
