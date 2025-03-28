using Serilog;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollosLaColina.ClientesPkg
{
    class ClientesConnections
    {
        static string AgregarClientesQuery = "insert into Clientes(IDCliente,NombreCliente,TelefonoCliente,EmailCliente) values(@param1, @param2, @param3, @param4)";
        static string BorrarClientesQuery = "Delete from Clientes where (IDCliente,NombreCliente,TelefonoCliente,EmailCliente)=(@param01, @param02, @param03, @param04)";

        public static void AgregarClientes(Clientes clt)
        {


            SQLiteConnection con = new SQLiteConnection(Common.Constants.DBconnection);
            try
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(AgregarClientesQuery, con);
                cmd.Parameters.AddWithValue("@param1", clt.IDCliente);
                cmd.Parameters.AddWithValue("@param2", clt.Nombre);
                cmd.Parameters.AddWithValue("@param3", clt.Telefono);
                cmd.Parameters.AddWithValue("@param4", clt.Email);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);

            }
        }
        public static void BorrarClientes(Clientes clt)
        {
            FormClientes FrmC = new FormClientes();

            SQLiteConnection con = new SQLiteConnection(Common.Constants.DBconnection);
            try
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(BorrarClientesQuery, con);
                cmd.Parameters.AddWithValue("@param01", clt.IDCliente);
                cmd.Parameters.AddWithValue("@param02", clt.Nombre);
                cmd.Parameters.AddWithValue("@param03", clt.Telefono);
                cmd.Parameters.AddWithValue("@param04", clt.Email);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
