namespace VeterinariaForm
{
   partial class FormCliente
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
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
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.etiqNombre = new System.Windows.Forms.Label();
         this.textNombre = new System.Windows.Forms.TextBox();
         this.etiqApellido = new System.Windows.Forms.Label();
         this.textApellido = new System.Windows.Forms.TextBox();
         this.botGuardar = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // etiqNombre
         // 
         this.etiqNombre.AutoSize = true;
         this.etiqNombre.Location = new System.Drawing.Point(12, 15);
         this.etiqNombre.Name = "etiqNombre";
         this.etiqNombre.Size = new System.Drawing.Size(115, 37);
         this.etiqNombre.TabIndex = 0;
         this.etiqNombre.Text = "Nombre";
         // 
         // textNombre
         // 
         this.textNombre.Location = new System.Drawing.Point(176, 12);
         this.textNombre.Name = "textNombre";
         this.textNombre.Size = new System.Drawing.Size(426, 43);
         this.textNombre.TabIndex = 1;
         // 
         // etiqApellido
         // 
         this.etiqApellido.AutoSize = true;
         this.etiqApellido.Location = new System.Drawing.Point(10, 64);
         this.etiqApellido.Name = "etiqApellido";
         this.etiqApellido.Size = new System.Drawing.Size(117, 37);
         this.etiqApellido.TabIndex = 2;
         this.etiqApellido.Text = "Apellido";
         // 
         // textApellido
         // 
         this.textApellido.Location = new System.Drawing.Point(176, 64);
         this.textApellido.Name = "textApellido";
         this.textApellido.Size = new System.Drawing.Size(426, 43);
         this.textApellido.TabIndex = 3;
         // 
         // botGuardar
         // 
         this.botGuardar.Location = new System.Drawing.Point(204, 146);
         this.botGuardar.Name = "botGuardar";
         this.botGuardar.Size = new System.Drawing.Size(224, 52);
         this.botGuardar.TabIndex = 4;
         this.botGuardar.Text = "Guardar cliente";
         this.botGuardar.UseVisualStyleBackColor = true;
         this.botGuardar.Click += new System.EventHandler(this.botGuardar_Click);
         // 
         // FormCliente
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(614, 227);
         this.Controls.Add(this.botGuardar);
         this.Controls.Add(this.textApellido);
         this.Controls.Add(this.etiqApellido);
         this.Controls.Add(this.textNombre);
         this.Controls.Add(this.etiqNombre);
         this.Name = "FormCliente";
         this.Text = "Cliente";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Label etiqNombre;
      private TextBox textNombre;
      private Label etiqApellido;
      private TextBox textApellido;
      private Button botGuardar;
   }
}