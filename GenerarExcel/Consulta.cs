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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess dt = new DataAccess();

            if (dt.Consulta(textDNI.Text))
            {
                ConsultaExito consulta = new ConsultaExito(textDNI.Text);
                consulta.ShowDialog();
            }
            else
            {
                MessageBox.Show("NO se encontró el DNI.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

          //  new ConsultaExito().Show();
        }
    }
}
