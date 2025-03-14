using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
   public class Mamifero : Animal {  // Clase genérica de un mamífero
      
      // MÉTODOS
      // Constructor
      public Mamifero (string nombre, Cliente dueño, double peso)
         : base (nombre, dueño, peso) { }
   }
}
