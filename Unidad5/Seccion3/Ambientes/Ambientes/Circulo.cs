using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambientes
{
   public class Circulo : Figura2D
   {
      private float diametro;

      public Circulo (float diametro) : base (diametro, diametro) {
         this.diametro = diametro;
      }
      
      public new float area () {
         return ((float) Math.PI * diametro);
      }
   }
}
