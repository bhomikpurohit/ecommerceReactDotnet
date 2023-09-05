using System.Data.SqlClient;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System.Data;

namespace OfficialShoppingApp.Models
{
//DataAccessLayer
    public class DAL
    {
        //Registration
        public Response register(Users users, SqlConnection connection)
        {
            Response response = new Response();
            SqlCommand command = new SqlCommand("sp_register", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FirstName", users.FirstName);
            command.Parameters.AddWithValue("@LastName", users.LastName);
            command.Parameters.AddWithValue("@Password", users.Password);
            command.Parameters.AddWithValue("@Email", users.Email);
            command.Parameters.AddWithValue("@PhoneNumber", users.PhoneNumber);
            command.Parameters.AddWithValue("@Dob", users.Dob);
            command.Parameters.AddWithValue("@Address", users.Address);
            command.Parameters.AddWithValue("@Balance", 0);
            command.Parameters.AddWithValue("@Type", "Users");
            command.Parameters.AddWithValue("@Type", "Pending");
            command.Parameters.AddWithValue("@Status", users.Status);
            connection.Open();
            int i = command.ExecuteNonQuery();
            connection.Close();
            if (i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "User Registered Successfully";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "User Registration has Failed";
            }

            return response;
        }

        public Response login(Users users, SqlConnection connection)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_login", connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Email",users.Email);
            da.SelectCommand.Parameters.AddWithValue("@Password", users.Password);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response response = new Response();
            if (dt.Rows.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "User is Valid";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "User is invalid";
            }

            return response;

        }

        public Response viewUser(Users users, SqlConnection connection)
        {
            SqlDataAdapter da = new SqlDataAdapter("p_viewUser", connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ID", users.Id);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response response = new Response();
            if (dt.Rows.Count > 0)
            {
                
            }
        }
    }
}