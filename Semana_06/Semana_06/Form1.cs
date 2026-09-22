using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_06
{
    public partial class Form1 : Form
    {
        //Variables globales
        //Crear un arreglo de notas de tamaño 5
        double[] notas = new double [5];
        int posicion = 0;


        public Form1()
        {
            InitializeComponent();
        }
        void salir()
        {
            //Variable local respuesta
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Estas seguro de salir?",
                                        "Mensaje de confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        void RegistrarNota()
        {
            if (posicion < notas.Length)
            {
                notas[posicion] = double.Parse(txt_Nota.Text);
                MessageBox.Show("Registrado correctamente");
                posicion++;
                MostrarNotas();
            }
            else
            {
                MessageBox.Show("Solo se puede registrar 5 notas",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        void MostrarNotas()
        {
            lst_Notas.Items.Clear();
            for (int i = 0; i < posicion; i++)
            {
                lst_Notas.Items.Add(notas[i]);
            }
        }

        void limpiar()
        {
            txt_Nota.Clear();
        }

        void Resumen()
        {
            double suma = 0;  //Acumulador

            for (int i = 0; i < posicion; i++)
            {
                suma = suma + notas[i];
            }

            double promedio = suma / posicion;

            lbl_Cantidad.Text = posicion.ToString();  //ToString convierte a cadena
            lbl_Promedio.Text = promedio.ToString();

        }


        private void btn_Salida_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            RegistrarNota();
        }

        private void btn_Resumen_Click(object sender, EventArgs e)
        {
            Resumen();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
