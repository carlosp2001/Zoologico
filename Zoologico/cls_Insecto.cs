using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class cls_Insecto : cls_Animal
    {
        private Boolean vuela;
        public cls_Insecto(string especie, string nombre, double peso, int jaula, Boolean vuela) : base(especie, nombre, peso, jaula)
        {
            this.Vuela = vuela;
        }

        protected bool Vuela { get => vuela; set => vuela = value; }


        //Polimorfismo
        public override String QueClaseDeAnimalEres()
        {
            String vuelo;
            if (vuela == true)
            {
                vuelo = "Si";
            }
            else
            {
                vuelo = "No";
            }
            
            return "Soy un insecto llamado: " + Nombre + "\n de la especie: " + Especie + "\n Peso en Kg: " + (Peso.ToString()) + "\n Estoy en la jaula: " + (Jaula.ToString() + "\nVuelo: " + vuelo);

        }
    }
}
