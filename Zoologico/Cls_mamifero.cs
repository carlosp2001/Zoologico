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
            return "Soy un mamifero llamado: " + Nombre + "\nde la especie: "+Especie + "\nPeso en Kg: " + (Peso.ToString()) + "\nEstoy en la jaula: " + (Jaula.ToString());
            
        }

    }

    

}
