using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria {
   public class Animal {  // Clase genérica de un animal

      // ATRIBUTOS
      private string nombre;
      private Cliente dueño;
      private double peso;

      // MÉTODOS
      // Constructor
      public Animal (string nombre, Cliente dueño, double peso) {
         this.nombre = nombre;
         this.dueño = dueño;
         this.peso = peso;
      }

      // Función: Obtiene los datos del animal
      public virtual string ResumenDatos () {
         return "Nombre: " + nombre
            + " / Dueño: " + (dueño != null ? dueño.NombreCompleto () : "-") 
            + " / Peso: " + peso;
      }

      // Función redefinida: muestra el valor de cadena de los objetos
      public override string ToString () {
         return ResumenDatos ();
      }
   }
}
