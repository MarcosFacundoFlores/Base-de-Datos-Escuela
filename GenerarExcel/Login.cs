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
    public partial class Login : Form
    {
 
        public bool logstatus { get; set;}

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textDNI.Text == "" || textPass.Text == "")
            {
                MessageBox.Show("Ingrese DNI y CONTRASEÑA.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataAccess db = new DataAccess();

                if (db.Login(textDNI.Text, textPass.Text))
                {
                    logstatus = true;
                    MessageBox.Show("Ingreso con éxito.", "ÉXITO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("DNI o contraseña incorrectos.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
