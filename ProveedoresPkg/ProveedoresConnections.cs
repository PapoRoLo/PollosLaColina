using Serilog;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollosLaColina.ProveedoresPkg
{
    class ProveedoresConnections
    {

        //Metodo para insertar proovedores

        //Variable for AgregarProveedor

        static string AgregarProovedorQuery = "insert into Proveedores(IDProveedor,NombreProveedor,NumeroTelefono,EmailProveedor) values(@param1, @param2, @param3, @param4)";
        static string BorrarProveedorQuery = "Delete from Proveedores where (IDProveedor,NombreProveedor,NumeroTelefono,EmailProveedor)=(@param01, @param02, @param03, @param04)";

        public static void AgregarProovedor(Proveedor prv) {


            SQLiteConnection con = new SQLiteConnection(Common.Constants.DBconnection);
            try
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(AgregarProovedorQuery, con);
                cmd.Parameters.AddWithValue("@param1",prv.IDProveedor);
                cmd.Parameters.AddWithValue("@param2", prv.Nombre);
                cmd.Parameters.AddWithValue("@param3", prv.Telefono);
                cmd.Parameters.AddWithValue("@param4", prv.Email);
          
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            
            }
        }
        public static void BorrarProveedores(Proveedor prv)
        {
            FormProveedores FrmC = new FormProveedores();

            SQLiteConnection con = new SQLiteConnection(Common.Constants.DBconnection);
            try
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(BorrarProveedorQuery, con);
                cmd.Parameters.AddWithValue("@param01", prv.IDProveedor);
                cmd.Parameters.AddWithValue("@param02", prv.Nombre);
                cmd.Parameters.AddWithValue("@param03", prv.Telefono);
                cmd.Parameters.AddWithValue("@param04", prv.Email);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }


        }

    }
}
