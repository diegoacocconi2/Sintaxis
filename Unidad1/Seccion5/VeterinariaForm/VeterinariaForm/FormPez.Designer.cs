namespace VeterinariaForm
{
   partial class FormPez
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
         this.etiqDueño = new System.Windows.Forms.Label();
         this.etiqPeso = new System.Windows.Forms.Label();
         this.etiqColor = new System.Windows.Forms.Label();
         this.textNombre = new System.Windows.Forms.TextBox();
         this.textPeso = new System.Windows.Forms.TextBox();
         this.textColor = new System.Windows.Forms.TextBox();
         this.selDueño = new System.Windows.Forms.ComboBox();
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
         // etiqDueño
         // 
         this.etiqDueño.AutoSize = true;
         this.etiqDueño.Location = new System.Drawing.Point(12, 64);
         this.etiqDueño.Name = "etiqDueño";
         this.etiqDueño.Size = new System.Drawing.Size(96, 37);
         this.etiqDueño.TabIndex = 1;
         this.etiqDueño.Text = "Dueño";
         // 
         // etiqPeso
         // 
         this.etiqPeso.AutoSize = true;
         this.etiqPeso.Location = new System.Drawing.Point(12, 115);
         this.etiqPeso.Name = "etiqPeso";
         this.etiqPeso.Size = new System.Drawing.Size(72, 37);
         this.etiqPeso.TabIndex = 2;
         this.etiqPeso.Text = "Peso";
         // 
         // etiqColor
         // 
         this.etiqColor.AutoSize = true;
         this.etiqColor.Location = new System.Drawing.Point(12, 164);
         this.etiqColor.Name = "etiqColor";
         this.etiqColor.Size = new System.Drawing.Size(82, 37);
         this.etiqColor.TabIndex = 3;
         this.etiqColor.Text = "Color";
         // 
         // textNombre
         // 
         this.textNombre.Location = new System.Drawing.Point(183, 12);
         this.textNombre.Name = "textNombre";
         this.textNombre.Size = new System.Drawing.Size(421, 43);
         this.textNombre.TabIndex = 4;
         // 
         // textPeso
         // 
         this.textPeso.Location = new System.Drawing.Point(183, 112);
         this.textPeso.Name = "textPeso";
         this.textPeso.Size = new System.Drawing.Size(421, 43);
         this.textPeso.TabIndex = 5;
         // 
         // textColor
         // 
         this.textColor.Location = new System.Drawing.Point(183, 161);
         this.textColor.Name = "textColor";
         this.textColor.Size = new System.Drawing.Size(421, 43);
         this.textColor.TabIndex = 6;
         // 
         // selDueño
         // 
         this.selDueño.FormattingEnabled = true;
         this.selDueño.Location = new System.Drawing.Point(183, 61);
         this.selDueño.Name = "selDueño";
         this.selDueño.Size = new System.Drawing.Size(421, 45);
         this.selDueño.TabIndex = 7;
         // 
         // botGuardar
         // 
         this.botGuardar.Location = new System.Drawing.Point(192, 244);
         this.botGuardar.Name = "botGuardar";
         this.botGuardar.Size = new System.Drawing.Size(233, 52);
         this.botGuardar.TabIndex = 8;
         this.botGuardar.Text = "Guardar pez";
         this.botGuardar.UseVisualStyleBackColor = true;
         this.botGuardar.Click += new System.EventHandler(this.botGuardar_Click);
         // 
         // FormPez
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(616, 322);
         this.Controls.Add(this.botGuardar);
         this.Controls.Add(this.selDueño);
         this.Controls.Add(this.textColor);
         this.Controls.Add(this.textPeso);
         this.Controls.Add(this.textNombre);
         this.Controls.Add(this.etiqColor);
         this.Controls.Add(this.etiqPeso);
         this.Controls.Add(this.etiqDueño);
         this.Controls.Add(this.etiqNombre);
         this.Name = "FormPez";
         this.Text = "Pez";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Label etiqNombre;
      private Label etiqDueño;
      private Label etiqPeso;
      private Label etiqColor;
      private TextBox textNombre;
      private TextBox textPeso;
      private TextBox textColor;
      private ComboBox selDueño;
      private Button botGuardar;
   }
}