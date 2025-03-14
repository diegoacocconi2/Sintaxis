using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
   public class Pez : Animal { // Clase para un pez que hereda de un animal

      // ATRIBUTOS
      private string color;

      // MÉTODOS
      // Constructor
      public Pez (string nombre, Cliente dueño, double peso, string color)
         : base (nombre, dueño, peso) {

         this.color = color;
      }

      // Función: Obtiene los datos del pez, sobreescribiendo el método de un animal
      public override string ResumenDatos () {
         return base.ResumenDatos () + " / Color: " + color
             + " (" + this.GetType ().Name.ToUpper () + ")";
      }
   }
}
