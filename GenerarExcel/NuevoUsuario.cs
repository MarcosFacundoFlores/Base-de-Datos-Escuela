using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerarExcel
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text== "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Ingrese DNI y CONTRASEÑA", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (textBoxConfirmar.Text != textBoxPassword.Text)
            {
                MessageBox.Show("Las contraseñas NO coinciden. Intentelo otra vez", "ERROR",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataAccess db = new DataAccess();
                db.InsertPassword(textBoxUser.Text, textBoxPassword.Text);
                MessageBox.Show("Usuario creado con éxito", "ÉXITO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

    }
}
