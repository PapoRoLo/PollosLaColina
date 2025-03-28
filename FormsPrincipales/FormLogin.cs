using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//mover la ventana
using System.Runtime.InteropServices;

namespace PollosLaColina
{
    public partial class FormLogin : Form
    {

        FormPrincipal frm1 = new FormPrincipal();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //no usar
        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_User_Enter(object sender, EventArgs e)
        {
            if (txt_User.Text=="USUARIO")
            {
                txt_User.Text = "";
                txt_User.ForeColor = Color.Black;

            }
        }

        private void txt_User_Leave(object sender, EventArgs e)
        {
            if (txt_User.Text == "")
            {
                txt_User.Text = "USUARIO";
                txt_User.ForeColor = Color.DimGray;

            }
        }

        private void txt_Pass_Enter(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "CONTRASEÑA")
            {
                txt_Pass.Text = "";
                txt_Pass.ForeColor = Color.Black;
                txt_Pass.UseSystemPasswordChar = true;

            }
        }

        private void txt_Pass_Leave(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "")
            {
                txt_Pass.Text = "CONTRASEÑA";
                txt_Pass.ForeColor = Color.DimGray;
                txt_Pass.UseSystemPasswordChar = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean i = true;
            if (string.IsNullOrEmpty(txt_User.Text))
            {
                i = false;
                MessageBox.Show("");
            }
            if (txt_User.Text == "USUARIO")
            {
                i = false;
                MessageBox.Show("");
            }
            if (string.IsNullOrEmpty(txt_Pass.Text))
            {
                i = false;
                MessageBox.Show("");
            }
            if (txt_Pass.Text == "CONTRASEÑA")
            {
                i = false;
                MessageBox.Show("");
            }
            if (i)
            {
                MessageBox.Show("Is logged");
                this.Close();
                frm1.Show();

            }
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
