using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria {
   public class Persona { // Clase genérica de una persona

      // ATRIBUTOS
      private string nombre;
      private string apellido;

      // MÉTODOS
      // Constructor
      public Persona (string nombre, string apellido) {
         this.nombre = nombre;
         this.apellido = apellido;
      }

      // Función: Obtiene el nombre completo de la persona
      public string NombreCompleto () {
         return nombre + " " + apellido;
      }

      // Función redefinida: muestra el valor de cadena de los objetos
      public override string ToString () {
         return NombreCompleto ();
      }
   }
}
