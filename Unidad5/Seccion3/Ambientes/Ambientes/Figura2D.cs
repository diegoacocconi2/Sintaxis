using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambientes
{
   public abstract class Figura2D : FiguraGeometrica
   {
      public Figura2D (float ancho, float alto) {
         this.ancho = ancho;
         this.alto = alto;
         this.profund = 0.0f;
      }
   }
}
