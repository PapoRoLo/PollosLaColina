using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Arrastrar la ventana
using System.Runtime.InteropServices;

namespace PollosLaColina
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_Fuentes_Click(null, e);

        }

        //Abrir forms
        private void AbrirFormSec(object formsec)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fs = formsec as Form;
            fs.TopLevel = false;
            fs.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fs);
            this.PanelContenedor.Tag = fs;
            fs.Show();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;

        }

        private void Btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Maximizar.Visible = true;
            btn_Restaurar.Visible = false;
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Caja_Click(object sender, EventArgs e)
        {
            AbrirFormSec(new FormCaja());
        }
        //Arrastrar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int  wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Fuentes_Click(object sender, EventArgs e)
        {
            AbrirFormSec(new FormInicio());
        }

        private void Btn_Familia_Click(object sender, EventArgs e)
        {
            AbrirFormSec(new FormFamilia());
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            AbrirFormSec(new FormInventario());
        }

        private void Btn_Proveedores_Click(object sender, EventArgs e)
        {
            AbrirFormSec(new FormProveedores());
        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormSec(new FormClientes());
        }

        private void Btn_Config_Click(object sender, EventArgs e)
        {
            AbrirFormSec(new FormConfig());
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            FormLogin log = new FormLogin();
            this.Close();
            log.Show();
        }

        private void Btn_Colina_Click(object sender, EventArgs e)
        {
            AbrirFormSec(new FormInicio());
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
