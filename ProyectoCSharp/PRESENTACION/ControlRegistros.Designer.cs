
namespace ProyectoCSharp.PRESENTACION
{
    partial class ControlRegistros
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlRegistros));
            this.PanelBuscador = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.lblLupa = new System.Windows.Forms.Label();
            this.PanelPaginacion = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrimeraPag = new System.Windows.Forms.Button();
            this.btnUltimaPag = new System.Windows.Forms.Button();
            this.btnAnteriorPag = new System.Windows.Forms.Button();
            this.btnSiguientePag = new System.Windows.Forms.Button();
            this.DataListadoUsuarios = new System.Windows.Forms.DataGridView();
            this.EditarUsuarios = new System.Windows.Forms.DataGridViewImageColumn();
            this.EliminarUsuarios = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.PanelRegistrosUP = new System.Windows.Forms.Panel();
            this.btnProfesionmas = new System.Windows.Forms.Button();
            this.DataListadoProfesiones = new System.Windows.Forms.DataGridView();
            this.EditarProfesiones = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelRegistrosP = new System.Windows.Forms.Panel();
            this.btnVolverP = new System.Windows.Forms.Button();
            this.PanelGuardarP = new System.Windows.Forms.Panel();
            this.btnGuardarCambiosP = new System.Windows.Forms.Button();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.txtProfesionP = new System.Windows.Forms.TextBox();
            this.txtSueldoP = new System.Windows.Forms.TextBox();
            this.lblSueldoP = new System.Windows.Forms.Label();
            this.lblProfesionP = new System.Windows.Forms.Label();
            this.btnVolverU = new System.Windows.Forms.Button();
            this.PanelGuardarU = new System.Windows.Forms.Panel();
            this.btnGuardarCambiosU = new System.Windows.Forms.Button();
            this.btnGuardarU = new System.Windows.Forms.Button();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.txtProfesionU = new System.Windows.Forms.TextBox();
            this.txtSueldoU = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPagina = new System.Windows.Forms.Label();
            this.lblTotalPaginas = new System.Windows.Forms.Label();
            this.PanelBuscador.SuspendLayout();
            this.PanelPaginacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoUsuarios)).BeginInit();
            this.PanelRegistrosUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoProfesiones)).BeginInit();
            this.PanelRegistrosP.SuspendLayout();
            this.PanelGuardarP.SuspendLayout();
            this.PanelGuardarU.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBuscador
            // 
            this.PanelBuscador.Controls.Add(this.btnAgregar);
            this.PanelBuscador.Controls.Add(this.txtBuscador);
            this.PanelBuscador.Controls.Add(this.lblLupa);
            this.PanelBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBuscador.Location = new System.Drawing.Point(0, 0);
            this.PanelBuscador.Name = "PanelBuscador";
            this.PanelBuscador.Size = new System.Drawing.Size(877, 67);
            this.PanelBuscador.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(736, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 61);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(112, 27);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(231, 26);
            this.txtBuscador.TabIndex = 1;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // lblLupa
            // 
            this.lblLupa.Image = ((System.Drawing.Image)(resources.GetObject("lblLupa.Image")));
            this.lblLupa.Location = new System.Drawing.Point(37, 14);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(69, 41);
            this.lblLupa.TabIndex = 0;
            // 
            // PanelPaginacion
            // 
            this.PanelPaginacion.Controls.Add(this.lblTotalPaginas);
            this.PanelPaginacion.Controls.Add(this.lblPagina);
            this.PanelPaginacion.Controls.Add(this.label2);
            this.PanelPaginacion.Controls.Add(this.label1);
            this.PanelPaginacion.Controls.Add(this.btnPrimeraPag);
            this.PanelPaginacion.Controls.Add(this.btnUltimaPag);
            this.PanelPaginacion.Controls.Add(this.btnAnteriorPag);
            this.PanelPaginacion.Controls.Add(this.btnSiguientePag);
            this.PanelPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPaginacion.Location = new System.Drawing.Point(0, 508);
            this.PanelPaginacion.Name = "PanelPaginacion";
            this.PanelPaginacion.Size = new System.Drawing.Size(877, 84);
            this.PanelPaginacion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "De:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Página:";
            // 
            // btnPrimeraPag
            // 
            this.btnPrimeraPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeraPag.Location = new System.Drawing.Point(693, 25);
            this.btnPrimeraPag.Name = "btnPrimeraPag";
            this.btnPrimeraPag.Size = new System.Drawing.Size(112, 40);
            this.btnPrimeraPag.TabIndex = 3;
            this.btnPrimeraPag.Text = "PrimeraPág";
            this.btnPrimeraPag.UseVisualStyleBackColor = true;
            this.btnPrimeraPag.Click += new System.EventHandler(this.btnPrimeraPag_Click);
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaPag.Location = new System.Drawing.Point(554, 22);
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Size = new System.Drawing.Size(112, 40);
            this.btnUltimaPag.TabIndex = 2;
            this.btnUltimaPag.Text = "última Pág";
            this.btnUltimaPag.UseVisualStyleBackColor = true;
            this.btnUltimaPag.Click += new System.EventHandler(this.btnUltimaPag_Click);
            // 
            // btnAnteriorPag
            // 
            this.btnAnteriorPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorPag.Location = new System.Drawing.Point(149, 25);
            this.btnAnteriorPag.Name = "btnAnteriorPag";
            this.btnAnteriorPag.Size = new System.Drawing.Size(116, 40);
            this.btnAnteriorPag.TabIndex = 1;
            this.btnAnteriorPag.Text = "Anterior Pág";
            this.btnAnteriorPag.UseVisualStyleBackColor = true;
            this.btnAnteriorPag.Click += new System.EventHandler(this.btnAnteriorPag_Click);
            // 
            // btnSiguientePag
            // 
            this.btnSiguientePag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguientePag.Location = new System.Drawing.Point(20, 25);
            this.btnSiguientePag.Name = "btnSiguientePag";
            this.btnSiguientePag.Size = new System.Drawing.Size(123, 40);
            this.btnSiguientePag.TabIndex = 0;
            this.btnSiguientePag.Text = "Siguiente Pág";
            this.btnSiguientePag.UseVisualStyleBackColor = true;
            this.btnSiguientePag.Click += new System.EventHandler(this.btnSiguientePag_Click);
            // 
            // DataListadoUsuarios
            // 
            this.DataListadoUsuarios.AllowUserToAddRows = false;
            this.DataListadoUsuarios.AllowUserToDeleteRows = false;
            this.DataListadoUsuarios.AllowUserToResizeColumns = false;
            this.DataListadoUsuarios.AllowUserToResizeRows = false;
            this.DataListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListadoUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarUsuarios,
            this.EliminarUsuarios});
            this.DataListadoUsuarios.Location = new System.Drawing.Point(20, 84);
            this.DataListadoUsuarios.Name = "DataListadoUsuarios";
            this.DataListadoUsuarios.ReadOnly = true;
            this.DataListadoUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListadoUsuarios.Size = new System.Drawing.Size(841, 403);
            this.DataListadoUsuarios.TabIndex = 2;
            this.DataListadoUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListadoUsuarios_CellClick);
            // 
            // EditarUsuarios
            // 
            this.EditarUsuarios.HeaderText = "";
            this.EditarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("EditarUsuarios.Image")));
            this.EditarUsuarios.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarUsuarios.Name = "EditarUsuarios";
            this.EditarUsuarios.ReadOnly = true;
            // 
            // EliminarUsuarios
            // 
            this.EliminarUsuarios.HeaderText = "";
            this.EliminarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("EliminarUsuarios.Image")));
            this.EliminarUsuarios.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EliminarUsuarios.Name = "EliminarUsuarios";
            this.EliminarUsuarios.ReadOnly = true;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(29, 43);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(78, 16);
            this.lblApellidos.TabIndex = 0;
            this.lblApellidos.Text = "Apellidos;";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(35, 9);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(75, 16);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesion.Location = new System.Drawing.Point(32, 128);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(78, 16);
            this.lblProfesion.TabIndex = 4;
            this.lblProfesion.Text = "Profesion:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(64, 101);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(43, 16);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "País:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(3, 72);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(104, 16);
            this.lblIdentificacion.TabIndex = 6;
            this.lblIdentificacion.Text = "Identificacion:";
            // 
            // PanelRegistrosUP
            // 
            this.PanelRegistrosUP.Controls.Add(this.btnProfesionmas);
            this.PanelRegistrosUP.Controls.Add(this.DataListadoProfesiones);
            this.PanelRegistrosUP.Controls.Add(this.PanelRegistrosP);
            this.PanelRegistrosUP.Controls.Add(this.btnVolverU);
            this.PanelRegistrosUP.Controls.Add(this.PanelGuardarU);
            this.PanelRegistrosUP.Controls.Add(this.cbPais);
            this.PanelRegistrosUP.Controls.Add(this.txtProfesionU);
            this.PanelRegistrosUP.Controls.Add(this.txtSueldoU);
            this.PanelRegistrosUP.Controls.Add(this.txtIdentificacion);
            this.PanelRegistrosUP.Controls.Add(this.txtApellidos);
            this.PanelRegistrosUP.Controls.Add(this.txtNombres);
            this.PanelRegistrosUP.Controls.Add(this.lblSueldo);
            this.PanelRegistrosUP.Controls.Add(this.lblIdentificacion);
            this.PanelRegistrosUP.Controls.Add(this.lblPais);
            this.PanelRegistrosUP.Controls.Add(this.lblProfesion);
            this.PanelRegistrosUP.Controls.Add(this.label3);
            this.PanelRegistrosUP.Controls.Add(this.lblNombres);
            this.PanelRegistrosUP.Controls.Add(this.lblApellidos);
            this.PanelRegistrosUP.Location = new System.Drawing.Point(32, 99);
            this.PanelRegistrosUP.Name = "PanelRegistrosUP";
            this.PanelRegistrosUP.Size = new System.Drawing.Size(816, 376);
            this.PanelRegistrosUP.TabIndex = 3;
            // 
            // btnProfesionmas
            // 
            this.btnProfesionmas.Location = new System.Drawing.Point(240, 118);
            this.btnProfesionmas.Name = "btnProfesionmas";
            this.btnProfesionmas.Size = new System.Drawing.Size(85, 37);
            this.btnProfesionmas.TabIndex = 19;
            this.btnProfesionmas.Text = "Profesion+";
            this.btnProfesionmas.UseVisualStyleBackColor = true;
            this.btnProfesionmas.Click += new System.EventHandler(this.btnProfesionmas_Click);
            // 
            // DataListadoProfesiones
            // 
            this.DataListadoProfesiones.AllowUserToAddRows = false;
            this.DataListadoProfesiones.AllowUserToDeleteRows = false;
            this.DataListadoProfesiones.AllowUserToResizeColumns = false;
            this.DataListadoProfesiones.AllowUserToResizeRows = false;
            this.DataListadoProfesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListadoProfesiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarProfesiones});
            this.DataListadoProfesiones.Location = new System.Drawing.Point(117, 184);
            this.DataListadoProfesiones.Name = "DataListadoProfesiones";
            this.DataListadoProfesiones.ReadOnly = true;
            this.DataListadoProfesiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListadoProfesiones.Size = new System.Drawing.Size(270, 111);
            this.DataListadoProfesiones.TabIndex = 18;
            this.DataListadoProfesiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListadoProfesiones_CellClick);
            // 
            // EditarProfesiones
            // 
            this.EditarProfesiones.HeaderText = "";
            this.EditarProfesiones.Image = ((System.Drawing.Image)(resources.GetObject("EditarProfesiones.Image")));
            this.EditarProfesiones.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarProfesiones.Name = "EditarProfesiones";
            this.EditarProfesiones.ReadOnly = true;
            // 
            // PanelRegistrosP
            // 
            this.PanelRegistrosP.Controls.Add(this.btnVolverP);
            this.PanelRegistrosP.Controls.Add(this.PanelGuardarP);
            this.PanelRegistrosP.Controls.Add(this.txtProfesionP);
            this.PanelRegistrosP.Controls.Add(this.txtSueldoP);
            this.PanelRegistrosP.Controls.Add(this.lblSueldoP);
            this.PanelRegistrosP.Controls.Add(this.lblProfesionP);
            this.PanelRegistrosP.Location = new System.Drawing.Point(431, 20);
            this.PanelRegistrosP.Name = "PanelRegistrosP";
            this.PanelRegistrosP.Size = new System.Drawing.Size(368, 158);
            this.PanelRegistrosP.TabIndex = 17;
            // 
            // btnVolverP
            // 
            this.btnVolverP.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverP.Image")));
            this.btnVolverP.Location = new System.Drawing.Point(256, 23);
            this.btnVolverP.Name = "btnVolverP";
            this.btnVolverP.Size = new System.Drawing.Size(86, 48);
            this.btnVolverP.TabIndex = 19;
            this.btnVolverP.UseVisualStyleBackColor = true;
            this.btnVolverP.Click += new System.EventHandler(this.btnVolverP_Click);
            // 
            // PanelGuardarP
            // 
            this.PanelGuardarP.Controls.Add(this.btnGuardarCambiosP);
            this.PanelGuardarP.Controls.Add(this.btnGuardarP);
            this.PanelGuardarP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelGuardarP.Location = new System.Drawing.Point(0, 98);
            this.PanelGuardarP.Name = "PanelGuardarP";
            this.PanelGuardarP.Size = new System.Drawing.Size(368, 60);
            this.PanelGuardarP.TabIndex = 18;
            // 
            // btnGuardarCambiosP
            // 
            this.btnGuardarCambiosP.Location = new System.Drawing.Point(177, 16);
            this.btnGuardarCambiosP.Name = "btnGuardarCambiosP";
            this.btnGuardarCambiosP.Size = new System.Drawing.Size(110, 36);
            this.btnGuardarCambiosP.TabIndex = 1;
            this.btnGuardarCambiosP.Text = "Guardar Cambios";
            this.btnGuardarCambiosP.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosP.Click += new System.EventHandler(this.btnGuardarCambiosP_Click);
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Location = new System.Drawing.Point(18, 16);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(117, 36);
            this.btnGuardarP.TabIndex = 0;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // txtProfesionP
            // 
            this.txtProfesionP.Location = new System.Drawing.Point(106, 25);
            this.txtProfesionP.Name = "txtProfesionP";
            this.txtProfesionP.Size = new System.Drawing.Size(116, 20);
            this.txtProfesionP.TabIndex = 17;
            // 
            // txtSueldoP
            // 
            this.txtSueldoP.Location = new System.Drawing.Point(105, 51);
            this.txtSueldoP.Name = "txtSueldoP";
            this.txtSueldoP.Size = new System.Drawing.Size(117, 20);
            this.txtSueldoP.TabIndex = 16;
            // 
            // lblSueldoP
            // 
            this.lblSueldoP.AutoSize = true;
            this.lblSueldoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoP.Location = new System.Drawing.Point(30, 55);
            this.lblSueldoP.Name = "lblSueldoP";
            this.lblSueldoP.Size = new System.Drawing.Size(61, 16);
            this.lblSueldoP.TabIndex = 15;
            this.lblSueldoP.Text = "Sueldo:";
            // 
            // lblProfesionP
            // 
            this.lblProfesionP.AutoSize = true;
            this.lblProfesionP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesionP.Location = new System.Drawing.Point(21, 28);
            this.lblProfesionP.Name = "lblProfesionP";
            this.lblProfesionP.Size = new System.Drawing.Size(78, 16);
            this.lblProfesionP.TabIndex = 14;
            this.lblProfesionP.Text = "Profesion:";
            // 
            // btnVolverU
            // 
            this.btnVolverU.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverU.Image")));
            this.btnVolverU.Location = new System.Drawing.Point(239, 65);
            this.btnVolverU.Name = "btnVolverU";
            this.btnVolverU.Size = new System.Drawing.Size(86, 44);
            this.btnVolverU.TabIndex = 16;
            this.btnVolverU.UseVisualStyleBackColor = true;
            this.btnVolverU.Click += new System.EventHandler(this.btnVolverU_Click);
            // 
            // PanelGuardarU
            // 
            this.PanelGuardarU.Controls.Add(this.btnGuardarCambiosU);
            this.PanelGuardarU.Controls.Add(this.btnGuardarU);
            this.PanelGuardarU.Location = new System.Drawing.Point(9, 301);
            this.PanelGuardarU.Name = "PanelGuardarU";
            this.PanelGuardarU.Size = new System.Drawing.Size(316, 60);
            this.PanelGuardarU.TabIndex = 15;
            // 
            // btnGuardarCambiosU
            // 
            this.btnGuardarCambiosU.Location = new System.Drawing.Point(177, 16);
            this.btnGuardarCambiosU.Name = "btnGuardarCambiosU";
            this.btnGuardarCambiosU.Size = new System.Drawing.Size(110, 36);
            this.btnGuardarCambiosU.TabIndex = 1;
            this.btnGuardarCambiosU.Text = "Guardar Cambios";
            this.btnGuardarCambiosU.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosU.Click += new System.EventHandler(this.btnGuardarCambiosU_Click);
            // 
            // btnGuardarU
            // 
            this.btnGuardarU.Location = new System.Drawing.Point(18, 16);
            this.btnGuardarU.Name = "btnGuardarU";
            this.btnGuardarU.Size = new System.Drawing.Size(117, 36);
            this.btnGuardarU.TabIndex = 0;
            this.btnGuardarU.Text = "Guardar";
            this.btnGuardarU.UseVisualStyleBackColor = true;
            this.btnGuardarU.Click += new System.EventHandler(this.btnGuardarU_Click);
            // 
            // cbPais
            // 
            this.cbPais.AutoCompleteCustomSource.AddRange(new string[] {
            "Colombia",
            "Venezuela",
            "España",
            "Francia",
            "Ecuador",
            "Honduras",
            "Inglaterra",
            "Rusia",
            "Ucrania",
            "Perú",
            "Salvador",
            "Estados Unidos",
            "China",
            "Japón"});
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "Colombia",
            "Argentina",
            "Venezuela",
            "Ecuador",
            "España",
            "Francia",
            "Mexico",
            "Alemania",
            "Brasil"});
            this.cbPais.Location = new System.Drawing.Point(117, 96);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(116, 21);
            this.cbPais.TabIndex = 14;
            // 
            // txtProfesionU
            // 
            this.txtProfesionU.Location = new System.Drawing.Point(117, 123);
            this.txtProfesionU.Name = "txtProfesionU";
            this.txtProfesionU.Size = new System.Drawing.Size(116, 20);
            this.txtProfesionU.TabIndex = 13;
            this.txtProfesionU.TextChanged += new System.EventHandler(this.txtProfesionU_TextChanged);
            // 
            // txtSueldoU
            // 
            this.txtSueldoU.Location = new System.Drawing.Point(116, 158);
            this.txtSueldoU.Name = "txtSueldoU";
            this.txtSueldoU.Size = new System.Drawing.Size(117, 20);
            this.txtSueldoU.TabIndex = 12;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(117, 65);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(116, 20);
            this.txtIdentificacion.TabIndex = 10;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(117, 39);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(208, 20);
            this.txtApellidos.TabIndex = 9;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(117, 8);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(208, 20);
            this.txtNombres.TabIndex = 8;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(41, 162);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(61, 16);
            this.lblSueldo.TabIndex = 7;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(396, 28);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(13, 13);
            this.lblPagina.TabIndex = 6;
            this.lblPagina.Text = "0";
            // 
            // lblTotalPaginas
            // 
            this.lblTotalPaginas.AutoSize = true;
            this.lblTotalPaginas.Location = new System.Drawing.Point(511, 28);
            this.lblTotalPaginas.Name = "lblTotalPaginas";
            this.lblTotalPaginas.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPaginas.TabIndex = 7;
            this.lblTotalPaginas.Text = "0";
            // 
            // ControlRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelRegistrosUP);
            this.Controls.Add(this.DataListadoUsuarios);
            this.Controls.Add(this.PanelPaginacion);
            this.Controls.Add(this.PanelBuscador);
            this.Name = "ControlRegistros";
            this.Size = new System.Drawing.Size(877, 592);
            this.Load += new System.EventHandler(this.ControlRegistros_Load);
            this.PanelBuscador.ResumeLayout(false);
            this.PanelBuscador.PerformLayout();
            this.PanelPaginacion.ResumeLayout(false);
            this.PanelPaginacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoUsuarios)).EndInit();
            this.PanelRegistrosUP.ResumeLayout(false);
            this.PanelRegistrosUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListadoProfesiones)).EndInit();
            this.PanelRegistrosP.ResumeLayout(false);
            this.PanelRegistrosP.PerformLayout();
            this.PanelGuardarP.ResumeLayout(false);
            this.PanelGuardarU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBuscador;
        private System.Windows.Forms.Panel PanelPaginacion;
        private System.Windows.Forms.DataGridView DataListadoUsuarios;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Panel PanelRegistrosUP;
        private System.Windows.Forms.Button btnVolverU;
        private System.Windows.Forms.Panel PanelGuardarU;
        private System.Windows.Forms.Button btnGuardarCambiosU;
        private System.Windows.Forms.Button btnGuardarU;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.TextBox txtProfesionU;
        private System.Windows.Forms.TextBox txtSueldoU;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Panel PanelRegistrosP;
        private System.Windows.Forms.Button btnVolverP;
        private System.Windows.Forms.Panel PanelGuardarP;
        private System.Windows.Forms.Button btnGuardarCambiosP;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.TextBox txtProfesionP;
        private System.Windows.Forms.TextBox txtSueldoP;
        private System.Windows.Forms.Label lblSueldoP;
        private System.Windows.Forms.Label lblProfesionP;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label lblLupa;
        private System.Windows.Forms.DataGridView DataListadoProfesiones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrimeraPag;
        private System.Windows.Forms.Button btnUltimaPag;
        private System.Windows.Forms.Button btnAnteriorPag;
        private System.Windows.Forms.Button btnSiguientePag;
        private System.Windows.Forms.Button btnProfesionmas;
        private System.Windows.Forms.DataGridViewImageColumn EditarProfesiones;
        private System.Windows.Forms.DataGridViewImageColumn EditarUsuarios;
        private System.Windows.Forms.DataGridViewImageColumn EliminarUsuarios;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTotalPaginas;
        private System.Windows.Forms.Label lblPagina;
    }
}
