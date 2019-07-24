namespace BlacksmithManager
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.ClaveLlabel = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ClavePictureBox = new System.Windows.Forms.PictureBox();
            this.UsuarioPictureBox = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.IngresarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClavePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(50, 30);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(62, 16);
            this.UsuarioLabel.TabIndex = 0;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(115, 28);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.UsuarioTextBox.TabIndex = 1;
            this.UsuarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsuarioTextBox_KeyPress);
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveTextBox.Location = new System.Drawing.Point(115, 72);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(100, 22);
            this.ClaveTextBox.TabIndex = 3;
            this.ClaveTextBox.UseSystemPasswordChar = true;
            this.ClaveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClaveTextBox_KeyPress);
            // 
            // ClaveLlabel
            // 
            this.ClaveLlabel.AutoSize = true;
            this.ClaveLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveLlabel.Location = new System.Drawing.Point(50, 75);
            this.ClaveLlabel.Name = "ClaveLlabel";
            this.ClaveLlabel.Size = new System.Drawing.Size(48, 16);
            this.ClaveLlabel.TabIndex = 2;
            this.ClaveLlabel.Text = "Clave";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // ClavePictureBox
            // 
            this.ClavePictureBox.BackgroundImage = global::BlacksmithManager.Properties.Resources.ImagenClave;
            this.ClavePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClavePictureBox.Location = new System.Drawing.Point(20, 70);
            this.ClavePictureBox.Name = "ClavePictureBox";
            this.ClavePictureBox.Size = new System.Drawing.Size(25, 25);
            this.ClavePictureBox.TabIndex = 8;
            this.ClavePictureBox.TabStop = false;
            // 
            // UsuarioPictureBox
            // 
            this.UsuarioPictureBox.BackgroundImage = global::BlacksmithManager.Properties.Resources.ImagenUsuario;
            this.UsuarioPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UsuarioPictureBox.Location = new System.Drawing.Point(20, 25);
            this.UsuarioPictureBox.Name = "UsuarioPictureBox";
            this.UsuarioPictureBox.Size = new System.Drawing.Size(25, 25);
            this.UsuarioPictureBox.TabIndex = 7;
            this.UsuarioPictureBox.TabStop = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::BlacksmithManager.Properties.Resources.Logo;
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPictureBox.Location = new System.Drawing.Point(234, 3);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(288, 168);
            this.LogoPictureBox.TabIndex = 6;
            this.LogoPictureBox.TabStop = false;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::BlacksmithManager.Properties.Resources.BotonCancelar;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(121, 114);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(100, 35);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // IngresarButton
            // 
            this.IngresarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IngresarButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.IngresarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarButton.Image = global::BlacksmithManager.Properties.Resources.BotonIngresar;
            this.IngresarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IngresarButton.Location = new System.Drawing.Point(12, 114);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(100, 35);
            this.IngresarButton.TabIndex = 4;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(523, 173);
            this.Controls.Add(this.ClavePictureBox);
            this.Controls.Add(this.UsuarioPictureBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.ClaveLlabel);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.UsuarioLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClavePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.Label ClaveLlabel;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.PictureBox UsuarioPictureBox;
        private System.Windows.Forms.PictureBox ClavePictureBox;
    }
}