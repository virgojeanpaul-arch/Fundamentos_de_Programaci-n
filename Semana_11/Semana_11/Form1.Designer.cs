namespace Semana_11
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
            btn_CargarArchivo = new Button();
            dgv_Estudiantes = new DataGridView();
            col_Codigo = new DataGridViewTextBoxColumn();
            col_Nombres = new DataGridViewTextBoxColumn();
            col_Edad = new DataGridViewTextBoxColumn();
            col_Nota = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Estudiantes).BeginInit();
            SuspendLayout();
            // 
            // btn_CargarArchivo
            // 
            btn_CargarArchivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CargarArchivo.Location = new Point(197, 32);
            btn_CargarArchivo.Name = "btn_CargarArchivo";
            btn_CargarArchivo.Size = new Size(164, 47);
            btn_CargarArchivo.TabIndex = 0;
            btn_CargarArchivo.Text = "Cargar Archivo";
            btn_CargarArchivo.UseVisualStyleBackColor = true;
            btn_CargarArchivo.Click += btn_CargarArchivo_Click;
            // 
            // dgv_Estudiantes
            // 
            dgv_Estudiantes.AllowUserToAddRows = false;
            dgv_Estudiantes.AllowUserToDeleteRows = false;
            dgv_Estudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Estudiantes.Columns.AddRange(new DataGridViewColumn[] { col_Codigo, col_Nombres, col_Edad, col_Nota });
            dgv_Estudiantes.Location = new Point(12, 100);
            dgv_Estudiantes.Name = "dgv_Estudiantes";
            dgv_Estudiantes.ReadOnly = true;
            dgv_Estudiantes.RowTemplate.Height = 25;
            dgv_Estudiantes.Size = new Size(566, 338);
            dgv_Estudiantes.TabIndex = 1;
            // 
            // col_Codigo
            // 
            col_Codigo.HeaderText = "Código";
            col_Codigo.Name = "col_Codigo";
            col_Codigo.ReadOnly = true;
            // 
            // col_Nombres
            // 
            col_Nombres.HeaderText = "Nombres";
            col_Nombres.Name = "col_Nombres";
            col_Nombres.ReadOnly = true;
            // 
            // col_Edad
            // 
            col_Edad.HeaderText = "Edad";
            col_Edad.Name = "col_Edad";
            col_Edad.ReadOnly = true;
            // 
            // col_Nota
            // 
            col_Nota.HeaderText = "Nota";
            col_Nota.Name = "col_Nota";
            col_Nota.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 450);
            Controls.Add(dgv_Estudiantes);
            Controls.Add(btn_CargarArchivo);
            Name = "Form1";
            Text = "Form1";
        }
        private Button btn_CargarArchivo;
        private DataGridView dgv_Estudiantes;
        private DataGridViewTextBoxColumn col_Codigo;
        private DataGridViewTextBoxColumn col_Nombres;
        private DataGridViewTextBoxColumn col_Edad;
        private DataGridViewTextBoxColumn col_Nota;
    }
}