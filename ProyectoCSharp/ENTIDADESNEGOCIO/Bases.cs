using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCSharp.ENTIDADESNEGOCIO
{
    public class Bases
    {
        public static void DiseñoDataGridView(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.RowHeadersVisible = false;
        }
        public static void DiseñoDataGridViewEliminar(ref DataGridView Listado)
        {
            foreach (DataGridViewRow row in Listado.Rows)
            {
                string Estado;
                Estado = row.Cells["Estado"].Value.ToString();
                if (Estado == "ELIMINADO")
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 128);
                }
            }
        }
    }
}
