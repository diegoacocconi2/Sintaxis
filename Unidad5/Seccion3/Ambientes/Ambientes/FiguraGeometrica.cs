using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambientes
{
   public abstract class FiguraGeometrica
   {
      protected float ancho;
      protected float alto;
      protected float profund;

      public float area () {
         return (ancho * alto);
      }
   }
}
