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
            return "Soy un ave llamada: " + Nombre + "\n de la especie: " + Especie + "\n Peso en Kg: " + (Peso.ToString()) + "\n Estoy en la jaula: " + (Jaula.ToString() + "\n El color de mi plumaje es: " + ColorPlumaje + "\n Mi altura maxima de vuelo es: " + (AlturaMaximaVuelo.ToString()));

        }
    }
}
