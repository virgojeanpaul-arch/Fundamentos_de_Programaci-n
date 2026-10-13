using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            // 1. Instancias el Menú Principal
            MenuPrincipal menu = new MenuPrincipal();

            // 2. Lo muestras en pantalla
            menu.Show();

            // 3. Ocultas el formulario de login actual
            this.Hide();
        }
    }
}
