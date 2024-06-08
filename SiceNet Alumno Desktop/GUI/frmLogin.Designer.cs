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
            this.lblSG = new MaterialSkin.Controls.MaterialLabel();
            this.lblITS = new MaterialSkin.Controls.MaterialLabel();
            this.btnIniciarSesion = new MaterialSkin.Controls.MaterialButton();
            this.txtNoControl = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblNoControl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.checkLoginAutomatico = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSG
            // 
            this.lblSG.AutoSize = true;
            this.lblSG.Depth = 0;
            this.lblSG.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSG.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblSG.Location = new System.Drawing.Point(364, 48);
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
            this.lblITS.Location = new System.Drawing.Point(296, 24);
            this.lblITS.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblITS.Name = "lblITS";
            this.lblITS.Size = new System.Drawing.Size(301, 24);
            this.lblITS.TabIndex = 2;
            this.lblITS.Text = "Instituto Tecnológico Superior del";
            this.lblITS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciarSesion.Depth = 0;
            this.btnIniciarSesion.HighEmphasis = true;
            this.btnIniciarSesion.Icon = null;
            this.btnIniciarSesion.Location = new System.Drawing.Point(310, 486);
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
            this.txtNoControl.Location = new System.Drawing.Point(212, 298);
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
            this.txtContrasena.Location = new System.Drawing.Point(212, 376);
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
            this.lblNoControl.Location = new System.Drawing.Point(214, 273);
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
            this.materialLabel1.Location = new System.Drawing.Point(214, 351);
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
            this.checkLoginAutomatico.Location = new System.Drawing.Point(269, 433);
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
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblSG);
            this.materialCard2.Controls.Add(this.lblITS);
            this.materialCard2.Controls.Add(this.pictureBox2);
            this.materialCard2.Controls.Add(this.label1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 78);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(718, 163);
            this.materialCard2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.logo_itsur;
            this.pictureBox2.Location = new System.Drawing.Point(17, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.75F);
            this.label1.Location = new System.Drawing.Point(175, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 551);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.checkLoginAutomatico);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblNoControl);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.btnIniciarSesion);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiceNet Alumno Desktop";
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblITS;
        private MaterialSkin.Controls.MaterialButton btnIniciarSesion;
        private MaterialSkin.Controls.MaterialLabel lblSG;
        private MaterialSkin.Controls.MaterialTextBox2 txtNoControl;
        private MaterialSkin.Controls.MaterialTextBox2 txtContrasena;
        private MaterialSkin.Controls.MaterialLabel lblNoControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox checkLoginAutomatico;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

