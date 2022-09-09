using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ado_dot_net_assignment1
{
    class student
    {
        public static void AddStudent(string name, string date, string degree, string company,string address,string email)
        {
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-CNBPDN3K\\SQLEXPRESS01; Initial Catalog = hi; Integrated Security = True");
            con.Open();
            Console.WriteLine("connection opened");
            SqlCommand cmd = new SqlCommand($"insert into student values('{name}','{date}','{degree}','{company}','{address}','{email}')",con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("insertion done");
            con.Close();
            Console.WriteLine("connection closed");
            Console.ReadLine();
        }
        public static void getstudentbyname(string name)
        {
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-CNBPDN3K\\SQLEXPRESS01; Initial Catalog = hi; Integrated Security = True");
            con.Open();
            Console.WriteLine("connection opened");
            SqlCommand cmd = new SqlCommand("select * from student where name=@name", con);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t{dr[3]}\t{dr[4]}\t{dr[5]}\t");
            }
            Console.WriteLine("its right");
            Console.ReadLine();


        }
    }
}
Footer
