namespace ProyectoFinal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.btnInfo = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnConsultarInformacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarCalificacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRegistrarCalificacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblNombrePrograma = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.lblNombrePrograma);
            this.PanelTop.Controls.Add(this.btnSalir);
            this.PanelTop.Controls.Add(this.pictureBox1);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1419, 59);
            this.PanelTop.TabIndex = 0;
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.btnInfo);
            this.PanelBotones.Controls.Add(this.btnConsultarInformacion);
            this.PanelBotones.Controls.Add(this.btnModificarCalificacion);
            this.PanelBotones.Controls.Add(this.btnRegistrarCalificacion);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBotones.Location = new System.Drawing.Point(0, 59);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(1419, 60);
            this.PanelBotones.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageActive = null;
            this.btnInfo.Location = new System.Drawing.Point(1348, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(71, 60);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnInfo.TabIndex = 3;
            this.btnInfo.TabStop = false;
            this.btnInfo.Zoom = 20;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnConsultarInformacion
            // 
            this.btnConsultarInformacion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConsultarInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(137)))));
            this.btnConsultarInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarInformacion.BorderRadius = 0;
            this.btnConsultarInformacion.ButtonText = "Consultar Información";
            this.btnConsultarInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarInformacion.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultarInformacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultarInformacion.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarInformacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultarInformacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConsultarInformacion.Iconimage")));
            this.btnConsultarInformacion.Iconimage_right = null;
            this.btnConsultarInformacion.Iconimage_right_Selected = null;
            this.btnConsultarInformacion.Iconimage_Selected = null;
            this.btnConsultarInformacion.IconMarginLeft = 0;
            this.btnConsultarInformacion.IconMarginRight = 0;
            this.btnConsultarInformacion.IconRightVisible = true;
            this.btnConsultarInformacion.IconRightZoom = 0D;
            this.btnConsultarInformacion.IconVisible = true;
            this.btnConsultarInformacion.IconZoom = 60D;
            this.btnConsultarInformacion.IsTab = false;
            this.btnConsultarInformacion.Location = new System.Drawing.Point(918, 0);
            this.btnConsultarInformacion.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnConsultarInformacion.Name = "btnConsultarInformacion";
            this.btnConsultarInformacion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(137)))));
            this.btnConsultarInformacion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.btnConsultarInformacion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsultarInformacion.selected = false;
            this.btnConsultarInformacion.Size = new System.Drawing.Size(796, 60);
            this.btnConsultarInformacion.TabIndex = 2;
            this.btnConsultarInformacion.Text = "Consultar Información";
            this.btnConsultarInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarInformacion.Textcolor = System.Drawing.Color.White;
            this.btnConsultarInformacion.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarInformacion.Click += new System.EventHandler(this.btnConsultarInformacion_Click);
            // 
            // btnModificarCalificacion
            // 
            this.btnModificarCalificacion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModificarCalificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(137)))));
            this.btnModificarCalificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCalificacion.BorderRadius = 0;
            this.btnModificarCalificacion.ButtonText = "Modificar Calificación";
            this.btnModificarCalificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCalificacion.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificarCalificacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificarCalificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCalificacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarCalificacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificarCalificacion.Iconimage")));
            this.btnModificarCalificacion.Iconimage_right = null;
            this.btnModificarCalificacion.Iconimage_right_Selected = null;
            this.btnModificarCalificacion.Iconimage_Selected = null;
            this.btnModificarCalificacion.IconMarginLeft = 0;
            this.btnModificarCalificacion.IconMarginRight = 0;
            this.btnModificarCalificacion.IconRightVisible = true;
            this.btnModificarCalificacion.IconRightZoom = 0D;
            this.btnModificarCalificacion.IconVisible = true;
            this.btnModificarCalificacion.IconZoom = 60D;
            this.btnModificarCalificacion.IsTab = false;
            this.btnModificarCalificacion.Location = new System.Drawing.Point(476, 0);
            this.btnModificarCalificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarCalificacion.Name = "btnModificarCalificacion";
            this.btnModificarCalificacion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(137)))));
            this.btnModificarCalificacion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.btnModificarCalificacion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificarCalificacion.selected = false;
            this.btnModificarCalificacion.Size = new System.Drawing.Size(442, 60);
            this.btnModificarCalificacion.TabIndex = 1;
            this.btnModificarCalificacion.Text = "Modificar Calificación";
            this.btnModificarCalificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCalificacion.Textcolor = System.Drawing.Color.White;
            this.btnModificarCalificacion.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCalificacion.Click += new System.EventHandler(this.btnModificarCalificacion_Click);
            // 
            // btnRegistrarCalificacion
            // 
            this.btnRegistrarCalificacion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegistrarCalificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(137)))));
            this.btnRegistrarCalificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarCalificacion.BorderRadius = 0;
            this.btnRegistrarCalificacion.ButtonText = "Registrar Calificación";
            this.btnRegistrarCalificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCalificacion.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegistrarCalificacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegistrarCalificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCalificacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistrarCalificacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCalificacion.Iconimage")));
            this.btnRegistrarCalificacion.Iconimage_right = null;
            this.btnRegistrarCalificacion.Iconimage_right_Selected = null;
            this.btnRegistrarCalificacion.Iconimage_Selected = null;
            this.btnRegistrarCalificacion.IconMarginLeft = 0;
            this.btnRegistrarCalificacion.IconMarginRight = 0;
            this.btnRegistrarCalificacion.IconRightVisible = true;
            this.btnRegistrarCalificacion.IconRightZoom = 0D;
            this.btnRegistrarCalificacion.IconVisible = true;
            this.btnRegistrarCalificacion.IconZoom = 60D;
            this.btnRegistrarCalificacion.IsTab = false;
            this.btnRegistrarCalificacion.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarCalificacion.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRegistrarCalificacion.Name = "btnRegistrarCalificacion";
            this.btnRegistrarCalificacion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(137)))));
            this.btnRegistrarCalificacion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.btnRegistrarCalificacion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegistrarCalificacion.selected = false;
            this.btnRegistrarCalificacion.Size = new System.Drawing.Size(476, 60);
            this.btnRegistrarCalificacion.TabIndex = 0;
            this.btnRegistrarCalificacion.Text = "Registrar Calificación";
            this.btnRegistrarCalificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCalificacion.Textcolor = System.Drawing.Color.White;
            this.btnRegistrarCalificacion.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCalificacion.Click += new System.EventHandler(this.btnRegistrarCalificacion_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Wheat;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 119);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1419, 662);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(64)))));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(1348, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 59);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 20;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombrePrograma
            // 
            this.lblNombrePrograma.AutoSize = true;
            this.lblNombrePrograma.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePrograma.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombrePrograma.Location = new System.Drawing.Point(86, 18);
            this.lblNombrePrograma.Name = "lblNombrePrograma";
            this.lblNombrePrograma.Size = new System.Drawing.Size(332, 22);
            this.lblNombrePrograma.TabIndex = 5;
            this.lblNombrePrograma.Text = "Reporte de Calificaciones INF-5120\r\n";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 781);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelBotones;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultarInformacion;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificarCalificacion;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistrarCalificacion;
        private Bunifu.Framework.UI.BunifuImageButton btnInfo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.Label lblNombrePrograma;
    }
}

