using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML;
using ClosedXML.Excel;
using Syncfusion.XlsIO;

namespace GenerarExcel
{
    public partial class Form1 : Form
    {

        List<Alumno> alumnos = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "2021";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            alumnos = db.GetAlumno(comboBox1.Text);

            var workbook = new XLWorkbook();
            workbook.AddWorksheet("sheetName");
            var ws = workbook.Worksheet("sheetName");

            int row = 1;

            ws.Cell("A" + row.ToString()).Value = "DOC";
            ws.Cell("B" + row.ToString()).Value = "NOMBRE";
            ws.Cell("C" + row.ToString()).Value = "FECHA NACIMIENTO";
            ws.Cell("D" + row.ToString()).Value = "DOMICILIO";
            ws.Cell("E" + row.ToString()).Value = "DEPARTAMENTO";
            ws.Cell("F" + row.ToString()).Value = "CURSO";
            ws.Cell("G" + row.ToString()).Value = "DIVISION";
            row++;
            
            foreach (var c in alumnos)
            {
                //Escribrie en Excel en cada celda
                ws.Cell("A" + row.ToString()).Value = c.DOC;
                ws.Cell("B" + row.ToString()).Value = c.NOMBRE;
                ws.Cell("C" + row.ToString()).Value = c.FECNAC;
                ws.Cell("D" + row.ToString()).Value = c.DOMICILIO;
                ws.Cell("E" + row.ToString()).Value = c.DEPAR;
                ws.Cell("F" + row.ToString()).Value = c.CURSO;
                ws.Cell("G" + row.ToString()).Value = c.DIV;
                row++;
            }


            saveFileDialog1.Filter = "Archivo .xlxs (Excel)|*.xlsx";
            saveFileDialog1.Title = "Guardar Datos en Excel";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.FileName = "datos" + comboBox1.Text;
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                workbook.SaveAs(@path);
                MessageBox.Show("El Archivo fue creado correctamente", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

    }
}
