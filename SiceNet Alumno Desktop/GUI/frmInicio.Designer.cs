namespace GUI
{
    partial class frmInicio
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
            this.TabsControlDrawer = new MaterialSkin.Controls.MaterialTabControl();
            this.tabInfoAlumno = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lblSemestreActual = new MaterialSkin.Controls.MaterialLabel();
            this.lblCreditosActuales = new MaterialSkin.Controls.MaterialLabel();
            this.lblCreditosReunidos = new MaterialSkin.Controls.MaterialLabel();
            this.lblEspecialidad = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_7 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblFechaHora = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbl_2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNoControl = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreAlumno = new MaterialSkin.Controls.MaterialLabel();
            this.lblBienvenido = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblITSUR = new System.Windows.Forms.Label();
            this.tabCardex = new System.Windows.Forms.TabPage();
            this.lblCarrera = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.lblCardex = new MaterialSkin.Controls.MaterialLabel();
            this.btnGenerarCardex = new MaterialSkin.Controls.MaterialButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.TabsControlDrawer.SuspendLayout();
            this.tabInfoAlumno.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCardex.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabsControlDrawer
            // 
            this.TabsControlDrawer.Controls.Add(this.tabInfoAlumno);
            this.TabsControlDrawer.Controls.Add(this.tabCardex);
            this.TabsControlDrawer.Depth = 0;
            this.TabsControlDrawer.Location = new System.Drawing.Point(7, 68);
            this.TabsControlDrawer.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabsControlDrawer.Multiline = true;
            this.TabsControlDrawer.Name = "TabsControlDrawer";
            this.TabsControlDrawer.SelectedIndex = 0;
            this.TabsControlDrawer.Size = new System.Drawing.Size(732, 477);
            this.TabsControlDrawer.TabIndex = 0;
            this.TabsControlDrawer.SelectedIndexChanged += new System.EventHandler(this.TabsControlDrawer_SelectedIndexChanged);
            // 
            // tabInfoAlumno
            // 
            this.tabInfoAlumno.Controls.Add(this.materialCard3);
            this.tabInfoAlumno.Controls.Add(this.materialCard2);
            this.tabInfoAlumno.Controls.Add(this.materialCard1);
            this.tabInfoAlumno.Location = new System.Drawing.Point(4, 22);
            this.tabInfoAlumno.Name = "tabInfoAlumno";
            this.tabInfoAlumno.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoAlumno.Size = new System.Drawing.Size(724, 451);
            this.tabInfoAlumno.TabIndex = 0;
            this.tabInfoAlumno.Text = "InfoAlumno";
            this.tabInfoAlumno.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lblSemestreActual);
            this.materialCard3.Controls.Add(this.lblCreditosActuales);
            this.materialCard3.Controls.Add(this.lblCreditosReunidos);
            this.materialCard3.Controls.Add(this.lblEspecialidad);
            this.materialCard3.Controls.Add(this.lbl_7);
            this.materialCard3.Controls.Add(this.lbl_6);
            this.materialCard3.Controls.Add(this.materialLabel4);
            this.materialCard3.Controls.Add(this.lbl_5);
            this.materialCard3.Controls.Add(this.lbl_4);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(14, 276);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(703, 168);
            this.materialCard3.TabIndex = 4;
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
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.Depth = 0;
            this.lbl_7.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbl_7.Location = new System.Drawing.Point(48, 132);
            this.lbl_7.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(81, 17);
            this.lbl_7.TabIndex = 4;
            this.lbl_7.Text = "Sem. Actual:";
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.Depth = 0;
            this.lbl_6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbl_6.Location = new System.Drawing.Point(32, 104);
            this.lbl_6.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(97, 17);
            this.lbl_6.TabIndex = 3;
            this.lbl_6.Text = "Cdts. Actuales:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(272, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(170, 24);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Estatus academico";
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Depth = 0;
            this.lbl_5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbl_5.Location = new System.Drawing.Point(28, 76);
            this.lbl_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(101, 17);
            this.lbl_5.TabIndex = 2;
            this.lbl_5.Text = "Cdts. Reunidos:";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Depth = 0;
            this.lbl_4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbl_4.Location = new System.Drawing.Point(42, 47);
            this.lbl_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(87, 17);
            this.lbl_4.TabIndex = 0;
            this.lbl_4.Text = "Especialidad:";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblFechaHora);
            this.materialCard2.Controls.Add(this.lbl_3);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 188);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(703, 75);
            this.materialCard2.TabIndex = 2;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Depth = 0;
            this.lblFechaHora.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaHora.Location = new System.Drawing.Point(298, 42);
            this.lblFechaHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(131, 19);
            this.lblFechaHora.TabIndex = 1;
            this.lblFechaHora.Text = "00/00/0000|00:00";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Depth = 0;
            this.lbl_3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_3.Location = new System.Drawing.Point(259, 14);
            this.lbl_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(201, 24);
            this.lbl_3.TabIndex = 0;
            this.lbl_3.Text = "Fecha de reinscripcion";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblCarrera);
            this.materialCard1.Controls.Add(this.lbl_2);
            this.materialCard1.Controls.Add(this.lblNoControl);
            this.materialCard1.Controls.Add(this.lbl_1);
            this.materialCard1.Controls.Add(this.lblNombreAlumno);
            this.materialCard1.Controls.Add(this.lblBienvenido);
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.lblITSUR);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(703, 163);
            this.materialCard1.TabIndex = 1;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Depth = 0;
            this.lbl_2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbl_2.Location = new System.Drawing.Point(219, 120);
            this.lbl_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(56, 17);
            this.lbl_2.TabIndex = 5;
            this.lbl_2.Text = "Carrera: ";
            // 
            // lblNoControl
            // 
            this.lblNoControl.AutoSize = true;
            this.lblNoControl.Depth = 0;
            this.lblNoControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNoControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblNoControl.Location = new System.Drawing.Point(308, 91);
            this.lblNoControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoControl.Name = "lblNoControl";
            this.lblNoControl.Size = new System.Drawing.Size(73, 17);
            this.lblNoControl.TabIndex = 4;
            this.lblNoControl.Text = "000000000";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Depth = 0;
            this.lbl_1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbl_1.Location = new System.Drawing.Point(219, 91);
            this.lbl_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(80, 17);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "No. Control: ";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Depth = 0;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreAlumno.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblNombreAlumno.Location = new System.Drawing.Point(218, 52);
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
            this.lblBienvenido.Location = new System.Drawing.Point(321, 13);
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
            this.pictureBox1.Size = new System.Drawing.Size(136, 130);
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
            // tabCardex
            // 
            this.tabCardex.Controls.Add(this.materialListView1);
            this.tabCardex.Controls.Add(this.materialCard4);
            this.tabCardex.Location = new System.Drawing.Point(4, 22);
            this.tabCardex.Name = "tabCardex";
            this.tabCardex.Padding = new System.Windows.Forms.Padding(3);
            this.tabCardex.Size = new System.Drawing.Size(724, 451);
            this.tabCardex.TabIndex = 1;
            this.tabCardex.Text = "Cardex";
            this.tabCardex.UseVisualStyleBackColor = true;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Depth = 0;
            this.lblCarrera.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCarrera.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblCarrera.Location = new System.Drawing.Point(281, 120);
            this.lblCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(46, 17);
            this.lblCarrera.TabIndex = 6;
            this.lblCarrera.Text = "#####";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.btnGenerarCardex);
            this.materialCard4.Controls.Add(this.lblCardex);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(14, 14);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(696, 107);
            this.materialCard4.TabIndex = 0;
            // 
            // lblCardex
            // 
            this.lblCardex.AutoSize = true;
            this.lblCardex.Depth = 0;
            this.lblCardex.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCardex.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblCardex.Location = new System.Drawing.Point(288, 10);
            this.lblCardex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCardex.Name = "lblCardex";
            this.lblCardex.Size = new System.Drawing.Size(108, 41);
            this.lblCardex.TabIndex = 0;
            this.lblCardex.Text = "Cardex";
            // 
            // btnGenerarCardex
            // 
            this.btnGenerarCardex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarCardex.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerarCardex.Depth = 0;
            this.btnGenerarCardex.HighEmphasis = true;
            this.btnGenerarCardex.Icon = null;
            this.btnGenerarCardex.Location = new System.Drawing.Point(255, 61);
            this.btnGenerarCardex.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerarCardex.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarCardex.Name = "btnGenerarCardex";
            this.btnGenerarCardex.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerarCardex.Size = new System.Drawing.Size(177, 36);
            this.btnGenerarCardex.TabIndex = 1;
            this.btnGenerarCardex.Text = "Generar cardex PDF";
            this.btnGenerarCardex.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerarCardex.UseAccentColor = false;
            this.btnGenerarCardex.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(14, 129);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(200, 100);
            this.materialListView1.TabIndex = 1;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 551);
            this.Controls.Add(this.TabsControlDrawer);
            this.DrawerTabControl = this.TabsControlDrawer;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiceNet Alumno Desktop";
            this.TabsControlDrawer.ResumeLayout(false);
            this.tabInfoAlumno.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCardex.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabsControlDrawer;
        private System.Windows.Forms.TabPage tabInfoAlumno;
        private System.Windows.Forms.TabPage tabCardex;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblNoControl;
        private MaterialSkin.Controls.MaterialLabel lbl_1;
        private MaterialSkin.Controls.MaterialLabel lblNombreAlumno;
        private MaterialSkin.Controls.MaterialLabel lblBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblITSUR;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblFechaHora;
        private MaterialSkin.Controls.MaterialLabel lbl_3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel lblSemestreActual;
        private MaterialSkin.Controls.MaterialLabel lblCreditosActuales;
        private MaterialSkin.Controls.MaterialLabel lblCreditosReunidos;
        private MaterialSkin.Controls.MaterialLabel lblEspecialidad;
        private MaterialSkin.Controls.MaterialLabel lbl_7;
        private MaterialSkin.Controls.MaterialLabel lbl_6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lbl_5;
        private MaterialSkin.Controls.MaterialLabel lbl_4;
        private MaterialSkin.Controls.MaterialLabel lbl_2;
        private MaterialSkin.Controls.MaterialLabel lblCarrera;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton btnGenerarCardex;
        private MaterialSkin.Controls.MaterialLabel lblCardex;
    }
}

