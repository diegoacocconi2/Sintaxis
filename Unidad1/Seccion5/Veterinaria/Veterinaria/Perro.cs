using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
   public class Perro : Mamifero { // Clase para un perro que hereda de un mamífero
      
      // ATRIBUTOS
      private string raza;

      // MÉTODOS
      // Constructor
      public Perro (string nombre, Cliente dueño, double peso, string raza)
         : base (nombre, dueño, peso) {

         this.raza = raza;
      }

      // Procedimiento: Registra una vacunación del perro
      public void vacunar (string vacuna, double dosis, DateTime fecha) { }

      // Procedimiento: Registra una operación del perro
      public void operar (string operacion, DateTime fecha) { }

      // Función: Obtiene los datos del perro, sobreescribiendo el método de un animal
      public override string ResumenDatos () {
         return base.ResumenDatos () + " / Raza: " + raza
             + " (" + this.GetType ().Name.ToUpper () + ")";
      }
   }
}
