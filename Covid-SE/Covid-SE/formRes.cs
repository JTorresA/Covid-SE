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
    public partial class formRes : Form
    {
        string diagnostico = "";

        /// <summary>
        /// Inicializa F3. 
        /// </summary>
        public formRes()
        {
            InitializeComponent();            
            Program.F3 = this;
        }

        /// <summary>
        /// Carga forma con resultado e imagen.
        /// </summary>
        private void formRes_Load(object sender, EventArgs e)
        {
            // Cierra F2 y oculta F1.
            Program.F2.Close();
            Program.F2 = null;
            Program.F1.Hide();

            // Toma el resultado de la variable global.
            diagnostico = Program._diagnostico;

            lbRes.Text = diagnostico;

            // Asigna imagen dependiendo del resultado.
            switch (diagnostico)
            {
                case "Alergias":
                    pboxResultado.Image = Properties.Resources.alergia;
                    break;
                case "Resfriado":
                    pboxResultado.Image = Properties.Resources.resfriado;
                    break;
                case "Influenza":
                    pboxResultado.Image = Properties.Resources.influenza;
                    break;
                case "Covid-19":
                    pboxResultado.Image = Properties.Resources.corona;
                    break;
                case "No tiene ningun sintoma, sientase tranquilo.":
                    pboxResultado.Image = Properties.Resources.bien;
                    break;
                case "Usted tiene todo, vaya a internarse.":
                    pboxResultado.Image = Properties.Resources.mal;
                    break;
                case "Sus síntomas coinciden con varias enfermedades, acuda a su médico.":
                    pboxResultado.Image = Properties.Resources.sintomas_confundido;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Oculta F3 y muestra F1.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Program.F3.Hide();
            Program.F1.Show();
        }

        /// <summary>
        /// Inicializa componente para evitar valores anteriores.
        /// </summary>
        private void formRes_Shown(object sender, EventArgs e)
        {
            Program.F3.InitializeComponent();
        }
    }
}
