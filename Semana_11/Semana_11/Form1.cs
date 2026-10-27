namespace Semana_11
{
    public partial class Form1 : Form
    {
        string ruta = "estudiante.txt";
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
                    string[] datos = lineas[i].Split(',');

                    dgv_Estudiantes.Rows.Add(datos[0],
                                             datos[1],
                                             datos[2],
                                             datos[3]);
                }


            }
            else
            {

            }
        }

        private void btn_CargarArchivo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código que quieras ejecutar al cargar el formulario
        }
    }
}
