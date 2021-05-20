// directiva necesaria para utilizar libreria de prolog
using SbsSW.SwiPlCs;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_SE
{
    public partial class Covid_SE : Form
    {
        // contiene los valores de radiobutton para el query
        string[] p = new string[18];

        /// <summary>
        /// Inicializa Componente. Asigna F2 a la forma. 
        /// Inicializa arreglo de cadenas p
        /// </summary>
        public Covid_SE()
        {
            InitializeComponent();
            Program.F2 = this;
            InitializeStrings();
        }

        /// <summary>
        /// Inicializa los valores por defecto de los radio button en "no".
        /// </summary>
        private void InitializeStrings()
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = "no";
            }
        }

        /// <summary>
        /// Oculta F2 y muestra F3 con resultado.
        /// </summary>
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // variable de entorno necesaria para Prolog.
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"‪C:\\Program Files (x86)\\swipl");

            // toma los parámetros para quitar los mensajes de advertencia y otras cosillas
            string[] para = { "-q", "-f", @"tareas.pl" };

            // inicializa PlEngine y carga la base
            PlEngine.Initialize(para);
            PlQuery query = new PlQuery("cargar('tareas.bd')");
            query.NextSolution();

            // contiene query con cada valor de los radiobutton
            string mensaje = "";
            string consulteichion = "sintomas(" + p[0] + "," + p[1] + "," + p[2] + "," 
                + p[3] + "," + p[4] + "," + p[5] + "," + p[6] + "," + p[7] + "," 
                + p[8] + "," + p[9] + "," + p[10] + "," + p[11] + "," + p[12] + "," 
                + p[13] + "," + p[14] + "," + p[15] + "," + p[16] + "," + p[17] + ","
                + "X)";

            // Realiza consutla a Prolog.
            PlQuery consulta = new PlQuery(consulteichion);
            mensaje = convertirListaString(consulta);

            // En cada clic al botón realiza la limpieza ya que de mantenerse
            // corriendo, realiza un crash del sistema por inconsistencias en dll.
            PlEngine.PlCleanup();

            // Crea F3
            Program._diagnostico = mensaje;
            if (Program.F3 == null)
            {
                Program.F3 = new formRes();
            }
            Program.F2.Hide();
            Program.F3.Show();            
        }

        /// <summary>
        /// Convierte lista de caracteres a una cadena legible.
        /// </summary>
        /// <param>Lista ilegible</param>
        /// <returns>string con valor legible</returns>
        private string convertirListaString(PlQuery consulta)
        {
            string salida = "";
            foreach (PlQueryVariables z in consulta.SolutionVariables)
            {
                salida = z["X"].ToString();

                salida = salida.Replace("[", "");
                salida = salida.Replace("]", "");
                salida = salida.Replace(" ", "");

                string[] words = salida.Split(',');
                salida = "";

                foreach (var word in words)
                {
                    salida += ((char)(Convert.ToInt32(word))).ToString();
                    //int unicode = Convert.ToInt32(word);
                    //char character = (char)unicode;
                    //enfer += character.ToString();
                }
            }
            return salida;
        }

        /// <summary>
        /// Cierra la forma pero abre F1.
        /// </summary>
        private void Covid_SE_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.F1.Show();
        }

        /// <summary>
        /// Inicializa el componente para asegurarse de que no queden valores anteriores.
        /// </summary>
        private void Covid_SE_Shown(object sender, EventArgs e)
        {
            Program.F2.InitializeComponent();
        }

        #region Métodos CheckedChanged
        private void rbP1N_CheckedChanged(object sender, EventArgs e) { p[0] = "no"; }

        private void rbP1S_CheckedChanged(object sender, EventArgs e) { p[0] = "si"; }

        private void rbP2N_CheckedChanged(object sender, EventArgs e) { p[1] = "no"; }

        private void rbP2S_CheckedChanged(object sender, EventArgs e) { p[1] = "si"; }

        private void rbP3N_CheckedChanged(object sender, EventArgs e) { p[2] = "no"; }

        private void rbP3S_CheckedChanged(object sender, EventArgs e) { p[2] = "si"; }

        private void rbP4N_CheckedChanged(object sender, EventArgs e) { p[3] = "no"; }

        private void rbP4S_CheckedChanged(object sender, EventArgs e) { p[3] = "si"; }

        private void rbP5N_CheckedChanged(object sender, EventArgs e) { p[4] = "no"; }

        private void rbP5S_CheckedChanged(object sender, EventArgs e) { p[4] = "si"; }

        private void rbP6N_CheckedChanged(object sender, EventArgs e) { p[5] = "no"; }

        private void rbP6S_CheckedChanged(object sender, EventArgs e) { p[5] = "si"; }

        private void rbP7N_CheckedChanged(object sender, EventArgs e) { p[6] = "no"; }

        private void rbP7S_CheckedChanged(object sender, EventArgs e) { p[6] = "si"; }

        private void rbP8N_CheckedChanged(object sender, EventArgs e) { p[7] = "no"; }

        private void rbP8S_CheckedChanged(object sender, EventArgs e) { p[7] = "si"; }

        private void rbP9N_CheckedChanged(object sender, EventArgs e) { p[8] = "no"; }

        private void rbP9S_CheckedChanged(object sender, EventArgs e) { p[8] = "si"; }

        private void rbP10N_CheckedChanged(object sender, EventArgs e) { p[9] = "no"; }

        private void rbP10S_CheckedChanged(object sender, EventArgs e) { p[9] = "si"; }

        private void rbP11N_CheckedChanged(object sender, EventArgs e) { p[10] = "no"; }

        private void rbP11S_CheckedChanged(object sender, EventArgs e) { p[10] = "si"; }

        private void rbP12N_CheckedChanged(object sender, EventArgs e) { p[11] = "no"; }

        private void rbP12S_CheckedChanged(object sender, EventArgs e) { p[11] = "si"; }

        private void rbP13N_CheckedChanged(object sender, EventArgs e) { p[12] = "no"; }

        private void rbP13S_CheckedChanged(object sender, EventArgs e) { p[12] = "si"; }

        private void rbP14N_CheckedChanged(object sender, EventArgs e) { p[13] = "no"; }

        private void rbP14S_CheckedChanged(object sender, EventArgs e) { p[13] = "si"; }

        private void rbP15N_CheckedChanged(object sender, EventArgs e) { p[14] = "no"; }

        private void rbP15S_CheckedChanged(object sender, EventArgs e) { p[14] = "si"; }

        private void rbP16N_CheckedChanged(object sender, EventArgs e) { p[15] = "no"; }

        private void rbP16S_CheckedChanged(object sender, EventArgs e) { p[15] = "si"; }

        private void rbP17N_CheckedChanged(object sender, EventArgs e) { p[16] = "no"; }

        private void rbP17S_CheckedChanged(object sender, EventArgs e) { p[16] = "si"; }

        private void rbP18N_CheckedChanged(object sender, EventArgs e) { p[17] = "no"; }

        private void rbP18S_CheckedChanged(object sender, EventArgs e) { p[17] = "si"; }

        #endregion 
    }
}
