using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using PollosLaColina.ClientesPkg;

namespace PollosLaColina
{
    public partial class FormClientes : Form
    {
        
        public FormClientes()
        {
            InitializeComponent();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            Boolean i = true;
           
            if (string.IsNullOrEmpty(txt_IDCliente.Text))
            {
                i = false;
                MessageBox.Show("Escriba los datos solicitados");
            }
            if (string.IsNullOrEmpty(txt_NCliente.Text))
            {
                i = false;
                MessageBox.Show("Escriba los datos solicitados");
            }
            if (string.IsNullOrEmpty(txt_EmailCliente.Text))
            {
                i = false;
                MessageBox.Show("Escriba los datos solicitados");
            }
            if (string.IsNullOrEmpty(txt_EmailCliente.Text))
            {
                i = false;
                MessageBox.Show("Escriba los datos solicitados");
            }
            if (i) { 
                Clientes clt = new Clientes();

                clt.IDCliente = txt_IDCliente.Text;
                clt.Nombre = txt_NCliente.Text;
                clt.Telefono = txt_PhoneCliente.Text;
                clt.Email = txt_EmailCliente.Text;

                ClientesPkg.ClientesConnections.AgregarClientes(clt);

                txt_IDCliente.Text = "";
                txt_NCliente.Text = "";
                txt_PhoneCliente.Text = "";
                txt_EmailCliente.Text = "";

                MessageBox.Show("Se han agregado sus datos correctamente");

            }



        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //metodo para mostrar los proveedores
            {
                SQLiteConnection con = new SQLiteConnection(Common.Constants.DBconnection);

                // Lanzamos la consulta y preparamos la estructura para leer datos
               

                // Adaptador de datos, DataSet y tabla
                SQLiteDataAdapter db = new SQLiteDataAdapter(Common.Constants.ConsultaClient, con);

                DataSet ds = new DataSet();
                ds.Reset();

                DataTable dt = new DataTable();
                db.Fill(ds);


                //Asigna al DataTable la primer tabla (ciudades) 
                // y la mostramos en el DataGridView:     dt = ds.Tables[0];
                dt = ds.Tables[0];

                dataGridView1.DataSource = dt;

                // Y ya podemos cerrar la conexion
                con.Close();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ClientesConnections CC = new ClientesConnections();
            {

                Boolean i = true;

                if (string.IsNullOrEmpty(txt_IDCliente.Text))
                {
                    i = false;
                    MessageBox.Show("Escriba los datos solicitados");
                }
                if (string.IsNullOrEmpty(txt_NCliente.Text))
                {
                    i = false;
                    MessageBox.Show("Escriba los datos solicitados");
                }
                if (string.IsNullOrEmpty(txt_EmailCliente.Text))
                {
                    i = false;
                    MessageBox.Show("Escriba los datos solicitados");
                }
                if (string.IsNullOrEmpty(txt_EmailCliente.Text))
                {
                    i = false;
                    MessageBox.Show("Escriba los datos solicitados");
                }
                if (i)
                {
                    Clientes clt = new Clientes();

                    clt.IDCliente = txt_IDCliente.Text;
                    clt.Nombre = txt_NCliente.Text;
                    clt.Telefono = txt_PhoneCliente.Text;
                    clt.Email = txt_EmailCliente.Text;

                    ClientesPkg.ClientesConnections.BorrarClientes(clt);

                    txt_IDCliente.Text = "";
                    txt_NCliente.Text = "";
                    txt_PhoneCliente.Text = "";
                    txt_EmailCliente.Text = "";

                    MessageBox.Show("Se han borrado sus datos correctamente");

                }

            }
        }

        private void clientes_Load(object sender, EventArgs e)
        {

        }

        private void lbl_IDCliente_Click(object sender, EventArgs e)
        {

        }

        private void txt_EmailCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_IDCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
