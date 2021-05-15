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
        public Covid_SE()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa Prolog y el archivo para consultas.
        /// Cambiar el archivo tareas.pl por el de diagnóstico.
        /// </summary>
        private void Covid_SE_Load(object sender, EventArgs e)
        {
            // es necesario instalar la version 32 bits, este es el "Path"
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"‪C:\\Program Files (x86)\\swipl");

            // toma los parámetros para quitar los mensajes de advertencia y otras cosillas
            string[] p = { "-q", "-f", @"tareas.pl" };
            PlEngine.Initialize(p);
        }

        /// <summary>
        /// Realiza las consultas al presionar consultar.
        /// </summary>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // toma el valor del textbox
            string valor = tbxInput.Text;

            // limpia el listbox cada vez que se da clic
            lbxOutput.Items.Clear();

            // cambiar archivo por la base de conocimientos con el mismo nombre 
            // del archivo .pl pero con extensión .bd
            PlQuery query = new PlQuery("cargar('tareas.bd')");
            query.NextSolution();

            if (ckbxFactorial.Checked == true)
            {
                PlQuery consulta1 = new PlQuery("factorial(" + valor + ",F)");
                foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    lbxOutput.Items.Add(z["F"].ToString());
            }
            else if (ckbxMCD.Checked == true)
            {
                PlQuery consulta2 = new PlQuery("mcd("+ valor +", 12, Num)");
                foreach (PlQueryVariables z in consulta2.SolutionVariables)
                    lbxOutput.Items.Add(z["Num"].ToString());
            }

            // limpia el engine para que no haya error.
            PlEngine.PlCleanup();
        }
    }
}
