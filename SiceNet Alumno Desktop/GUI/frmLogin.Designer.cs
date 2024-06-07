namespace GUI
{
    partial class frmLogin
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
            this.lblSG = new MaterialSkin.Controls.MaterialLabel();
            this.lblITS = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblITSUR = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new MaterialSkin.Controls.MaterialButton();
            this.txtNoControl = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblNoControl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.checkLoginAutomatico = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblSG);
            this.materialCard1.Controls.Add(this.lblITS);
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
            // lblSG
            // 
            this.lblSG.AutoSize = true;
            this.lblSG.Depth = 0;
            this.lblSG.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSG.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblSG.Location = new System.Drawing.Point(265, 58);
            this.lblSG.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSG.Name = "lblSG";
            this.lblSG.Size = new System.Drawing.Size(166, 24);
            this.lblSG.TabIndex = 3;
            this.lblSG.Text = "Sur de Guanajuato";
            // 
            // lblITS
            // 
            this.lblITS.AutoSize = true;
            this.lblITS.Depth = 0;
            this.lblITS.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblITS.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblITS.Location = new System.Drawing.Point(197, 34);
            this.lblITS.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblITS.Name = "lblITS";
            this.lblITS.Size = new System.Drawing.Size(301, 24);
            this.lblITS.TabIndex = 2;
            this.lblITS.Text = "Instituto Tecnológico Superior del";
            this.lblITS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciarSesion.Depth = 0;
            this.btnIniciarSesion.HighEmphasis = true;
            this.btnIniciarSesion.Icon = null;
            this.btnIniciarSesion.Location = new System.Drawing.Point(233, 430);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIniciarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIniciarSesion.Size = new System.Drawing.Size(128, 36);
            this.btnIniciarSesion.TabIndex = 2;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIniciarSesion.UseAccentColor = false;
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtNoControl
            // 
            this.txtNoControl.AnimateReadOnly = false;
            this.txtNoControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNoControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNoControl.Depth = 0;
            this.txtNoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoControl.HideSelection = true;
            this.txtNoControl.LeadingIcon = null;
            this.txtNoControl.Location = new System.Drawing.Point(135, 242);
            this.txtNoControl.MaxLength = 32767;
            this.txtNoControl.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.PasswordChar = '\0';
            this.txtNoControl.PrefixSuffixText = null;
            this.txtNoControl.ReadOnly = false;
            this.txtNoControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoControl.SelectedText = "";
            this.txtNoControl.SelectionLength = 0;
            this.txtNoControl.SelectionStart = 0;
            this.txtNoControl.ShortcutsEnabled = true;
            this.txtNoControl.Size = new System.Drawing.Size(325, 48);
            this.txtNoControl.TabIndex = 4;
            this.txtNoControl.TabStop = false;
            this.txtNoControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNoControl.TrailingIcon = null;
            this.txtNoControl.UseSystemPasswordChar = false;
            // 
            // txtContrasena
            // 
            this.txtContrasena.AnimateReadOnly = false;
            this.txtContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContrasena.Depth = 0;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasena.HideSelection = true;
            this.txtContrasena.LeadingIcon = null;
            this.txtContrasena.Location = new System.Drawing.Point(135, 320);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '●';
            this.txtContrasena.PrefixSuffixText = null;
            this.txtContrasena.ReadOnly = false;
            this.txtContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.ShortcutsEnabled = true;
            this.txtContrasena.Size = new System.Drawing.Size(325, 48);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.TabStop = false;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrasena.TrailingIcon = null;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblNoControl
            // 
            this.lblNoControl.AutoSize = true;
            this.lblNoControl.Depth = 0;
            this.lblNoControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNoControl.Location = new System.Drawing.Point(137, 217);
            this.lblNoControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoControl.Name = "lblNoControl";
            this.lblNoControl.Size = new System.Drawing.Size(80, 19);
            this.lblNoControl.TabIndex = 6;
            this.lblNoControl.Text = "No. Control";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(137, 295);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Contraseña";
            // 
            // checkLoginAutomatico
            // 
            this.checkLoginAutomatico.AutoSize = true;
            this.checkLoginAutomatico.Depth = 0;
            this.checkLoginAutomatico.Location = new System.Drawing.Point(192, 377);
            this.checkLoginAutomatico.Margin = new System.Windows.Forms.Padding(0);
            this.checkLoginAutomatico.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkLoginAutomatico.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkLoginAutomatico.Name = "checkLoginAutomatico";
            this.checkLoginAutomatico.ReadOnly = false;
            this.checkLoginAutomatico.Ripple = true;
            this.checkLoginAutomatico.Size = new System.Drawing.Size(208, 37);
            this.checkLoginAutomatico.TabIndex = 8;
            this.checkLoginAutomatico.Text = "Iniciar Automaticamente";
            this.checkLoginAutomatico.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 475);
            this.Controls.Add(this.checkLoginAutomatico);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblNoControl);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiceNet Alumno Desktop";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label lblITSUR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblITS;
        private MaterialSkin.Controls.MaterialButton btnIniciarSesion;
        private MaterialSkin.Controls.MaterialLabel lblSG;
        private MaterialSkin.Controls.MaterialTextBox2 txtNoControl;
        private MaterialSkin.Controls.MaterialTextBox2 txtContrasena;
        private MaterialSkin.Controls.MaterialLabel lblNoControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox checkLoginAutomatico;
    }
}

