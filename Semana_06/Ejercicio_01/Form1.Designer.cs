namespace Ejercicio_01
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
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.lst_Nombres = new System.Windows.Forms.ListBox();
            this.btn_Salida = new System.Windows.Forms.Button();
            this.btn_Resumen = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(78, 195);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 23;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // lst_Nombres
            // 
            this.lst_Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Nombres.FormattingEnabled = true;
            this.lst_Nombres.ItemHeight = 20;
            this.lst_Nombres.Location = new System.Drawing.Point(78, 224);
            this.lst_Nombres.Name = "lst_Nombres";
            this.lst_Nombres.Size = new System.Drawing.Size(212, 244);
            this.lst_Nombres.TabIndex = 18;
            // 
            // btn_Salida
            // 
            this.btn_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salida.Location = new System.Drawing.Point(371, 130);
            this.btn_Salida.Name = "btn_Salida";
            this.btn_Salida.Size = new System.Drawing.Size(103, 43);
            this.btn_Salida.TabIndex = 17;
            this.btn_Salida.Text = "Salida";
            this.btn_Salida.UseVisualStyleBackColor = true;
            // 
            // btn_Resumen
            // 
            this.btn_Resumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Resumen.Location = new System.Drawing.Point(223, 131);
            this.btn_Resumen.Name = "btn_Resumen";
            this.btn_Resumen.Size = new System.Drawing.Size(103, 43);
            this.btn_Resumen.TabIndex = 16;
            this.btn_Resumen.Text = "Ver nombres";
            this.btn_Resumen.UseVisualStyleBackColor = true;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.Location = new System.Drawing.Point(78, 131);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(103, 43);
            this.btn_Registrar.TabIndex = 15;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(244, 82);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(197, 29);
            this.txt_Nombre.TabIndex = 14;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(44, 82);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(194, 24);
            this.lbl_Nombre.TabIndex = 13;
            this.lbl_Nombre.Text = "Ingrese un nombre:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(157, 32);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(258, 29);
            this.lbl_Titulo.TabIndex = 12;
            this.lbl_Titulo.Text = "Registro de nombres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 504);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.lst_Nombres);
            this.Controls.Add(this.btn_Salida);
            this.Controls.Add(this.btn_Resumen);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.ListBox lst_Nombres;
        private System.Windows.Forms.Button btn_Salida;
        private System.Windows.Forms.Button btn_Resumen;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}

