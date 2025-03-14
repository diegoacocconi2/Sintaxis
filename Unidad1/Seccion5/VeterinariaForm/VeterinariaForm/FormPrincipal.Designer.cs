namespace VeterinariaForm
{
   partial class FormPrincipal
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.botNuevoCliente = new System.Windows.Forms.Button();
         this.botNuevoPerro = new System.Windows.Forms.Button();
         this.listClientes = new System.Windows.Forms.ListBox();
         this.etiqClientes = new System.Windows.Forms.Label();
         this.listMascotas = new System.Windows.Forms.ListBox();
         this.botNuevoPez = new System.Windows.Forms.Button();
         this.etiqMascotas = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // botNuevoCliente
         // 
         this.botNuevoCliente.Location = new System.Drawing.Point(12, 12);
         this.botNuevoCliente.Name = "botNuevoCliente";
         this.botNuevoCliente.Size = new System.Drawing.Size(247, 52);
         this.botNuevoCliente.TabIndex = 0;
         this.botNuevoCliente.Text = "Nuevo cliente...";
         this.botNuevoCliente.UseVisualStyleBackColor = true;
         this.botNuevoCliente.Click += new System.EventHandler(this.botNuevoCliente_Click);
         // 
         // botNuevoPerro
         // 
         this.botNuevoPerro.Location = new System.Drawing.Point(12, 70);
         this.botNuevoPerro.Name = "botNuevoPerro";
         this.botNuevoPerro.Size = new System.Drawing.Size(247, 52);
         this.botNuevoPerro.TabIndex = 1;
         this.botNuevoPerro.Text = "Nuevo perro...";
         this.botNuevoPerro.UseVisualStyleBackColor = true;
         this.botNuevoPerro.Click += new System.EventHandler(this.botNuevoPerro_Click);
         // 
         // listClientes
         // 
         this.listClientes.FormattingEnabled = true;
         this.listClientes.ItemHeight = 37;
         this.listClientes.Location = new System.Drawing.Point(12, 243);
         this.listClientes.Name = "listClientes";
         this.listClientes.Size = new System.Drawing.Size(247, 226);
         this.listClientes.TabIndex = 3;
         // 
         // etiqClientes
         // 
         this.etiqClientes.AutoSize = true;
         this.etiqClientes.Location = new System.Drawing.Point(12, 203);
         this.etiqClientes.Name = "etiqClientes";
         this.etiqClientes.Size = new System.Drawing.Size(111, 37);
         this.etiqClientes.TabIndex = 4;
         this.etiqClientes.Text = "Clientes";
         // 
         // listMascotas
         // 
         this.listMascotas.FormattingEnabled = true;
         this.listMascotas.ItemHeight = 37;
         this.listMascotas.Location = new System.Drawing.Point(316, 60);
         this.listMascotas.Name = "listMascotas";
         this.listMascotas.Size = new System.Drawing.Size(1073, 411);
         this.listMascotas.TabIndex = 5;
         // 
         // botNuevoPez
         // 
         this.botNuevoPez.Location = new System.Drawing.Point(12, 128);
         this.botNuevoPez.Name = "botNuevoPez";
         this.botNuevoPez.Size = new System.Drawing.Size(247, 52);
         this.botNuevoPez.TabIndex = 6;
         this.botNuevoPez.Text = "Nuevo pez...";
         this.botNuevoPez.UseVisualStyleBackColor = true;
         this.botNuevoPez.Click += new System.EventHandler(this.botNuevoPez_Click);
         // 
         // etiqMascotas
         // 
         this.etiqMascotas.AutoSize = true;
         this.etiqMascotas.Location = new System.Drawing.Point(316, 20);
         this.etiqMascotas.Name = "etiqMascotas";
         this.etiqMascotas.Size = new System.Drawing.Size(128, 37);
         this.etiqMascotas.TabIndex = 7;
         this.etiqMascotas.Text = "Mascotas";
         // 
         // FormPrincipal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1401, 489);
         this.Controls.Add(this.etiqMascotas);
         this.Controls.Add(this.botNuevoPez);
         this.Controls.Add(this.listMascotas);
         this.Controls.Add(this.etiqClientes);
         this.Controls.Add(this.listClientes);
         this.Controls.Add(this.botNuevoPerro);
         this.Controls.Add(this.botNuevoCliente);
         this.Name = "FormPrincipal";
         this.Text = "Veterinaria";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Button botNuevoCliente;
      private Button botNuevoPerro;
      private ListBox listClientes;
      private Label etiqClientes;
      private ListBox listMascotas;
      private Button botNuevoPez;
      private Label etiqMascotas;
   }
}