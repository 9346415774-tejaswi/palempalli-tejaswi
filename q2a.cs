using ADO_Dot_net_assingnment_1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Dot_net_assingnment_1
{
    internal class Q2a
    {
        public static void AddMovie(int MovieId, string Movie_Name, string Lang, string Actor, string Director) //add employee
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TUF8GF9\SQLEXPRESS; Initial Catalog = StudentDB; Integrated Security = True"))
                {
                    SqlCommand cmd = new SqlCommand("insert into Movie values(@ID,@Name,@Language,@Actors,@Directors)", con);
                    ////passing values to sql parameter
                    cmd.Parameters.AddWithValue("@ID", MovieId);
                    cmd.Parameters.AddWithValue("@Name", Movie_Name);
                    cmd.Parameters.AddWithValue("@Language", Lang);
                    cmd.Parameters.AddWithValue("@Actors", Actor);
                    cmd.Parameters.AddWithValue("@Directors", Director);
                    // SqlParameter p = new SqlParameter("@Dept", dept);
                    ////add paramter to cmd 
                    // cmd.Parameters.Add(p);
                    // SqlCommand cmd = new SqlCommand($"insert into Employee values({emp},'{emp_fname}',{emp_lname},{dept})");
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



            static void Main()
    {


            AddMovie(25, "House of Dead", "Engish", "Peter", "dffdgg");
            AddMovie(26, "House of Sceret", "Hindi", "Unknown", "Ved Prakash");

            Console.ReadKey();
    }
  }
}
 60  
Q2b.cs
@@ -0,0 +1,60 @@
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Dot_net_assingnment_1
{
    internal class Q2b
    {
        public static void GetMoviesbyName(string Movie_Name)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");
            try
            {
                //con.ConnectionString = @"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=Training1DB;Integrated Security=True";
                con.Open(); //open connection

                SqlCommand cmd = new SqlCommand($"Select MovieId,Movie_Name,Lang,Actor,Director from Movie where Movie_Name='{Movie_Name}'", con);
                SqlDataReader dr = cmd.ExecuteReader(); //ExecureReader() method stores result set data into DataReader object
                if (dr.HasRows)
                {
                    dr.Read();


                    Console.WriteLine(" Movieid:{0} Moviename:{1} Language:{2} Actor:{3} director:{4}", dr["MovieId"], dr["Movie_Name"], dr["Lang"], dr["Actor"], dr["Director"]);
                }
                else
                    Console.WriteLine("Invalid Name");


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//close connection i.e disconnected from database
            }

        }

        static void Main()
        {
            Q2b Movie = new Q2b();
            //AddMovie(25, "House of Dead", "Engish", "Peter", "dffdgg");
            // Movie.GetMovie();
            GetMoviesbyName("Harry Potter");
            //GetAll();
            Console.ReadKey();
        }
    }
}
 54  
Q2c.cs
@@ -0,0 +1,54 @@
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Dot_net_assingnment_1
{
    internal class Q2c
    {
        public static void GetAllMovies() //Get All the Products
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");
            try
            {
                //con.ConnectionString = @"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=Training1DB;Integrated Security=True";
                con.Open(); //open connection
                SqlCommand cmd = new SqlCommand("Select * from Movie", con);

                SqlDataReader dr = cmd.ExecuteReader(); //ExecureReader() method stores result set data into DataReader object

                while (dr.Read())
                {

                    Console.WriteLine(" Movieid:{0} Moviename:{1} Language:{2} Actor:{3} director:{4}", dr["MovieId"], dr["Movie_Name"], dr["Lang"], dr["Actor"], dr["Director"]);

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        static void Main()
        {

            GetAllMovies();
            //AddMovie(25, "House of Dead", "Engish", "Peter", "dffdgg");
            // AddMovie(26, "House of Sceret", "Hindi", "Unknown", "Ved Prakash");

            Console.ReadKey();
        }

    }
}
 52  
Q2d.cs
@@ -0,0 +1,52 @@
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SqlDataAdapterDemo
{
    class Q2d
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");

        //SqlDataAdapter da = null;
       // DataSet ds = null;
        public  static void Main()
        {
            Console.WriteLine("Enter Actor Name Of Any Movie: ");
            string Actor =Console.ReadLine();

           // string cs = ConfigurationManager.ConnectionStrings["@Data Source=DESKTOP-TUF8GF9\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True"].ConnectionString;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand("getMoviesbyActors", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@Actors", Actor);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", row[0], row[1], row[2], row[3], row[4]);
            }

            //Console.WriteLine("-------------------------------");

            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine("{0} {1} {2} {3} {4} {5}", row[0], row[1], row[2], row[3], row[4], row[5]);
            //}

            Console.ReadLine();

        }
    }
}
 41  
Q2e.cs
@@ -0,0 +1,41 @@
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Dot_net_assingnment_1
{
    internal class Q2e
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");


        public static void Main()
        {
            Console.WriteLine("Enter Director Name Of Any Movie: ");
            string Director = Console.ReadLine();

            // string cs = ConfigurationManager.ConnectionStrings["@Data Source=DESKTOP-TUF8GF9\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True"].ConnectionString;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand("getMoviesbyDirector", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@Directors", Director);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", row[0], row[1], row[2], row[3], row[4]);
            }



            Console.ReadLine();

        }
    }
}
 38  
Q2f.cs
@@ -0,0 +1,38 @@
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Dot_net_assingnment_1
{
    internal class Q2f
    {
        public static void DeleteMovie(int MovieId) //delete Movie
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TUF8GF9\SQLEXPRESS; Initial Catalog = StudentDB; Integrated Security = True"))
                {
                    SqlCommand cmd = new SqlCommand("Delete from Movie where MovieId=" + MovieId, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main()
        {

            DeleteMovie(25);
           // AddMovie(25, "House of Dead", "Engish", "Peter", "dffdgg");
           //  AddMovie(26, "House of Sceret", "Hindi", "Unknown", "Ved Prakash");

            Console.ReadKey();
        }
    }
}
