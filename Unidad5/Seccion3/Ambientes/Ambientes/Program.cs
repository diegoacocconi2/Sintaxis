using Ambientes;

bool ProcA (int a1, int a2) {
   if (a1 >= a2) return true;
   else return false;
}

void ProcB (int b) {
   Console.WriteLine ("Parámetro de ProcB: " + b);
}

int factorial (int n) {
   int result;

   if (n == 1) result = 1;
   else result = n * factorial (n - 1);

   return result;
}

Console.WriteLine ("*** Inicio de las pruebas");

// Ítem 2
{
   int x = 10, y = 5, z;

   if (ProcA (x, y)) {
      z = 20;

      ProcB (z);
   }
   else {
      z = 0;
   }
}

// Ítem 3
factorial (5);

// Ítem 4
{
   {
      List <FiguraGeometrica> listaFiguras = new List <FiguraGeometrica> ();

      for (int i = 1; i < 4; i++) {
         listaFiguras.Add (new Cuadrado (i));
      }

      Console.WriteLine ("Tomar instantánea del montículo aquí");
   }

   Circulo circ1 = new Circulo (1);
   Circulo circ2 = new Circulo (2);

   Console.WriteLine ("Tomar instantánea del montículo aquí");
   Console.WriteLine ("Área de circ2: " + circ2.area ());
}

Console.WriteLine ("Tomar instantánea del montículo aquí");
Console.WriteLine ("*** Fin de las pruebas");