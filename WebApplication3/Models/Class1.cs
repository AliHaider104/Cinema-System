using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3.Models
{
    public class Class1
    {
        public static SqlDataReader getUsers()
        {
            string connectionString = @"Data Source=DESKTOP-BK162V0; Initial Catalog=CINEMA_SYSTEM; User=ali; Password=123;";
            //string connectionString = @"Data Source=(localdb)\Name; Initial Catalog=connection;Integrated Security=True;";
            //string connectionString ="data source=DESKTOP-12I97AL\\SQLEXPRESS; Initial Catalog=HRschema;Integrated Security=true";
            string queryString = "select * from [user]";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static SqlDataReader getMovies()
        {
            string connectionString = @"Data Source=DESKTOP-BK162V0; Initial Catalog=CINEMA_SYSTEM; User=ali; Password=123;";

            string queryString = "select * from m";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static bool INSERT_USER(String Uname, String Uemail, String Umobile, String Upassword)
        {
            string connectionString = @"Data Source=DESKTOP-BK162V0; Initial Catalog=CINEMA_SYSTEM; User=ali; Password=123;";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd;
            int result = 0;


            try
            {
                connection.Open();
                cmd = new SqlCommand("InsertUser", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = Uname;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = Uemail;
                cmd.Parameters.Add("@mobileNo", SqlDbType.NVarChar, 50).Value = Umobile;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = Upassword;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);

                if (result == 1)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool CHECK_USER(String name, String password)
        {

            string connectionString = @"Data Source=DESKTOP-BK162V0; Initial Catalog=CINEMA_SYSTEM; User=ali; Password=123;";
            
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd;
            int result = 0;


            try
            {
                connection.Open();
                cmd = new SqlCommand("[Login]", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@Uemail", SqlDbType.NVarChar, 50).Value = name;
                cmd.Parameters.Add("@Upassword", SqlDbType.NVarChar, 50).Value = password;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);

                if (result == 1)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool BOOK_TICKET(int MovieId, String Date)
        {

            string connectionString = @"Data Source=DESKTOP-BK162V0; Initial Catalog=CINEMA_SYSTEM; User=ali; Password=123;";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd;
            int result = 0;


            try
            {
                connection.Open();
                cmd = new SqlCommand("addinBooking", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@movieid", SqlDbType.Int).Value = MovieId;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = Date;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);

                if (result == 1)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public static bool BOOK_EVENT(int Eventid)
        {

            string connectionString = @"Data Source=DESKTOP-BK162V0; Initial Catalog=CINEMA_SYSTEM; User=ali; Password=123;";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd;
            int result = 0;


            try
            {
                connection.Open();
                cmd = new SqlCommand("EVENTBOOKINGG", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Eventid;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);

                if (result == 1)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}