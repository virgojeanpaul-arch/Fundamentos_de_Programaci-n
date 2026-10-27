namespace Semana_11
{
    public partial class Form1 : Form
    {
        string ruta = "Estudiantes.txt";
        public Form1()
        {
            InitializeComponent();
        }

        void cargarEstudiantes()
        {
            //Limpia la tabla
            dgv_Estudiantes.Rows.Clear();

            //Verificar que exista el archivo
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);

                for (int i = 0; i < lineas.Length; i++)
                {
                    //Separa por; los datos y lo almacena en el arreglo
                    string[] datos = lineas[i].Split(';');

                    double nota = Convert.ToDouble(datos[03]);

                    string estado = obtenerEstado(nota);

                    dgv_Estudiantes.Rows.Add(datos[0],
                                             datos[1],
                                             datos[2],
                                             datos[3],
                                             estado);
                }


            }
            else
            {
                MessageBox.Show("No se encuentra el archivo");
            }
        }

        //Función
        string obtenerEstado(double notaEvaluada) //Parametro
        {
            if (notaEvaluada >= 12)
            {
                return "Aprobado";
            }
            else
            {
                return "Desaprobado";
            }

        }

        private void btn_CargarArchivo_Click(object sender, EventArgs e)
        {
            cargarEstudiantes();
        }
    }
}
