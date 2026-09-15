using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void salir()
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Estas seguro de salir?",
                                        "Mensaje de confirmacion",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            salir();
        }

        void limpiar()
        {
            txt_Codigo.Clear();
            txt_Nombre.Clear();
            txt_Cantidad.Clear();
            cbo_Ladrillo.Text = "";
            cbo_Camion.Text = "";
            txt_Codigo.Focus();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        double CostoxLadrillo(string tipoLadrillo)
        {
            double precio = 0;

            if (tipoLadrillo == "King Kong")
            {
                precio = 1.20;
            }
            else if (tipoLadrillo == "Pandereta")
            {
                precio = 1.00;
            }

            return precio;
        }

        double GastoxEnvio(int cantidad, string tipoCamion)
        {
            double gasto = 0;

            if (cantidad >= 1 && cantidad <= 3000)
            {
                if (tipoCamion == "Paletizado")
                {
                    gasto = 420.00;
                }
                else if (tipoCamion == "Con Guinche")
                {
                    gasto = 490.00;
                }
            }
            else if (cantidad > 3000)
            {
                if (tipoCamion == "Paletizado")
                {
                    gasto = 350.00;
                }
                else if (tipoCamion == "Con Guinche")
                {
                    gasto = 420.00;
                }
            }

            return gasto;
        }

        double CostoTotal(double importeBruto, double gastoEnvio)
        {
            return 1.19 * (importeBruto + gastoEnvio);
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            string codigo = txt_Codigo.Text;
            string distribuidor = txt_Nombre.Text;
            string tipoLadrillo = cbo_Ladrillo.Text;
            string tipoCamion = cbo_Camion.Text;
            int cantidad = Convert.ToInt32(txt_Cantidad.Text);

            double precioUnitario = CostoxLadrillo(tipoLadrillo);
            double importeBruto = cantidad * precioUnitario;
            double gastoEnvio = GastoxEnvio(cantidad, tipoCamion);
            double costoTotal = CostoTotal(importeBruto, gastoEnvio);

            dgv_Registrodeembarques.Rows.Add(
                codigo,
                distribuidor,
                tipoLadrillo,
                tipoCamion,
                cantidad,
                precioUnitario.ToString("0.00"),
                importeBruto.ToString("0.00"),
                gastoEnvio.ToString("0.00"),
                costoTotal.ToString("0.00")
            );
        }
    }
}
