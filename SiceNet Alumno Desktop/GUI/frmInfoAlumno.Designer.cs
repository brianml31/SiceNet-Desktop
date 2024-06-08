namespace GUI
{
    partial class frmInfoAlumno
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblNoControl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreAlumno = new MaterialSkin.Controls.MaterialLabel();
            this.lblBienvenido = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblITSUR = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblFechaHora = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lblSemestreActual = new MaterialSkin.Controls.MaterialLabel();
            this.lblCreditosActuales = new MaterialSkin.Controls.MaterialLabel();
            this.lblCreditosReunidos = new MaterialSkin.Controls.MaterialLabel();
            this.lblEspecialidad = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblNoControl);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.lblNombreAlumno);
            this.materialCard1.Controls.Add(this.lblBienvenido);
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.lblITSUR);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(555, 125);
            this.materialCard1.TabIndex = 0;
            // 
            // lblNoControl
            // 
            this.lblNoControl.AutoSize = true;
            this.lblNoControl.Depth = 0;
            this.lblNoControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNoControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblNoControl.Location = new System.Drawing.Point(266, 94);
            this.lblNoControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoControl.Name = "lblNoControl";
            this.lblNoControl.Size = new System.Drawing.Size(73, 17);
            this.lblNoControl.TabIndex = 4;
            this.lblNoControl.Text = "000000000";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel5.Location = new System.Drawing.Point(177, 94);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(80, 17);
            this.materialLabel5.TabIndex = 3;
            this.materialLabel5.Text = "No. Control: ";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Depth = 0;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreAlumno.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblNombreAlumno.Location = new System.Drawing.Point(176, 55);
            this.lblNombreAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(181, 24);
            this.lblNombreAlumno.TabIndex = 3;
            this.lblNombreAlumno.Text = "[NOMBRE ALUMNO]";
            this.lblNombreAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Depth = 0;
            this.lblBienvenido.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBienvenido.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblBienvenido.Location = new System.Drawing.Point(264, 16);
            this.lblBienvenido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(149, 29);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Bienvenido(a)";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo_itsur;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblITSUR
            // 
            this.lblITSUR.AutoSize = true;
            this.lblITSUR.Font = new System.Drawing.Font("Arial", 16.75F);
            this.lblITSUR.Location = new System.Drawing.Point(175, 34);
            this.lblITSUR.Name = "lblITSUR";
            this.lblITSUR.Size = new System.Drawing.Size(0, 26);
            this.lblITSUR.TabIndex = 0;
            this.lblITSUR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblFechaHora);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 212);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(555, 75);
            this.materialCard2.TabIndex = 1;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Depth = 0;
            this.lblFechaHora.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaHora.Location = new System.Drawing.Point(212, 43);
            this.lblFechaHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(131, 19);
            this.lblFechaHora.TabIndex = 1;
            this.lblFechaHora.Text = "00/00/0000|00:00";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(176, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(201, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Fecha de reinscripcion";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Depth = 0;
            this.lbl1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbl1.Location = new System.Drawing.Point(42, 47);
            this.lbl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(87, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Especialidad:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Depth = 0;
            this.lbl2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbl2.Location = new System.Drawing.Point(28, 76);
            this.lbl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(101, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Cdts. Reunidos:";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lblSemestreActual);
            this.materialCard3.Controls.Add(this.lblCreditosActuales);
            this.materialCard3.Controls.Add(this.lblCreditosReunidos);
            this.materialCard3.Controls.Add(this.lblEspecialidad);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.materialLabel1);
            this.materialCard3.Controls.Add(this.materialLabel4);
            this.materialCard3.Controls.Add(this.lbl2);
            this.materialCard3.Controls.Add(this.lbl1);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(17, 299);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(555, 168);
            this.materialCard3.TabIndex = 3;
            // 
            // lblSemestreActual
            // 
            this.lblSemestreActual.AutoSize = true;
            this.lblSemestreActual.Depth = 0;
            this.lblSemestreActual.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSemestreActual.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblSemestreActual.Location = new System.Drawing.Point(145, 132);
            this.lblSemestreActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSemestreActual.Name = "lblSemestreActual";
            this.lblSemestreActual.Size = new System.Drawing.Size(46, 17);
            this.lblSemestreActual.TabIndex = 8;
            this.lblSemestreActual.Text = "#####";
            // 
            // lblCreditosActuales
            // 
            this.lblCreditosActuales.AutoSize = true;
            this.lblCreditosActuales.Depth = 0;
            this.lblCreditosActuales.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCreditosActuales.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblCreditosActuales.Location = new System.Drawing.Point(145, 104);
            this.lblCreditosActuales.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCreditosActuales.Name = "lblCreditosActuales";
            this.lblCreditosActuales.Size = new System.Drawing.Size(46, 17);
            this.lblCreditosActuales.TabIndex = 7;
            this.lblCreditosActuales.Text = "#####";
            // 
            // lblCreditosReunidos
            // 
            this.lblCreditosReunidos.AutoSize = true;
            this.lblCreditosReunidos.Depth = 0;
            this.lblCreditosReunidos.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCreditosReunidos.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblCreditosReunidos.Location = new System.Drawing.Point(145, 76);
            this.lblCreditosReunidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCreditosReunidos.Name = "lblCreditosReunidos";
            this.lblCreditosReunidos.Size = new System.Drawing.Size(46, 17);
            this.lblCreditosReunidos.TabIndex = 6;
            this.lblCreditosReunidos.Text = "#####";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Depth = 0;
            this.lblEspecialidad.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblEspecialidad.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblEspecialidad.Location = new System.Drawing.Point(145, 47);
            this.lblEspecialidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(46, 17);
            this.lblEspecialidad.TabIndex = 5;
            this.lblEspecialidad.Text = "#####";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.Location = new System.Drawing.Point(48, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(81, 17);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Sem. Actual:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(32, 104);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 17);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Cdts. Actuales:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(198, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(170, 24);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Estatus academico";
            // 
            // frmInfoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 475);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmInfoAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiceNet Alumno Desktop";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label lblITSUR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblBienvenido;
        private MaterialSkin.Controls.MaterialLabel lblNombreAlumno;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lbl1;
        private MaterialSkin.Controls.MaterialLabel lbl2;
        private MaterialSkin.Controls.MaterialLabel lblFechaHora;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel lblNoControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblSemestreActual;
        private MaterialSkin.Controls.MaterialLabel lblCreditosActuales;
        private MaterialSkin.Controls.MaterialLabel lblCreditosReunidos;
        private MaterialSkin.Controls.MaterialLabel lblEspecialidad;
    }
}

