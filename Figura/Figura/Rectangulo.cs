using System;
using System.Collections.Generic;
using System.Text;

namespace Figura
{
    public class Rectangulo:Figuras
    {
        public float Base { get; set; }
        public float Altura { get; set; }

        public Rectangulo()
        {

        }
        public Rectangulo(float _base, float _altura)
        {
            Base = _base;
            Altura = _altura;
        }


        public override string MostrarArea()
        {
            float Area = (this.Base * this.Altura);
            return "El area del rectangulo es: " + Area;
           
        }

        public override void SolicitarDatos()
        {
            bool IngresoDatosCorrecto = false;
            float Base=0;
            float Altura=0;
            while (!IngresoDatosCorrecto)
            {
                try
                {
                    Console.WriteLine("Digite base");
                    if (!float.TryParse(Console.ReadLine(), out Base)) throw new FormatException("Ingreso una base errada");
                    Console.WriteLine("Digite altura");
                    if (!float.TryParse(Console.ReadLine(), out Altura)) throw new FormatException("Ingreso una altura errada");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                
                IngresoDatosCorrecto = true;
            }
            this.Base = Base;
            this.Altura = Altura;
        }
    }
}
