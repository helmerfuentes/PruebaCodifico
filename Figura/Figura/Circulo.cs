using System;
using System.Collections.Generic;
using System.Text;

namespace Figura
{
    public class Circulo:Figuras
    {
        public double Radio { get; set; }
        public Circulo()
        {
        }

        public Circulo(double _radio)
        {
            this.Radio = _radio;
        }
        public override string MostrarArea()
        {
            double Area = Math.PI *(Math.Exp(this.Radio));
            return "El area del circulo es: "+Area;
        }

        public override void SolicitarDatos()
        {
            bool IngresoDatosCorrecto=false;
            Console.WriteLine("Digite radio del circulo");
            while (!IngresoDatosCorrecto)
            {
                try
                {
                    this.Radio = double.Parse(Console.ReadLine());
                    IngresoDatosCorrecto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Radio del circulo invalido");
                }

            }
            
        }
    }
}
