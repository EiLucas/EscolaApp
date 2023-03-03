using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Escola.DAL
{
    public class Conexao
    {
        protected SqlConnection conn;
        protected SqlCommand cmd;
        protected SqlDataReader dr;


        //metodos
        public void Conectar()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-PD7JE7A;Initial Catalog=Escola;Integrated Security=True");
                conn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Desconectar()
        {

            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
