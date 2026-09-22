namespace Semana_06
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Nota = new System.Windows.Forms.Label();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Resumen = new System.Windows.Forms.Button();
            this.btn_Salida = new System.Windows.Forms.Button();
            this.lst_Notas = new System.Windows.Forms.ListBox();
            this.lbl_Cant = new System.Windows.Forms.Label();
            this.lbl_Prom = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Promedio = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(118, 24);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(219, 29);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Registro de notas";
            // 
            // lbl_Nota
            // 
            this.lbl_Nota.AutoSize = true;
            this.lbl_Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nota.Location = new System.Drawing.Point(5, 74);
            this.lbl_Nota.Name = "lbl_Nota";
            this.lbl_Nota.Size = new System.Drawing.Size(173, 24);
            this.lbl_Nota.TabIndex = 1;
            this.lbl_Nota.Text = "Ingrese una nota:";
            // 
            // txt_Nota
            // 
            this.txt_Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nota.Location = new System.Drawing.Point(184, 74);
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(197, 29);
            this.txt_Nota.TabIndex = 2;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.Location = new System.Drawing.Point(39, 123);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(103, 43);
            this.btn_Registrar.TabIndex = 3;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Resumen
            // 
            this.btn_Resumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Resumen.Location = new System.Drawing.Point(184, 123);
            this.btn_Resumen.Name = "btn_Resumen";
            this.btn_Resumen.Size = new System.Drawing.Size(103, 43);
            this.btn_Resumen.TabIndex = 4;
            this.btn_Resumen.Text = "Ver resumen";
            this.btn_Resumen.UseVisualStyleBackColor = true;
            this.btn_Resumen.Click += new System.EventHandler(this.btn_Resumen_Click);
            // 
            // btn_Salida
            // 
            this.btn_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salida.Location = new System.Drawing.Point(332, 122);
            this.btn_Salida.Name = "btn_Salida";
            this.btn_Salida.Size = new System.Drawing.Size(103, 43);
            this.btn_Salida.TabIndex = 5;
            this.btn_Salida.Text = "Salida";
            this.btn_Salida.UseVisualStyleBackColor = true;
            this.btn_Salida.Click += new System.EventHandler(this.btn_Salida_Click);
            // 
            // lst_Notas
            // 
            this.lst_Notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Notas.FormattingEnabled = true;
            this.lst_Notas.ItemHeight = 20;
            this.lst_Notas.Location = new System.Drawing.Point(39, 216);
            this.lst_Notas.Name = "lst_Notas";
            this.lst_Notas.Size = new System.Drawing.Size(212, 244);
            this.lst_Notas.TabIndex = 6;
            // 
            // lbl_Cant
            // 
            this.lbl_Cant.AutoSize = true;
            this.lbl_Cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cant.Location = new System.Drawing.Point(275, 233);
            this.lbl_Cant.Name = "lbl_Cant";
            this.lbl_Cant.Size = new System.Drawing.Size(161, 20);
            this.lbl_Cant.TabIndex = 7;
            this.lbl_Cant.Text = "Cantidad de notas:";
            // 
            // lbl_Prom
            // 
            this.lbl_Prom.AutoSize = true;
            this.lbl_Prom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prom.Location = new System.Drawing.Point(273, 323);
            this.lbl_Prom.Name = "lbl_Prom";
            this.lbl_Prom.Size = new System.Drawing.Size(164, 20);
            this.lbl_Prom.TabIndex = 8;
            this.lbl_Prom.Text = "Promedio de notas:";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(275, 277);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(50, 16);
            this.lbl_Cantidad.TabIndex = 9;
            this.lbl_Cantidad.Text = "label3";
            // 
            // lbl_Promedio
            // 
            this.lbl_Promedio.AutoSize = true;
            this.lbl_Promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Promedio.Location = new System.Drawing.Point(275, 369);
            this.lbl_Promedio.Name = "lbl_Promedio";
            this.lbl_Promedio.Size = new System.Drawing.Size(50, 16);
            this.lbl_Promedio.TabIndex = 10;
            this.lbl_Promedio.Text = "label4";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(39, 187);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 11;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 502);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.lbl_Promedio);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_Prom);
            this.Controls.Add(this.lbl_Cant);
            this.Controls.Add(this.lst_Notas);
            this.Controls.Add(this.btn_Salida);
            this.Controls.Add(this.btn_Resumen);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txt_Nota);
            this.Controls.Add(this.lbl_Nota);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Nota;
        private System.Windows.Forms.TextBox txt_Nota;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Resumen;
        private System.Windows.Forms.Button btn_Salida;
        private System.Windows.Forms.ListBox lst_Notas;
        private System.Windows.Forms.Label lbl_Cant;
        private System.Windows.Forms.Label lbl_Prom;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Promedio;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}

