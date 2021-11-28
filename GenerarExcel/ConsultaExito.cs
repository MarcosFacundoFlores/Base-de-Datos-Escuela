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
    public partial class ConsultaExito : Form
    {
        public ConsultaExito(string DNI)
        {
            InitializeComponent();
            BuscarAlumno(DNI);

        }

        private void BuscarAlumno(string DNI)
        {
            DataAccess dt = new DataAccess();
            List<Alumno> alumnos = new List<Alumno>();
            alumnos = dt.ConsultaAlumno(DNI);
        }

        private void gridCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
