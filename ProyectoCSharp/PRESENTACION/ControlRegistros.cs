using ProyectoCSharp.DATOSNEGOCIO;
using ProyectoCSharp.ENTIDADESNEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCSharp.PRESENTACION
{
    public partial class ControlRegistros : UserControl
    {
        public ControlRegistros()
        {
            InitializeComponent();
        }
        int IDProfesion=0;
        int Desde = 1;
        int Hasta = 10;
        int Contador;
        int IDUsuario;
        private int ItemxPagina = 10;
        int TotalPaginas;
        string Estado;
        private void btnVolverU_Click(object sender, EventArgs e)
        {
            PanelRegistrosUP.Visible = false;
            PanelPaginacion.Visible = true;
        }

        private void btnVolverP_Click(object sender, EventArgs e)
        {
            PanelRegistrosP.Visible = false;
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            Profesiones_Insertar();
        }

        private void Profesiones_Insertar()
        {
            if(!string.IsNullOrEmpty(txtProfesionP.Text))
            {
                if (!string.IsNullOrEmpty(txtSueldoP.Text))
                {
                    clsBEProfesiones Parametros = new clsBEProfesiones();
                    clsDACSharp Funcion = new clsDACSharp();
                    Parametros.Profesion = txtProfesionP.Text;
                    Parametros.Sueldo = Convert.ToDouble(txtSueldoP.Text);
                    if (Funcion.tblProfesiones_Insertar(Parametros) == true)
                    {
                        txtProfesionU.Clear();
                        Profesiones_Buscar();
                        LimpiarUsuarios();
                        PanelRegistrosP.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Falta introducir el campo sueldo", "agregue el campo de sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Falta introducir el campo Profesión", "ingresa el campo Profesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        
        private void Profesiones_Buscar()
        {
            DataTable dt = new DataTable();
            clsDACSharp Funcion = new clsDACSharp();
            Funcion.tblProfesiones_Buscar(ref dt, txtProfesionU.Text);
            DataListadoProfesiones.DataSource = dt;
            Bases.DiseñoDataGridView(ref DataListadoProfesiones);
            DataListadoProfesiones.Columns[1].Visible = false;
            DataListadoProfesiones.Visible = true;
        }
        private void Profesiones_Limpiar()
        {
            txtProfesionP.Clear();
            txtSueldoP.Clear();
            Profesiones_Buscar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PanelRegistrosP.Visible = false;
            PanelPaginacion.Visible = false;
            PanelRegistrosUP.Visible = true;
            PanelRegistrosUP.Dock = DockStyle.Fill;
            btnGuardarU.Visible = true;
            btnGuardarCambiosU.Visible = false;
            Profesiones_Limpiar();
        }

        private void txtProfesionU_TextChanged(object sender, EventArgs e)
        {
            Profesiones_Buscar();
        }

        private void btnProfesionmas_Click(object sender, EventArgs e)
        {
            PanelRegistrosP.Visible = true;
            PanelRegistrosP.BringToFront();
            PanelRegistrosP.Dock = DockStyle.Fill;
            PanelPaginacion.Visible = false;
            btnGuardarP.Visible = true;
            btnGuardarCambiosP.Visible = false;
        }

        private void DataListadoProfesiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DataListadoProfesiones.Columns["EditarProfesiones"].Index)
            {
                Profesiones_Editar();
            }
            if(e.ColumnIndex == DataListadoProfesiones.Columns["Profesion"].Index)
            {
                profesiones_Obtener();
            }
        }
        private void profesiones_Obtener()
        {
            IDProfesion = Convert.ToInt32(DataListadoProfesiones.SelectedCells[1].Value);
            txtProfesionU.Text = DataListadoProfesiones.SelectedCells[2].Value.ToString();
            txtSueldoU.Text = DataListadoProfesiones.SelectedCells[3].Value.ToString();
            DataListadoProfesiones.Visible = false;
            PanelGuardarU.Visible = true;
            lblSueldo.Visible = true;
        }
        private void Profesiones_Editar()
        {
            IDProfesion = Convert.ToInt32(DataListadoProfesiones.SelectedCells[1].Value);
            txtProfesionP.Text = DataListadoProfesiones.SelectedCells[2].Value.ToString();
            txtSueldoP.Text = DataListadoProfesiones.SelectedCells[3].Value.ToString();
            btnGuardarP.Visible = false;
            btnGuardarCambiosP.Visible = true;
            txtProfesionP.Focus();
            txtProfesionP.SelectAll();
            PanelRegistrosP.Visible = true;
            PanelRegistrosP.Dock = DockStyle.Fill;
            PanelRegistrosP.BringToFront();
        }

        private void btnGuardarCambiosP_Click(object sender, EventArgs e)
        {
            Editar_Profesiones();
        }
        private void Editar_Profesiones()
        {
            clsBEProfesiones Parametros = new clsBEProfesiones();
            clsDACSharp Funcion = new clsDACSharp();
            Parametros.ID_Profesion = IDProfesion;
            Parametros.Profesion = txtProfesionU.Text;
            Parametros.Sueldo = Convert.ToDouble(txtSueldoU.Text);
            if (Funcion.tblProfesiones_Editar(Parametros) == true)
            {
                txtProfesionU.Clear();
                Profesiones_Buscar();
                PanelRegistrosP.Visible = false;
            }
        }

        private void btnGuardarU_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombres.Text))
            {
                if(!string.IsNullOrEmpty(txtApellidos.Text))
                {
                    if(!string.IsNullOrEmpty(txtIdentificacion.Text))
                    {
                        if(!string.IsNullOrEmpty(cbPais.Text))
                        {
                            if (IDProfesion > 0)
                            {
                                if (!string.IsNullOrEmpty(txtSueldoU.Text))
                                {
                                    Usuarios_Insertar();
                                }
                            }
                        }
                    }
                }
            }
        }
        private void Usuarios_Insertar()
        {
            clsBEUsuarios Parametros = new clsBEUsuarios();
            clsDACSharp Funcion = new clsDACSharp();
            Parametros.Nombres = txtNombres.Text;
            Parametros.Apellidos = txtApellidos.Text;
            Parametros.Identificacion = txtIdentificacion.Text;
            Parametros.Pais = cbPais.Text;
            Parametros.ID_Profesion = IDProfesion;
            Parametros.Sueldo = Convert.ToDouble(txtSueldoU.Text);
            if (Funcion.tblUsuarios_Insertar(Parametros)==true)
            {
                Reiniciar_Paginado();
                Usuarios_Mostrar();
                PanelRegistrosUP.Visible = false;
            }
        }
        private void Usuarios_Mostrar()
        {
            DataTable dt = new DataTable();
            clsDACSharp Funcion = new clsDACSharp();
            Funcion.tblUsuarios_Mostrar(ref dt, Desde, Hasta);
            DataListadoUsuarios.DataSource = dt;
            DiseñarDataGridViewUsuarios();
            DataListadoUsuarios.Columns[2].Visible = false;
        }
        private void DiseñarDataGridViewUsuarios()
        {
            Bases.DiseñoDataGridView(ref DataListadoUsuarios);
            Bases.DiseñoDataGridViewEliminar(ref DataListadoUsuarios);
            PanelPaginacion.Visible = true;
            PanelRegistrosUP.Visible = false;
        }

        private void ControlRegistros_Load(object sender, EventArgs e)
        {
            Reiniciar_Paginado();
            Usuarios_Mostrar();
        }
        private void Reiniciar_Paginado()
        {
            Desde = 1;
            Hasta = 10;
            Usuarios_Contar();
            if (Contador > Hasta)
            {
                btnSiguientePag.Visible = true;
                btnAnteriorPag.Visible = false;
                btnUltimaPag.Visible = true;
                btnPrimeraPag.Visible = true;
            }
            else
            {
                btnSiguientePag.Visible = false;
                btnAnteriorPag.Visible = false;
                btnUltimaPag.Visible = false;
                btnPrimeraPag.Visible = false;
            }
            Paginar();
        }

        private void DataListadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DataListadoUsuarios.Columns["EliminarUsuarios"].Index)
            {
                DialogResult result = MessageBox.Show("Se cambiará el estado para que no se pueda acceder, ¿Desea Continuar?", "Eliminando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    Usuarios_Eliminar();
                }    
            }
            if (e.ColumnIndex == DataListadoUsuarios.Columns["EditarUsuarios"].Index)
            {
                Usuarios_ObtenerDatos();
            }
        }
        private void Usuarios_ObtenerDatos()
        {
            IDUsuario = Convert.ToInt32(DataListadoUsuarios.SelectedCells[2].Value);
            Estado = DataListadoUsuarios.SelectedCells[10].Value.ToString();
            if(Estado == "ELIMINADO")
            {
                Usuarios_Restaurar();
            }
            else
            {
                txtNombres.Text = DataListadoUsuarios.SelectedCells[3].Value.ToString();
                txtApellidos.Text = DataListadoUsuarios.SelectedCells[4].Value.ToString();
                txtIdentificacion.Text = DataListadoUsuarios.SelectedCells[5].Value.ToString();
                cbPais.Text = DataListadoUsuarios.SelectedCells[8].Value.ToString();
                IDProfesion = Convert.ToInt32(DataListadoUsuarios.SelectedCells[9].Value);
                txtProfesionU.Text = DataListadoUsuarios.SelectedCells[7].Value.ToString();
                txtSueldoU.Text = DataListadoUsuarios.SelectedCells[6].Value.ToString();
                PanelPaginacion.Visible = false;
                PanelRegistrosUP.Visible = true;
                PanelRegistrosUP.Dock = DockStyle.Fill;
                DataListadoProfesiones.Visible = false;
                lblSueldo.Visible = true;
                PanelGuardarU.Visible = true;
                btnGuardarU.Visible = false;
                btnGuardarCambiosU.Visible = true;
                PanelRegistrosP.Visible = false;
            }
        }
        private void Usuarios_Restaurar()
        {
            DialogResult result = MessageBox.Show("El registro ha sido eliminado, ¿Desea Restauralo?", "Restauracion de Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Usuarios_Habilitar();
            }
        }
        private void Usuarios_Habilitar()
        {
            clsBEUsuarios Parametros = new clsBEUsuarios();
            clsDACSharp Funcion = new clsDACSharp();
            Parametros.ID_Usuario = IDUsuario;
            if (Funcion.Usuarios_Restaurar(Parametros) == true)
            {
                Usuarios_Mostrar();
            }
        }
        private void Usuarios_Eliminar()
        {
            IDUsuario = Convert.ToInt32(DataListadoUsuarios.SelectedCells[2].Value);
            clsBEUsuarios Parametros = new clsBEUsuarios();
            clsDACSharp Funcion = new clsDACSharp();
            Parametros.ID_Usuario = IDUsuario;
            if (Funcion.tblUsuarios_Eliminar(Parametros) == true)
            {
                Usuarios_Mostrar();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiseñarDataGridViewUsuarios();
            timer1.Stop();
        }

        private void btnGuardarCambiosU_Click(object sender, EventArgs e)
        {
            UsuariosEditar();
        }
        private void UsuariosEditar()
        {
            clsBEUsuarios Parametros = new clsBEUsuarios();
            clsDACSharp Funcion = new clsDACSharp();
            Parametros.ID_Usuario = IDUsuario;
            Parametros.Nombres = txtNombres.Text;
            Parametros.Apellidos = txtApellidos.Text;
            Parametros.Identificacion = txtIdentificacion.Text;
            Parametros.Pais = cbPais.Text;
            Parametros.ID_Profesion = IDProfesion;
            Parametros.Sueldo = Convert.ToDouble(txtSueldoU.Text);
            if (Funcion.tblUsuarios_Editar(Parametros) == true)
            {
                Usuarios_Mostrar();
                PanelRegistrosUP.Visible = false;
            }
        }

        private void btnSiguientePag_Click(object sender, EventArgs e)
        {
            Desde += 10;
            Hasta += 10;
            Usuarios_Mostrar();
            if (Contador > Hasta)
            {
                btnSiguientePag.Visible = true;
                btnAnteriorPag.Visible = true;
            }
            else
            {
                btnSiguientePag.Visible = false;
                btnAnteriorPag.Visible = true;
            }
            Paginar();
        }
        private void Paginar()
        {
            try
            {
                lblPagina.Text = (Hasta / ItemxPagina).ToString();
                lblTotalPaginas.Text = Math.Ceiling(Convert.ToSingle(Contador) / ItemxPagina).ToString();
                TotalPaginas = Convert.ToInt32(lblTotalPaginas.Text);
            }
            catch (Exception)
            {

                Contador=0;
            }
        }
        private void Usuarios_Contar()
        {
            clsDACSharp Funcion = new clsDACSharp();
            Funcion.tblUsuarios_Contar(ref Contador);
        }

        private void btnAnteriorPag_Click(object sender, EventArgs e)
        {
            Desde -= 10;
            Hasta -= 10;
            Usuarios_Mostrar();
            Usuarios_Contar();
            if(Contador > Hasta)
            {
                btnSiguientePag.Visible = true;
                btnAnteriorPag.Visible = true;
            }
            else
            {
                btnAnteriorPag.Visible = true;
                btnSiguientePag.Visible = false;
            }
            if (Desde == 1)
            {
                Reiniciar_Paginado();
            }
            Paginar();
        }

        private void btnUltimaPag_Click(object sender, EventArgs e)
        {
            Hasta = TotalPaginas * ItemxPagina;
            Desde = Hasta - 9;
            Usuarios_Mostrar();
            Usuarios_Contar();
            if (Contador > Hasta)
            {
                btnSiguientePag.Visible = true;
                btnAnteriorPag.Visible = true;
            }
            else
            {
                btnAnteriorPag.Visible = true;
                btnSiguientePag.Visible = false;
            }
            Paginar();
        }

        private void btnPrimeraPag_Click(object sender, EventArgs e)
        {
            Reiniciar_Paginado();
            Usuarios_Mostrar();
        }
        private void LimpiarUsuarios()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtIdentificacion.Clear();
            txtProfesionU.Clear();
            txtSueldoU.Clear();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsDACSharp Funcion = new clsDACSharp();
            Funcion.tblUsuarios_Buscar(ref dt, Desde, Hasta, txtBuscador.Text);
            DataListadoUsuarios.DataSource = dt;
            Bases.DiseñoDataGridView(ref DataListadoUsuarios);
        }
    }
}
