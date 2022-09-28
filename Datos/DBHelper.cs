using AltaRecetas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaRecetas.Datos
{
    internal class DBHelper
    {
        private SqlConnection conn;
        private string CadenaConexion = @"Data Source=PC;Initial Catalog=Recetas;Integrated Security=True";
        private static DBHelper instancia;

        public DBHelper()
        {
            conn = new SqlConnection(CadenaConexion);
        }

        public static DBHelper ObtenerInstancia()
        {
            if (instancia == null)

                instancia = new DBHelper();
            return instancia;

        }
        public bool ConfirmarReceta(Receta oReceta)
        {
            bool ok = true;
            SqlTransaction trans = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = trans;
                cmd.CommandText = "SP_GRABAR_RECETA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", oReceta.Nombre);
                cmd.Parameters.AddWithValue("@tipo", oReceta.Tipo);
                cmd.Parameters.AddWithValue("@cheff", oReceta.Cheff);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@nro_receta";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int nroReceta = (int)pOut.Value;

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (DetalleReceta detalle in oReceta.Detalles)
                {
                    cmdDetalle = new SqlCommand();
                    cmdDetalle.Connection = conn;
                    cmdDetalle.CommandText = "SP_GRABAR_DETALLE_RECETA";
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Transaction = trans;
                    cmd.Parameters.AddWithValue("@IdReceta", nroReceta);
                    cmd.Parameters.AddWithValue("@IdIngrediente", detalle.Ingrediente.IdIngrediente);
                    cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    cmd.ExecuteNonQuery();

                    detalleNro++;
                }

                trans.Commit();
            }
            catch (SqlException)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return ok;
        }

        public DataTable ConsultarDB(string NomProc)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = NomProc;
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            conn.Close();
            return tabla;
        }

        public int ProximoID(string NomProc)
        {
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = NomProc;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@NextID", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            int proximoId = Convert.ToInt32(param.Value);
            conn.Close();
            return proximoId;

        }


    }
}
