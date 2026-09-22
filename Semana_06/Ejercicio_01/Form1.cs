using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        string[] nombres = new string[5];
        int posicion = 0;


        public Form1()
        {
            InitializeComponent();

            btn_Registrar.Click += btn_Registrar_Click;
            btn_Limpiar.Click += btn_Limpiar_Click;
            btn_Resumen.Click += btn_Resumen_Click;
            btn_Salida.Click += btn_Salida_Click;
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


        void RegistrarNombres()
        {
            if (posicion < nombres.Length)
            {
                nombres[posicion] = txt_Nombre.Text;
                MessageBox.Show("Registrado correctamente");
                posicion++;
                MostrarNombres();
            }
            else
            {
                MessageBox.Show("Solo se puede registrar 5 notas",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        void MostrarNombres()
        {
            lst_Nombres.Items.Clear();
            for (int i = 0; i < posicion; i++)
            {
                lst_Nombres.Items.Add(nombres[i]);
            }
        }

        void limpiar()
        {
            txt_Nombre.Clear();
        }

        void Resumen()
        {
            string nombre = "";  //Acumulador

            for (int i = 0; i < posicion; i++)
            {
                nombre += nombres[i];
            }

            MessageBox.Show(nombre, "Resumen de Nombres");
        }


        private void btn_Salida_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            RegistrarNombres();
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
