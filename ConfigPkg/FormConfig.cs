using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollosLaColina
{
    public partial class FormConfig : Form
    {
        FormPrincipal frmp = new FormPrincipal();

        public FormConfig()
        {
            InitializeComponent(); 
        }

        private void Cb_Colina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cb_Fuentes_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            frmp.btn_Colina.Visible = true;
            frmp.btn_Fuentes.Visible = false;

        }
    }
}
