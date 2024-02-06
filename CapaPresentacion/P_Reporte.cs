using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CapaPresentacion
{
    public partial class P_Reporte : Form
    {

        public P_Reporte(string usuario)
        {
            InitializeComponent();

            P_generarReporte(usuario);
            
        }

        N_Inventario objNegocio = new N_Inventario();

        public void P_generarReporte(string usuario)
        {
            DataTable dt = objNegocio.N_generarReporte();
            dataGridViewReporte.DataSource = dt;

            labelFechaActual.Text = DateTime.Now.ToString("dd-MM-yyyy");
            labelUsuario.Text = usuario;
        }

        private void imprimirReporte()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "reporte.pdf";

            DataTable dataTable = objNegocio.N_generarReporte();

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    PdfPTable table = new PdfPTable(dataTable.Columns.Count);
                    table.WidthPercentage = 100;

                    for (int k = 0; k < dataTable.Columns.Count; k++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(dataTable.Columns[k].ColumnName));

                        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);

                        table.AddCell(cell);
                    }

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(dataTable.Rows[i][j].ToString()));

                            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                            cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                            table.AddCell(cell);
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();

                }

            }

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            imprimirReporte();
        }
    }
}
