namespace Caso_02
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
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Ladrillo = new System.Windows.Forms.Label();
            this.lbl_Camion = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.cbo_Ladrillo = new System.Windows.Forms.ComboBox();
            this.cbo_Camion = new System.Windows.Forms.ComboBox();
            this.dgv_Registrodeembarques = new System.Windows.Forms.DataGridView();
            this.dgv_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Distribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Ladrillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Camion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Importebruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_GastodeEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registrodeembarques)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(265, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(485, 25);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "REGISTRO DE EMBARQUES DE LADRILLOS";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo.Location = new System.Drawing.Point(68, 66);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(180, 20);
            this.lbl_Codigo.TabIndex = 1;
            this.lbl_Codigo.Text = "Código de embarque:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(68, 122);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(199, 20);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre del distribuidor:";
            // 
            // lbl_Ladrillo
            // 
            this.lbl_Ladrillo.AutoSize = true;
            this.lbl_Ladrillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ladrillo.Location = new System.Drawing.Point(68, 181);
            this.lbl_Ladrillo.Name = "lbl_Ladrillo";
            this.lbl_Ladrillo.Size = new System.Drawing.Size(130, 20);
            this.lbl_Ladrillo.TabIndex = 3;
            this.lbl_Ladrillo.Text = "Tipo de ladrillo:";
            // 
            // lbl_Camion
            // 
            this.lbl_Camion.AutoSize = true;
            this.lbl_Camion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Camion.Location = new System.Drawing.Point(520, 90);
            this.lbl_Camion.Name = "lbl_Camion";
            this.lbl_Camion.Size = new System.Drawing.Size(135, 20);
            this.lbl_Camion.TabIndex = 4;
            this.lbl_Camion.Text = "Tipo de camión:";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(520, 157);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(177, 20);
            this.lbl_Cantidad.TabIndex = 5;
            this.lbl_Cantidad.Text = "Cantidad de ladrillos:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(270, 68);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(188, 20);
            this.txt_Codigo.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(270, 124);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(188, 20);
            this.txt_Nombre.TabIndex = 7;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(705, 159);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(184, 20);
            this.txt_Cantidad.TabIndex = 8;
            // 
            // cbo_Ladrillo
            // 
            this.cbo_Ladrillo.FormattingEnabled = true;
            this.cbo_Ladrillo.Items.AddRange(new object[] {
            "King Kong",
            "Pandereta"});
            this.cbo_Ladrillo.Location = new System.Drawing.Point(204, 180);
            this.cbo_Ladrillo.Name = "cbo_Ladrillo";
            this.cbo_Ladrillo.Size = new System.Drawing.Size(254, 21);
            this.cbo_Ladrillo.TabIndex = 9;
            // 
            // cbo_Camion
            // 
            this.cbo_Camion.FormattingEnabled = true;
            this.cbo_Camion.Items.AddRange(new object[] {
            "Paletizado",
            "Con Guinche"});
            this.cbo_Camion.Location = new System.Drawing.Point(661, 89);
            this.cbo_Camion.Name = "cbo_Camion";
            this.cbo_Camion.Size = new System.Drawing.Size(228, 21);
            this.cbo_Camion.TabIndex = 10;
            // 
            // dgv_Registrodeembarques
            // 
            this.dgv_Registrodeembarques.AllowUserToAddRows = false;
            this.dgv_Registrodeembarques.AllowUserToDeleteRows = false;
            this.dgv_Registrodeembarques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Registrodeembarques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Codigo,
            this.dgv_Distribuidor,
            this.dgv_Ladrillo,
            this.dgv_Camion,
            this.dgv_Cantidad,
            this.dgv_Preciounitario,
            this.dgv_Importebruto,
            this.dgv_GastodeEnvio,
            this.dgv_CostoTotal});
            this.dgv_Registrodeembarques.Location = new System.Drawing.Point(15, 292);
            this.dgv_Registrodeembarques.Name = "dgv_Registrodeembarques";
            this.dgv_Registrodeembarques.ReadOnly = true;
            this.dgv_Registrodeembarques.Size = new System.Drawing.Size(942, 241);
            this.dgv_Registrodeembarques.TabIndex = 11;
            // 
            // dgv_Codigo
            // 
            this.dgv_Codigo.HeaderText = "Código";
            this.dgv_Codigo.Name = "dgv_Codigo";
            this.dgv_Codigo.ReadOnly = true;
            // 
            // dgv_Distribuidor
            // 
            this.dgv_Distribuidor.HeaderText = "Distribuidor";
            this.dgv_Distribuidor.Name = "dgv_Distribuidor";
            this.dgv_Distribuidor.ReadOnly = true;
            // 
            // dgv_Ladrillo
            // 
            this.dgv_Ladrillo.HeaderText = "Tipo de ladrillo";
            this.dgv_Ladrillo.Name = "dgv_Ladrillo";
            this.dgv_Ladrillo.ReadOnly = true;
            // 
            // dgv_Camion
            // 
            this.dgv_Camion.HeaderText = "Tipo de camión";
            this.dgv_Camion.Name = "dgv_Camion";
            this.dgv_Camion.ReadOnly = true;
            // 
            // dgv_Cantidad
            // 
            this.dgv_Cantidad.HeaderText = "Cantidad";
            this.dgv_Cantidad.Name = "dgv_Cantidad";
            this.dgv_Cantidad.ReadOnly = true;
            // 
            // dgv_Preciounitario
            // 
            this.dgv_Preciounitario.HeaderText = "Precio unitario";
            this.dgv_Preciounitario.Name = "dgv_Preciounitario";
            this.dgv_Preciounitario.ReadOnly = true;
            // 
            // dgv_Importebruto
            // 
            this.dgv_Importebruto.HeaderText = "Importe bruto";
            this.dgv_Importebruto.Name = "dgv_Importebruto";
            this.dgv_Importebruto.ReadOnly = true;
            // 
            // dgv_GastodeEnvio
            // 
            this.dgv_GastodeEnvio.HeaderText = "Gasto de envío";
            this.dgv_GastodeEnvio.Name = "dgv_GastodeEnvio";
            this.dgv_GastodeEnvio.ReadOnly = true;
            // 
            // dgv_CostoTotal
            // 
            this.dgv_CostoTotal.HeaderText = "Costo Total";
            this.dgv_CostoTotal.Name = "dgv_CostoTotal";
            this.dgv_CostoTotal.ReadOnly = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(670, 219);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(138, 56);
            this.btn_Salir.TabIndex = 14;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(423, 219);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(138, 56);
            this.btn_Limpiar.TabIndex = 13;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.Location = new System.Drawing.Point(177, 219);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(138, 56);
            this.btn_Registrar.TabIndex = 12;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 545);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.dgv_Registrodeembarques);
            this.Controls.Add(this.cbo_Camion);
            this.Controls.Add(this.cbo_Ladrillo);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_Camion);
            this.Controls.Add(this.lbl_Ladrillo);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registrodeembarques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Ladrillo;
        private System.Windows.Forms.Label lbl_Camion;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.ComboBox cbo_Ladrillo;
        private System.Windows.Forms.ComboBox cbo_Camion;
        private System.Windows.Forms.DataGridView dgv_Registrodeembarques;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Distribuidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Ladrillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Camion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Importebruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_GastodeEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_CostoTotal;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Registrar;
    }
}

