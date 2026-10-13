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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1(); //Instancia , crear un obj
            frmLogin.MdiParent = this;
            frmLogin.Show(); //muestra
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}
