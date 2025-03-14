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
   public partial class FormCliente : Form
   {
      private FormPrincipal formPrinc;

      public FormCliente () {
         InitializeComponent ();
      }

      public FormCliente (FormPrincipal formPrinc) : this () {
         this.formPrinc = formPrinc;
      }

      private void botGuardar_Click (object sender, EventArgs e) {
         Cliente nuevoCliente = new Cliente (textNombre.Text, textApellido.Text);

         formPrinc.AgregarCliente (nuevoCliente);
         formPrinc.ActualizarClientes ();

         this.Close ();
      }
   }
}
