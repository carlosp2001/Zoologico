using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Cls_mamifero : cls_Animal //Herencia
    {
        public Cls_mamifero(string especie, string nombre, double peso, int jaula) : base(especie, nombre, peso, jaula)
        {
        }


        //Polimorfismo
        public override String QueClaseDeAnimalEres()
        {
            
            base.QueClaseDeAnimalEres();
            return "Soy un mamifero llamado: " + Nombre + "\n de la especie: "+Especie + "\n Peso en Kg: " + (Peso.ToString()) + "\n Estoy en la jaula: " + (Jaula.ToString());
            
        }

    }

    

}
