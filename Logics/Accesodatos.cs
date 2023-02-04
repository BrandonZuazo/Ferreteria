using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    internal class Accesodatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public Accesodatos()
        {
            conexion = new SqlConnection("server=DESKTOP-63PCI7A\\SQLEXPRESS;database=DB_Ferreteria2.0;integrated security=true");
            comando = new SqlCommand();
        }
        public void setearconsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarlectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void setearparametro(string parametro, object valor)
        {
            comando.Parameters.Add(parametro, valor);
        }
        public void Cerrarconexion()
        {
            if (lector != null)
                lector.Close();

            conexion.Close();
        }
    }
}
