
namespace EmpresaEstadistica
{
    partial class LoginWF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWF));
            this.Usuario = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Usuario.ForeColor = System.Drawing.Color.White;
            this.Usuario.Location = new System.Drawing.Point(62, 156);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(80, 22);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clave.ForeColor = System.Drawing.Color.White;
            this.Clave.Location = new System.Drawing.Point(62, 229);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(61, 22);
            this.Clave.TabIndex = 1;
            this.Clave.Text = "Clave";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariotextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuariotextBox.CausesValidation = false;
            this.UsuariotextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsuariotextBox.Location = new System.Drawing.Point(174, 159);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(186, 26);
            this.UsuariotextBox.TabIndex = 2;
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClavetextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClavetextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClavetextBox.Location = new System.Drawing.Point(174, 228);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(186, 26);
            this.ClavetextBox.TabIndex = 3;
            // 
            // IngresarButton
            // 
            this.IngresarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.IngresarButton.FlatAppearance.BorderSize = 0;
            this.IngresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngresarButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IngresarButton.ForeColor = System.Drawing.Color.White;
            this.IngresarButton.Location = new System.Drawing.Point(124, 292);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(200, 35);
            this.IngresarButton.TabIndex = 4;
            this.IngresarButton.Text = "Iniciar Sesion";
            this.IngresarButton.UseVisualStyleBackColor = false;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(124, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // LoginWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(441, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Usuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginWF";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.Panel panel1;
    }
}

