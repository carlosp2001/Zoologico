using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    
    public class cls_Animal //Clase
    {
        private String nombre;
        private double peso;
        private int jaula;
        private string especie;
        //Propiedades Accesoras Encapsulamiento
        protected string Especie { get => especie; set => especie = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected double Peso { get => peso; set => peso = value; }
        protected int Jaula { get => jaula; set => jaula = value; }

        public cls_Animal(String especie, String nombre, double peso, int jaula)
        {
            this.Especie = especie;
            this.Nombre = nombre;
            this.Peso = peso;
            this.Jaula = jaula;
        }




        //Polimorfismo
        public virtual String QueClaseDeAnimalEres() {

            return "mensaje";
        }
        
        
    }
    
}
