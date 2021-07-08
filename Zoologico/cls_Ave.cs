using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class cls_Ave : cls_Animal //Herencia
    {
        private String colorPlumaje;
        private double alturaMaximaVuelo;

        protected string ColorPlumaje { get => colorPlumaje; set => colorPlumaje = value; }
        protected double AlturaMaximaVuelo { get => alturaMaximaVuelo; set => alturaMaximaVuelo = value; }

        
        public cls_Ave(string especie, string nombre, double peso, int jaula, double alturaMaximaVuelo, string colorPlumaje) : base(especie, nombre, peso, jaula)
        {
            this.ColorPlumaje = colorPlumaje;
            this.AlturaMaximaVuelo = alturaMaximaVuelo;
        }
        

        public override String QueClaseDeAnimalEres()
        {

            base.QueClaseDeAnimalEres();
            return "Soy un ave llamada: " + Nombre + "\nde la especie: " + Especie + "\nPeso en Kg: " + (Peso.ToString()) + "\nEstoy en la jaula: " + (Jaula.ToString() + "\nEl color de mi plumaje es: " + ColorPlumaje + "\nMi altura maxima de vuelo es: " + (AlturaMaximaVuelo.ToString()));

        }
    }
}
