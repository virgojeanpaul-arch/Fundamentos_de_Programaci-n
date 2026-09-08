namespace Semana_04
{
    partial class Form1
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
            lbl_Titulo = new Label();
            lbl_DNI = new Label();
            lbl_Nombres = new Label();
            lbl_Horastrabajadas = new Label();
            lbl_PagoxHoras = new Label();
            txt_DNI = new TextBox();
            txt_Nombres = new TextBox();
            txt_Horas = new TextBox();
            txt_Pago = new TextBox();
            btn_Limpiar = new Button();
            btn_Registrar = new Button();
            btn_Salir = new Button();
            dgv_Empleados = new DataGridView();
            dgv_DNI = new DataGridViewTextBoxColumn();
            dgv_Nombre = new DataGridViewTextBoxColumn();
            dgv_Horas = new DataGridViewTextBoxColumn();
            dgv_Pago = new DataGridViewTextBoxColumn();
            dgv_SueldoBruto = new DataGridViewTextBoxColumn();
            dgv_Descuento = new DataGridViewTextBoxColumn();
            dgv_SueldoNeto = new DataGridViewTextBoxColumn();
            dgv_Bono = new DataGridViewTextBoxColumn();
            dgv_Horasextra = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Empleados).BeginInit();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Titulo.Location = new Point(373, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(275, 32);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Registro de empleados";
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_DNI.Location = new Point(127, 74);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(47, 25);
            lbl_DNI.TabIndex = 1;
            lbl_DNI.Text = "DNI";
            // 
            // lbl_Nombres
            // 
            lbl_Nombres.AutoSize = true;
            lbl_Nombres.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Nombres.Location = new Point(127, 149);
            lbl_Nombres.Name = "lbl_Nombres";
            lbl_Nombres.Size = new Size(94, 25);
            lbl_Nombres.TabIndex = 2;
            lbl_Nombres.Text = "Nombres";
            // 
            // lbl_Horastrabajadas
            // 
            lbl_Horastrabajadas.AutoSize = true;
            lbl_Horastrabajadas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Horastrabajadas.Location = new Point(468, 74);
            lbl_Horastrabajadas.Name = "lbl_Horastrabajadas";
            lbl_Horastrabajadas.Size = new Size(162, 25);
            lbl_Horastrabajadas.TabIndex = 3;
            lbl_Horastrabajadas.Text = "Horas trabajadas";
            // 
            // lbl_PagoxHoras
            // 
            lbl_PagoxHoras.AutoSize = true;
            lbl_PagoxHoras.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_PagoxHoras.Location = new Point(468, 149);
            lbl_PagoxHoras.Name = "lbl_PagoxHoras";
            lbl_PagoxHoras.Size = new Size(124, 25);
            lbl_PagoxHoras.TabIndex = 4;
            lbl_PagoxHoras.Text = "Pago x Hora";
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(235, 76);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(206, 23);
            txt_DNI.TabIndex = 5;
            // 
            // txt_Nombres
            // 
            txt_Nombres.Location = new Point(235, 149);
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(206, 23);
            txt_Nombres.TabIndex = 6;
            // 
            // txt_Horas
            // 
            txt_Horas.Location = new Point(642, 79);
            txt_Horas.Name = "txt_Horas";
            txt_Horas.Size = new Size(206, 23);
            txt_Horas.TabIndex = 8;
            // 
            // txt_Pago
            // 
            txt_Pago.Location = new Point(642, 154);
            txt_Pago.Name = "txt_Pago";
            txt_Pago.Size = new Size(206, 23);
            txt_Pago.TabIndex = 7;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Limpiar.Location = new Point(204, 207);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(124, 39);
            btn_Limpiar.TabIndex = 9;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Registrar
            // 
            btn_Registrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Registrar.Location = new Point(428, 207);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(124, 39);
            btn_Registrar.TabIndex = 10;
            btn_Registrar.Text = "Registrar";
            btn_Registrar.UseVisualStyleBackColor = true;
            btn_Registrar.Click += btn_Registrar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Salir.Location = new Point(658, 207);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(124, 39);
            btn_Salir.TabIndex = 11;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // dgv_Empleados
            // 
            dgv_Empleados.AllowUserToAddRows = false;
            dgv_Empleados.AllowUserToDeleteRows = false;
            dgv_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Empleados.Columns.AddRange(new DataGridViewColumn[] { dgv_DNI, dgv_Nombre, dgv_Horas, dgv_Pago, dgv_SueldoBruto, dgv_Descuento, dgv_SueldoNeto, dgv_Bono, dgv_Horasextra });
            dgv_Empleados.Location = new Point(16, 270);
            dgv_Empleados.Name = "dgv_Empleados";
            dgv_Empleados.ReadOnly = true;
            dgv_Empleados.Size = new Size(943, 238);
            dgv_Empleados.TabIndex = 12;
            dgv_Empleados.CellContentClick += dgv_Empleados_CellContentClick;
            // 
            // dgv_DNI
            // 
            dgv_DNI.HeaderText = "DNI";
            dgv_DNI.Name = "dgv_DNI";
            dgv_DNI.ReadOnly = true;
            // 
            // dgv_Nombre
            // 
            dgv_Nombre.HeaderText = "Nombres";
            dgv_Nombre.Name = "dgv_Nombre";
            dgv_Nombre.ReadOnly = true;
            // 
            // dgv_Horas
            // 
            dgv_Horas.HeaderText = "Horas trabajadas";
            dgv_Horas.Name = "dgv_Horas";
            dgv_Horas.ReadOnly = true;
            // 
            // dgv_Pago
            // 
            dgv_Pago.HeaderText = "Pago x Hora";
            dgv_Pago.Name = "dgv_Pago";
            dgv_Pago.ReadOnly = true;
            // 
            // dgv_SueldoBruto
            // 
            dgv_SueldoBruto.HeaderText = "Sueldo Bruto";
            dgv_SueldoBruto.Name = "dgv_SueldoBruto";
            dgv_SueldoBruto.ReadOnly = true;
            // 
            // dgv_Descuento
            // 
            dgv_Descuento.HeaderText = "Descuento";
            dgv_Descuento.Name = "dgv_Descuento";
            dgv_Descuento.ReadOnly = true;
            // 
            // dgv_SueldoNeto
            // 
            dgv_SueldoNeto.HeaderText = "Sueldo Neto";
            dgv_SueldoNeto.Name = "dgv_SueldoNeto";
            dgv_SueldoNeto.ReadOnly = true;
            // 
            // dgv_Bono
            // 
            dgv_Bono.HeaderText = "Bono";
            dgv_Bono.Name = "dgv_Bono";
            dgv_Bono.ReadOnly = true;
            // 
            // dgv_Horasextra
            // 
            dgv_Horasextra.HeaderText = "Horas extra";
            dgv_Horasextra.Name = "dgv_Horasextra";
            dgv_Horasextra.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 515);
            Controls.Add(dgv_Empleados);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Registrar);
            Controls.Add(btn_Limpiar);
            Controls.Add(txt_Horas);
            Controls.Add(txt_Pago);
            Controls.Add(txt_Nombres);
            Controls.Add(txt_DNI);
            Controls.Add(lbl_PagoxHoras);
            Controls.Add(lbl_Horastrabajadas);
            Controls.Add(lbl_Nombres);
            Controls.Add(lbl_DNI);
            Controls.Add(lbl_Titulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_Empleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
        private Label lbl_DNI;
        private Label lbl_Nombres;
        private Label lbl_Horastrabajadas;
        private Label lbl_PagoxHoras;
        private TextBox txt_DNI;
        private TextBox txt_Nombres;
        private TextBox txt_Horas;
        private TextBox txt_Pago;
        private Button btn_Limpiar;
        private Button btn_Registrar;
        private Button btn_Salir;
        private DataGridView dgv_Empleados;
        private DataGridViewTextBoxColumn dgv_DNI;
        private DataGridViewTextBoxColumn dgv_Nombre;
        private DataGridViewTextBoxColumn dgv_Horas;
        private DataGridViewTextBoxColumn dgv_Pago;
        private DataGridViewTextBoxColumn dgv_SueldoBruto;
        private DataGridViewTextBoxColumn dgv_Descuento;
        private DataGridViewTextBoxColumn dgv_SueldoNeto;
        private DataGridViewTextBoxColumn dgv_Bono;
        private DataGridViewTextBoxColumn dgv_Horasextra;
    }
}
