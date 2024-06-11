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
            this.lblCarrera = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNoControl = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreAlumno = new MaterialSkin.Controls.MaterialLabel();
            this.lblBienvenido = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblITSUR = new System.Windows.Forms.Label();
            this.tabCardex = new System.Windows.Forms.TabPage();
            this.ListViewKardex = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.btnGenerarKardex = new MaterialSkin.Controls.MaterialButton();
            this.lblKardex = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPromedioGeneral = new MaterialSkin.Controls.MaterialLabel();
            this.lblCreditosAprobados = new MaterialSkin.Controls.MaterialLabel();
            this.lblMateriasCursadas = new MaterialSkin.Controls.MaterialLabel();
            this.tabCerrarSesion = new System.Windows.Forms.TabPage();
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
            this.TabsControlDrawer.Controls.Add(this.tabCerrarSesion);
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
            this.tabCardex.Controls.Add(this.ListViewKardex);
            this.tabCardex.Controls.Add(this.materialCard4);
            this.tabCardex.Location = new System.Drawing.Point(4, 22);
            this.tabCardex.Name = "tabCardex";
            this.tabCardex.Padding = new System.Windows.Forms.Padding(3);
            this.tabCardex.Size = new System.Drawing.Size(724, 451);
            this.tabCardex.TabIndex = 1;
            this.tabCardex.Text = "Cardex";
            this.tabCardex.UseVisualStyleBackColor = true;
            // 
            // ListViewKardex
            // 
            this.ListViewKardex.AutoSizeTable = false;
            this.ListViewKardex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewKardex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewKardex.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.ListViewKardex.Depth = 0;
            this.ListViewKardex.FullRowSelect = true;
            this.ListViewKardex.HideSelection = false;
            this.ListViewKardex.Location = new System.Drawing.Point(14, 212);
            this.ListViewKardex.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewKardex.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewKardex.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewKardex.Name = "ListViewKardex";
            this.ListViewKardex.OwnerDraw = true;
            this.ListViewKardex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListViewKardex.Size = new System.Drawing.Size(696, 233);
            this.ListViewKardex.TabIndex = 1;
            this.ListViewKardex.UseCompatibleStateImageBehavior = false;
            this.ListViewKardex.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CVE.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "OFICIAL";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MATERIA";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CDTS";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CALIF";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ACREDITACION";
            this.columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ORDINARIO (SEM/PER/AÑO)";
            this.columnHeader7.Width = 225;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "REPETICION (SEM/PER/AÑO";
            this.columnHeader8.Width = 225;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ESPECIAL";
            this.columnHeader9.Width = 225;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.lblMateriasCursadas);
            this.materialCard4.Controls.Add(this.lblCreditosAprobados);
            this.materialCard4.Controls.Add(this.lblPromedioGeneral);
            this.materialCard4.Controls.Add(this.materialLabel5);
            this.materialCard4.Controls.Add(this.materialLabel3);
            this.materialCard4.Controls.Add(this.materialLabel1);
            this.materialCard4.Controls.Add(this.btnGenerarKardex);
            this.materialCard4.Controls.Add(this.lblKardex);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(14, 14);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(696, 181);
            this.materialCard4.TabIndex = 0;
            // 
            // btnGenerarKardex
            // 
            this.btnGenerarKardex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarKardex.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerarKardex.Depth = 0;
            this.btnGenerarKardex.HighEmphasis = true;
            this.btnGenerarKardex.Icon = null;
            this.btnGenerarKardex.Location = new System.Drawing.Point(252, 137);
            this.btnGenerarKardex.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerarKardex.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarKardex.Name = "btnGenerarKardex";
            this.btnGenerarKardex.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerarKardex.Size = new System.Drawing.Size(177, 36);
            this.btnGenerarKardex.TabIndex = 1;
            this.btnGenerarKardex.Text = "Generar kardex PDF";
            this.btnGenerarKardex.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerarKardex.UseAccentColor = false;
            this.btnGenerarKardex.UseVisualStyleBackColor = true;
            this.btnGenerarKardex.Click += new System.EventHandler(this.btnGenerarKardex_Click);
            // 
            // lblKardex
            // 
            this.lblKardex.AutoSize = true;
            this.lblKardex.Depth = 0;
            this.lblKardex.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblKardex.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblKardex.Location = new System.Drawing.Point(288, 10);
            this.lblKardex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKardex.Name = "lblKardex";
            this.lblKardex.Size = new System.Drawing.Size(107, 41);
            this.lblKardex.TabIndex = 0;
            this.lblKardex.Text = "Kardex";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(175, 54);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 17);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Promedio general: ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel3.Location = new System.Drawing.Point(171, 109);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(126, 17);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Materias cursadas: ";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel5.Location = new System.Drawing.Point(164, 81);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(133, 17);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Creditos aprobados: ";
            // 
            // lblPromedioGeneral
            // 
            this.lblPromedioGeneral.AutoSize = true;
            this.lblPromedioGeneral.Depth = 0;
            this.lblPromedioGeneral.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPromedioGeneral.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblPromedioGeneral.Location = new System.Drawing.Point(303, 54);
            this.lblPromedioGeneral.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPromedioGeneral.Name = "lblPromedioGeneral";
            this.lblPromedioGeneral.Size = new System.Drawing.Size(46, 17);
            this.lblPromedioGeneral.TabIndex = 8;
            this.lblPromedioGeneral.Text = "#####";
            // 
            // lblCreditosAprobados
            // 
            this.lblCreditosAprobados.AutoSize = true;
            this.lblCreditosAprobados.Depth = 0;
            this.lblCreditosAprobados.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCreditosAprobados.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblCreditosAprobados.Location = new System.Drawing.Point(303, 81);
            this.lblCreditosAprobados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCreditosAprobados.Name = "lblCreditosAprobados";
            this.lblCreditosAprobados.Size = new System.Drawing.Size(46, 17);
            this.lblCreditosAprobados.TabIndex = 9;
            this.lblCreditosAprobados.Text = "#####";
            // 
            // lblMateriasCursadas
            // 
            this.lblMateriasCursadas.AutoSize = true;
            this.lblMateriasCursadas.Depth = 0;
            this.lblMateriasCursadas.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblMateriasCursadas.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblMateriasCursadas.Location = new System.Drawing.Point(303, 111);
            this.lblMateriasCursadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMateriasCursadas.Name = "lblMateriasCursadas";
            this.lblMateriasCursadas.Size = new System.Drawing.Size(46, 17);
            this.lblMateriasCursadas.TabIndex = 10;
            this.lblMateriasCursadas.Text = "#####";
            // 
            // tabCerrarSesion
            // 
            this.tabCerrarSesion.Location = new System.Drawing.Point(4, 22);
            this.tabCerrarSesion.Name = "tabCerrarSesion";
            this.tabCerrarSesion.Padding = new System.Windows.Forms.Padding(3);
            this.tabCerrarSesion.Size = new System.Drawing.Size(724, 451);
            this.tabCerrarSesion.TabIndex = 2;
            this.tabCerrarSesion.Text = "Cerrar Sesion";
            this.tabCerrarSesion.UseVisualStyleBackColor = true;
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
        private MaterialSkin.Controls.MaterialListView ListViewKardex;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton btnGenerarKardex;
        private MaterialSkin.Controls.MaterialLabel lblKardex;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblMateriasCursadas;
        private MaterialSkin.Controls.MaterialLabel lblCreditosAprobados;
        private MaterialSkin.Controls.MaterialLabel lblPromedioGeneral;
        private System.Windows.Forms.TabPage tabCerrarSesion;
    }
}

