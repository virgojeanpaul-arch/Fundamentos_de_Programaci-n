namespace Caso_01
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
            this.cbo_Llamada = new System.Windows.Forms.ComboBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_Llamada = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.lbl_Horario = new System.Windows.Forms.Label();
            this.cbo_Horario = new System.Windows.Forms.ComboBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dgv_RegistrodeLlamadas = new System.Windows.Forms.DataGridView();
            this.dgv_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Minutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_CostoxMinuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_CostoxLlamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Minutos = new System.Windows.Forms.Label();
            this.txt_Minutos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RegistrodeLlamadas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Llamada
            // 
            this.cbo_Llamada.FormattingEnabled = true;
            this.cbo_Llamada.Items.AddRange(new object[] {
            "Fijo",
            "Celular"});
            this.cbo_Llamada.Location = new System.Drawing.Point(261, 131);
            this.cbo_Llamada.Name = "cbo_Llamada";
            this.cbo_Llamada.Size = new System.Drawing.Size(166, 21);
            this.cbo_Llamada.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(155, 18);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(512, 29);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "REGISTRO DE LLAMADAS TELEFÓNICAS";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero.Location = new System.Drawing.Point(12, 70);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(243, 20);
            this.lbl_Numero.TabIndex = 2;
            this.lbl_Numero.Text = "Ingrese el número telefónico:";
            // 
            // lbl_Llamada
            // 
            this.lbl_Llamada.AutoSize = true;
            this.lbl_Llamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Llamada.Location = new System.Drawing.Point(12, 129);
            this.lbl_Llamada.Name = "lbl_Llamada";
            this.lbl_Llamada.Size = new System.Drawing.Size(253, 20);
            this.lbl_Llamada.TabIndex = 3;
            this.lbl_Llamada.Text = "Seleccione el tipo de llamada: ";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(261, 72);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(166, 20);
            this.txt_Numero.TabIndex = 4;
            // 
            // lbl_Horario
            // 
            this.lbl_Horario.AutoSize = true;
            this.lbl_Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Horario.Location = new System.Drawing.Point(433, 72);
            this.lbl_Horario.Name = "lbl_Horario";
            this.lbl_Horario.Size = new System.Drawing.Size(182, 20);
            this.lbl_Horario.TabIndex = 5;
            this.lbl_Horario.Text = "Seleccione el horario:";
            // 
            // cbo_Horario
            // 
            this.cbo_Horario.FormattingEnabled = true;
            this.cbo_Horario.Items.AddRange(new object[] {
            "Mañana-Tarde",
            "Noche-Madrugada"});
            this.cbo_Horario.Location = new System.Drawing.Point(621, 74);
            this.cbo_Horario.Name = "cbo_Horario";
            this.cbo_Horario.Size = new System.Drawing.Size(189, 21);
            this.cbo_Horario.TabIndex = 6;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.Location = new System.Drawing.Point(92, 172);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(138, 56);
            this.btn_Registrar.TabIndex = 7;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(338, 172);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(138, 56);
            this.btn_Limpiar.TabIndex = 8;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(585, 172);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(138, 56);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dgv_RegistrodeLlamadas
            // 
            this.dgv_RegistrodeLlamadas.AllowUserToAddRows = false;
            this.dgv_RegistrodeLlamadas.AllowUserToDeleteRows = false;
            this.dgv_RegistrodeLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RegistrodeLlamadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Numero,
            this.dgv_Tipo,
            this.dgv_Horario,
            this.dgv_Minutos,
            this.dgv_CostoxMinuto,
            this.dgv_CostoxLlamada});
            this.dgv_RegistrodeLlamadas.Location = new System.Drawing.Point(28, 246);
            this.dgv_RegistrodeLlamadas.Name = "dgv_RegistrodeLlamadas";
            this.dgv_RegistrodeLlamadas.ReadOnly = true;
            this.dgv_RegistrodeLlamadas.Size = new System.Drawing.Size(763, 214);
            this.dgv_RegistrodeLlamadas.TabIndex = 10;
            // 
            // dgv_Numero
            // 
            this.dgv_Numero.HeaderText = "Número";
            this.dgv_Numero.Name = "dgv_Numero";
            this.dgv_Numero.ReadOnly = true;
            this.dgv_Numero.Width = 120;
            // 
            // dgv_Tipo
            // 
            this.dgv_Tipo.HeaderText = "Tipo";
            this.dgv_Tipo.Name = "dgv_Tipo";
            this.dgv_Tipo.ReadOnly = true;
            this.dgv_Tipo.Width = 120;
            // 
            // dgv_Horario
            // 
            this.dgv_Horario.HeaderText = "Horario";
            this.dgv_Horario.Name = "dgv_Horario";
            this.dgv_Horario.ReadOnly = true;
            this.dgv_Horario.Width = 120;
            // 
            // dgv_Minutos
            // 
            this.dgv_Minutos.HeaderText = "Minutos";
            this.dgv_Minutos.Name = "dgv_Minutos";
            this.dgv_Minutos.ReadOnly = true;
            this.dgv_Minutos.Width = 120;
            // 
            // dgv_CostoxMinuto
            // 
            this.dgv_CostoxMinuto.HeaderText = "Costo por Minuto";
            this.dgv_CostoxMinuto.Name = "dgv_CostoxMinuto";
            this.dgv_CostoxMinuto.ReadOnly = true;
            this.dgv_CostoxMinuto.Width = 120;
            // 
            // dgv_CostoxLlamada
            // 
            this.dgv_CostoxLlamada.HeaderText = "Costo de llamada";
            this.dgv_CostoxLlamada.Name = "dgv_CostoxLlamada";
            this.dgv_CostoxLlamada.ReadOnly = true;
            this.dgv_CostoxLlamada.Width = 120;
            // 
            // lbl_Minutos
            // 
            this.lbl_Minutos.AutoSize = true;
            this.lbl_Minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Minutos.Location = new System.Drawing.Point(433, 129);
            this.lbl_Minutos.Name = "lbl_Minutos";
            this.lbl_Minutos.Size = new System.Drawing.Size(261, 20);
            this.lbl_Minutos.TabIndex = 11;
            this.lbl_Minutos.Text = "Ingrese la cantidad de minutos:";
            // 
            // txt_Minutos
            // 
            this.txt_Minutos.Location = new System.Drawing.Point(700, 132);
            this.txt_Minutos.Name = "txt_Minutos";
            this.txt_Minutos.Size = new System.Drawing.Size(110, 20);
            this.txt_Minutos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 472);
            this.Controls.Add(this.txt_Minutos);
            this.Controls.Add(this.lbl_Minutos);
            this.Controls.Add(this.dgv_RegistrodeLlamadas);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.cbo_Horario);
            this.Controls.Add(this.lbl_Horario);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.lbl_Llamada);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.cbo_Llamada);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RegistrodeLlamadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Llamada;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_Llamada;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label lbl_Horario;
        private System.Windows.Forms.ComboBox cbo_Horario;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dgv_RegistrodeLlamadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Minutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_CostoxMinuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_CostoxLlamada;
        private System.Windows.Forms.Label lbl_Minutos;
        private System.Windows.Forms.TextBox txt_Minutos;
    }
}

