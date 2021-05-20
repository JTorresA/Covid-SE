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
    public partial class formInicio : Form
    {
        /// <summary>
        /// Inicializa componente y lo asigna a F1
        /// </summary>
        public formInicio()
        {
            InitializeComponent();
            Program.F1 = this;
        }

        /// <summary>
        /// Envía hacia Covid_SE
        /// </summary>
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // De ser existente F3, la cierra por completo para
            // que pueda ser recargada con valores por defecto
            if (Program.F3 != null)
            {
                Program.F3.Close();
                Program.F3 = null;
            }

            // De no ser existente F2, la crea 
            if (Program.F2 == null)
            {
                Program.F2 = new Covid_SE();
            }

            // Oculta F1 y muestra F2
            Program.F1.Hide();
            Program.F2.Show();
        }

        /// <summary>
        /// Método para pedir confirmación antes de salir
        /// </summary>
        private void exit()
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Llama método salir
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
