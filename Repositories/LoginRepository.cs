using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBuscador.Repositories
{
    public class LoginRepository
    {
        public bool UserExist(string usuario, string password)
        {
            bool result = false;
            string connectionString = "server=localhost;database=SistemaBuscador;Integrated Security=true;";
            using SqlConnection sql = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand("sp_check_use", sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@user", usuario));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            sql.Open();

            int bdresult = (int)cmd.ExecuteScalar();
            if (bdresult > 0)
            {
                result = true; 
            }
            return result;
        }
    }
}
