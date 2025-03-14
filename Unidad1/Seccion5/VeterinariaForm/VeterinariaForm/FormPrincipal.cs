using Veterinaria;

namespace VeterinariaForm
{
   public partial class FormPrincipal : Form
   {
      private List <Cliente> listaClientes = new List <Cliente> ();
      private List <Animal> listaMascotas = new List <Animal> ();

      public FormPrincipal () {
         InitializeComponent ();
      }

      private void botNuevoCliente_Click (object sender, EventArgs e) {
         FormCliente formCliente = new FormCliente (this);

         formCliente.ShowDialog ();
      }

      private void botNuevoPerro_Click (object sender, EventArgs e) {
         FormPerro formPerro = new FormPerro (this);

         formPerro.ShowDialog ();
      }

      private void botNuevoPez_Click (object sender, EventArgs e) {
         FormPez formPez = new FormPez (this);

         formPez.ShowDialog ();
      }

      public void AgregarCliente (Cliente cliente) {
         listaClientes.Add (cliente);
      }

      public void ActualizarClientes () {
         listClientes.Items.Clear ();
         listClientes.Items.AddRange (listaClientes.ToArray ());
      }

      public List <Cliente> Clientes { get { return listaClientes; } }

      public void AgregarMascota (Animal mascota) {
         listaMascotas.Add (mascota);
      }

      public void ActualizarMascotas () {
         listMascotas.Items.Clear ();
         listMascotas.Items.AddRange (listaMascotas.ToArray ());
      }

      public List <Animal> Mascotas { get { return listaMascotas; } }
   }
}