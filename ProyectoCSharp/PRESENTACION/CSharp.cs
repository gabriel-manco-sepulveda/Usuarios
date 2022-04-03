using ProyectoCSharp.PRESENTACION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCSharp
{
    public partial class FormCSharp : Form
    {
        public FormCSharp()
        {
            InitializeComponent();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            ControlRegistros Control = new ControlRegistros();
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(Control);
            PanelPrincipal.Dock = DockStyle.Fill;
        }

       
    }
}
