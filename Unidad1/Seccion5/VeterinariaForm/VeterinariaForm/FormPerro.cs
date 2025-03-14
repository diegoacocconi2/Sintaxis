using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria;

namespace VeterinariaForm
{
   public partial class FormPerro : Form
   {
      private FormPrincipal formPrinc;

      public FormPerro () {
         InitializeComponent ();
      }

      public FormPerro (FormPrincipal formPrinc) : this () {
         this.formPrinc = formPrinc;

         selDueño.Items.Clear ();
         selDueño.Items.AddRange (formPrinc.Clientes.ToArray ());
      }

      private void botGuardar_Click (object sender, EventArgs e) {
         try {
            Perro nuevoPerro = new Perro (textNombre.Text,
                                          (Cliente) selDueño.SelectedItem,
                                          Double.Parse (textPeso.Text),
                                          textRaza.Text);

            formPrinc.AgregarMascota (nuevoPerro);
            formPrinc.ActualizarMascotas ();

            this.Close();
         }
         catch {
            MessageBox.Show ("Error registrando el perro");
         }
      }
   }
}
