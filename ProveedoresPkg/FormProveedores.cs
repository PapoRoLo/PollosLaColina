using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SQLite;
using PollosLaColina.ProveedoresPkg;

namespace PollosLaColina
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void proveedores_Load(object sender, EventArgs e)
        {

        }
        
        private void btn_agregar_Click_1(object sender, EventArgs e)
            //sistema para guardar en la base de datos los datos de los proveedores escritos en los text-box
        {
            Boolean i = true;

            if (string.IsNullOrEmpty(txt_IDProveedor.Text))
            {
                i = false;
                MessageBox.Show("Escriba los datos solicitados");
            }
            if (string.IsNullOrEmpty(txt_NProveedor.Text))
            {
                i = false;
                MessageBox.Show("Escriba los datos solicitados");
            }
            if (string.IsNullOrEmpty(txt_EmailProveedor.Text))
            {
                i = false;
                MessageBox.Show("Escriba los datos solicitados");
            }
            if (string.IsNullOrEmpty(txt_PhoneProveedor.Text))
            {
                i = false;
                MessageBox.Show("Escriba los datos solicitados");
            }
            if (i)
            {
            Proveedor prv = new Proveedor();

            prv.IDProveedor = txt_IDProveedor.Text;
            prv.Nombre = txt_NProveedor.Text;
            prv.Telefono = txt_PhoneProveedor.Text;
            prv.Email = txt_EmailProveedor.Text;

            ProveedoresPkg.ProveedoresConnections.AgregarProovedor(prv);

            MessageBox.Show("Se han agregado sus datos correctamente");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
       
        public void btn_actualizar_Click(object sender, EventArgs e)
        {
            
            //metodo para mostrar los proveedores
            {
                SQLiteConnection con = new SQLiteConnection(Common.Constants.DBconnection);

                // Adaptador de datos, DataSet y tabla
                SQLiteDataAdapter db = new SQLiteDataAdapter(Common.Constants.ConsultaProv, con);

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
            ProveedoresConnections PC = new ProveedoresConnections();
            {

                Boolean i = true;

                if (string.IsNullOrEmpty(txt_IDProveedor.Text))
                {
                    i = false;
                    MessageBox.Show("Escriba los datos solicitados");
                }
                if (string.IsNullOrEmpty(txt_NProveedor.Text))
                {
                    i = false;
                    MessageBox.Show("Escriba los datos solicitados");
                }
                if (string.IsNullOrEmpty(txt_PhoneProveedor.Text))
                {
                    i = false;
                    MessageBox.Show("Escriba los datos solicitados");
                }
                if (string.IsNullOrEmpty(txt_EmailProveedor.Text))
                {
                    i = false;
                    MessageBox.Show("Escriba los datos solicitados");
                }
                if (i)
                {
                    Proveedor prv = new Proveedor();

                    prv.IDProveedor = txt_IDProveedor.Text;
                    prv.Nombre = txt_NProveedor.Text;
                    prv.Telefono = txt_PhoneProveedor.Text;
                    prv.Email = txt_EmailProveedor.Text;

                    ProveedoresPkg.ProveedoresConnections.BorrarProveedores(prv);

                    txt_IDProveedor.Text = "";
                    txt_NProveedor.Text = "";
                    txt_PhoneProveedor.Text = "";
                    txt_EmailProveedor.Text = "";

                    MessageBox.Show("Se han borrado sus datos correctamente");

                }

            }
        }

        private void lbl_DNIProveedor_Click(object sender, EventArgs e)
        {

        }

        private void lbl_emailProveedor_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PhoneProveedor_Click(object sender, EventArgs e)
        {

        }

        private void lbl_NProveedor_Click(object sender, EventArgs e)
        {

        }

        private void txt_IDProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_PhoneProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EmailProveedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
