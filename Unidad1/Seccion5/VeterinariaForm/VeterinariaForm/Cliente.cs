using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
   public class Cliente : Persona { // Clase para un cliente que hereda de una persona
      
      // MÉTODOS
      // Constructor
      public Cliente (string nombre, string apellido)
         : base (nombre, apellido) { }
   }
}
