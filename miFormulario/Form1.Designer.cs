namespace miFormulario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            txbNombre = new TextBox();
            txbApellido = new TextBox();
            txtDNI = new TextBox();
            btnAceptar = new Button();
            lblNombreCompleto = new Label();
            lblApellidoNombre = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(44, 55);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(68, 85);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(108, 22);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(222, 23);
            txbNombre.TabIndex = 3;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(108, 54);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(222, 23);
            txbApellido.TabIndex = 4;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(108, 83);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(222, 23);
            txtDNI.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(551, 250);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(60, 160);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(110, 15);
            lblNombreCompleto.TabIndex = 7;
            lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // lblApellidoNombre
            // 
            lblApellidoNombre.AutoSize = true;
            lblApellidoNombre.Location = new Point(186, 160);
            lblApellidoNombre.Name = "lblApellidoNombre";
            lblApellidoNombre.Size = new Size(177, 15);
            lblApellidoNombre.TabIndex = 8;
            lblApellidoNombre.Text = "Aqui va a ir el nombre completo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 295);
            Controls.Add(lblApellidoNombre);
            Controls.Add(lblNombreCompleto);
            Controls.Add(btnAceptar);
            Controls.Add(txtDNI);
            Controls.Add(txbApellido);
            Controls.Add(txbNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Datos de Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private TextBox txbNombre;
        private TextBox txbApellido;
        private TextBox txtDNI;
        private Button btnAceptar;
        private Label lblNombreCompleto;
        private Label lblApellidoNombre;
    }
}