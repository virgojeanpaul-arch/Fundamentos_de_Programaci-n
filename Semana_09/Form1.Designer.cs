namespace Visual
{
    partial class Form1
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contrasena = new System.Windows.Forms.Label();
            this.lbl_Confirmar = new System.Windows.Forms.Label();
            this.lbl_Titul = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Confirmar = new System.Windows.Forms.TextBox();
            this.txt_Contrasena = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(56, 80);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(71, 20);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(56, 141);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(71, 20);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contrasena
            // 
            this.lbl_Contrasena.AutoSize = true;
            this.lbl_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contrasena.Location = new System.Drawing.Point(56, 187);
            this.lbl_Contrasena.Name = "lbl_Contrasena";
            this.lbl_Contrasena.Size = new System.Drawing.Size(102, 20);
            this.lbl_Contrasena.TabIndex = 2;
            this.lbl_Contrasena.Text = "Contraseña";
            // 
            // lbl_Confirmar
            // 
            this.lbl_Confirmar.AutoSize = true;
            this.lbl_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirmar.Location = new System.Drawing.Point(59, 239);
            this.lbl_Confirmar.Name = "lbl_Confirmar";
            this.lbl_Confirmar.Size = new System.Drawing.Size(182, 20);
            this.lbl_Confirmar.TabIndex = 3;
            this.lbl_Confirmar.Text = "Confirmar contraseña";
            // 
            // lbl_Titul
            // 
            this.lbl_Titul.AutoSize = true;
            this.lbl_Titul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titul.Location = new System.Drawing.Point(114, 24);
            this.lbl_Titul.Name = "lbl_Titul";
            this.lbl_Titul.Size = new System.Drawing.Size(259, 29);
            this.lbl_Titul.TabIndex = 4;
            this.lbl_Titul.Text = "Registro de Usuarios";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(256, 78);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(178, 26);
            this.txt_Nombre.TabIndex = 5;
            this.txt_Nombre.UseSystemPasswordChar = true;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(256, 132);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(178, 26);
            this.txt_Usuario.TabIndex = 6;
            this.txt_Usuario.UseSystemPasswordChar = true;
            // 
            // txt_Confirmar
            // 
            this.txt_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confirmar.Location = new System.Drawing.Point(256, 236);
            this.txt_Confirmar.Name = "txt_Confirmar";
            this.txt_Confirmar.Size = new System.Drawing.Size(178, 26);
            this.txt_Confirmar.TabIndex = 8;
            this.txt_Confirmar.UseSystemPasswordChar = true;
            // 
            // txt_Contrasena
            // 
            this.txt_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contrasena.Location = new System.Drawing.Point(256, 178);
            this.txt_Contrasena.Name = "txt_Contrasena";
            this.txt_Contrasena.Size = new System.Drawing.Size(178, 26);
            this.txt_Contrasena.TabIndex = 7;
            this.txt_Contrasena.UseSystemPasswordChar = true;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.Location = new System.Drawing.Point(94, 297);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(122, 43);
            this.btn_Registrar.TabIndex = 9;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(282, 297);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(122, 43);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 391);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txt_Confirmar);
            this.Controls.Add(this.txt_Contrasena);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Titul);
            this.Controls.Add(this.lbl_Confirmar);
            this.Controls.Add(this.lbl_Contrasena);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contrasena;
        private System.Windows.Forms.Label lbl_Confirmar;
        private System.Windows.Forms.Label lbl_Titul;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Confirmar;
        private System.Windows.Forms.TextBox txt_Contrasena;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

