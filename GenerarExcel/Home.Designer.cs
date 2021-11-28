
namespace GenerarExcel
{
    partial class Home
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
            this.botonConsulta = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonSuprimir = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.linkNueva = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // botonConsulta
            // 
            this.botonConsulta.Location = new System.Drawing.Point(16, 16);
            this.botonConsulta.Margin = new System.Windows.Forms.Padding(7);
            this.botonConsulta.Name = "botonConsulta";
            this.botonConsulta.Size = new System.Drawing.Size(175, 51);
            this.botonConsulta.TabIndex = 0;
            this.botonConsulta.Text = "Consulta";
            this.botonConsulta.UseVisualStyleBackColor = true;
            this.botonConsulta.Click += new System.EventHandler(this.botonConsulta_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(16, 90);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(175, 51);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(16, 163);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(175, 51);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonSuprimir
            // 
            this.buttonSuprimir.Location = new System.Drawing.Point(16, 235);
            this.buttonSuprimir.Name = "buttonSuprimir";
            this.buttonSuprimir.Size = new System.Drawing.Size(175, 51);
            this.buttonSuprimir.TabIndex = 5;
            this.buttonSuprimir.Text = "Suprimir";
            this.buttonSuprimir.UseVisualStyleBackColor = true;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(258, 20);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(115, 42);
            this.buttonIngresar.TabIndex = 6;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(258, 239);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(115, 42);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // linkNueva
            // 
            this.linkNueva.AutoSize = true;
            this.linkNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkNueva.Location = new System.Drawing.Point(272, 65);
            this.linkNueva.Name = "linkNueva";
            this.linkNueva.Size = new System.Drawing.Size(84, 15);
            this.linkNueva.TabIndex = 9;
            this.linkNueva.TabStop = true;
            this.linkNueva.Text = "nuevo usuario";
            this.linkNueva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNueva_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 298);
            this.Controls.Add(this.linkNueva);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.buttonSuprimir);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.botonConsulta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConsulta;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonSuprimir;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.LinkLabel linkNueva;
    }
}