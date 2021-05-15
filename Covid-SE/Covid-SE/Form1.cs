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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            prueba();
        }

        public void prueba()
        {
            PlQuery q = new PlQuery("member(A,[a,b,c])");
            foreach (PlTermV s in q.Solutions)
                Console.WriteLine(s[0].ToString());
        }
    }
}
