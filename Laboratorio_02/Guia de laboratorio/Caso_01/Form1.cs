using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_01
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
            txt_Numero.Clear();
            txt_Minutos.Clear();
            cbo_Llamada.Text = "";
            cbo_Horario.Text = "";
            txt_Numero.Focus();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        double CalcularCostoPorMinuto(string tipo, string horario)
        {
            double costo = 0;

            if (tipo == "Fijo")
            {
                if (horario == "Mañana-Tarde")
                {
                    costo = 0.20;
                }
                else if (horario == "Noche-Madrugada")
                {
                    costo = 0.15;
                }
            }
            else if (tipo == "Celular")
            {
                if (horario == "Mañana-Tarde")
                {
                    costo = 0.50;
                }
                else if (horario == "Noche-Madrugada")
                {
                    costo = 0.35;
                }
            }

            return costo;
        }

        double CalcularCostoTotal(double costoPorMinuto, int minutos)
        {
            return costoPorMinuto * minutos;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            string numero = txt_Numero.Text;
            string tipo = cbo_Llamada.Text;
            string horario = cbo_Horario.Text;
            int minutos = Convert.ToInt32(txt_Minutos.Text);

            double costoPorMinuto = CalcularCostoPorMinuto(tipo, horario);
            double costoTotal = CalcularCostoTotal(costoPorMinuto, minutos);

            dgv_RegistrodeLlamadas.Rows.Add(numero,
                                            tipo,
                                            horario,
                                            minutos,
                                            costoPorMinuto.ToString("0.00"),
                                            costoTotal.ToString("0.00"));
        }

    }
}
