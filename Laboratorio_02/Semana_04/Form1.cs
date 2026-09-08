namespace Semana_04
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

        double calcularSueldoBruto()
        {
            int horas = int.Parse(txt_Horas.Text);
            double pago = double.Parse(txt_Pago.Text);

            double sueldobruto = horas * pago;

            return sueldobruto;
        }

        double calcularDescuento()
        {
            return calcularSueldoBruto() * 0.10;
        }

        double calcularSueldoNeto()
        {
            return calcularSueldoBruto() - calcularDescuento();
        }

        double agregarbono()
        {
            double bonus = 100;
            double sueldoneto = calcularSueldoNeto();

            if (sueldoneto >= 1000)
            {
                return bonus;
            }

            return 0;
        }

        double horasextra()
        {
            int horas = int.Parse(txt_Horas.Text);

            if (horas >= 15)
            {
                return 150;
            }

            return 0;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            salir();
        }

        void limpiar()
        {
            txt_DNI.Clear();
            txt_Nombres.Clear();
            txt_Horas.Clear();
            txt_Pago.Clear();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            dgv_Empleados.Rows.Add(txt_DNI.Text,
                                   txt_Nombres.Text,
                                   txt_Horas.Text,
                                   txt_Pago.Text,
                                   calcularSueldoBruto(),
                                   calcularDescuento(),
                                   calcularSueldoNeto(),
                                   agregarbono(),
                                   horasextra());
        }

        private void dgv_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
