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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            buttonAgregar.Enabled = false;
            buttonModificar.Enabled = false;
            buttonSuprimir.Enabled = false;
            linkNueva.Enabled = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void linkNueva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new NuevoUsuario().ShowDialog();
        }


        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            bool login = log.logstatus;
            if (login)
            {
                buttonAgregar.Enabled = true;
                buttonModificar.Enabled = true;
                buttonSuprimir.Enabled = true;
                linkNueva.Enabled = true;
            }
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonConsulta_Click(object sender, EventArgs e)
        {
            new Consulta().ShowDialog();
        }
    }
}
