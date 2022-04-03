
namespace ProyectoCSharp
{
    partial class FormCSharp
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCSharp));
            this.PanelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.lblIcono = new System.Windows.Forms.Label();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenuPrincipal
            // 
            this.PanelMenuPrincipal.Controls.Add(this.btnPersonal);
            this.PanelMenuPrincipal.Controls.Add(this.lblIcono);
            this.PanelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuPrincipal.Name = "PanelMenuPrincipal";
            this.PanelMenuPrincipal.Size = new System.Drawing.Size(153, 501);
            this.PanelMenuPrincipal.TabIndex = 0;
            // 
            // btnPersonal
            // 
            this.btnPersonal.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonal.Image")));
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonal.Location = new System.Drawing.Point(15, 130);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(106, 50);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // lblIcono
            // 
            this.lblIcono.Image = ((System.Drawing.Image)(resources.GetObject("lblIcono.Image")));
            this.lblIcono.Location = new System.Drawing.Point(12, 9);
            this.lblIcono.Name = "lblIcono";
            this.lblIcono.Size = new System.Drawing.Size(122, 80);
            this.lblIcono.TabIndex = 0;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Location = new System.Drawing.Point(168, 12);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(702, 477);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // FormCSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 501);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelMenuPrincipal);
            this.Name = "FormCSharp";
            this.Text = "ProyectoCSharp";
            this.PanelMenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuPrincipal;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Panel PanelPrincipal;
    }
}

