using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CodeChallenge
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;

        static void Main(string[] args)
        {
            con = getConnection();
            string name, type;
            double sal;
            Console.WriteLine("Enter the empmloyee details: ");
            name = Console.ReadLine();
            sal = Convert.ToDouble(Console.ReadLine());
            type = Console.ReadLine();

            cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = cmd.Parameters.Add("@name",SqlDbType.NVarChar,50);
            param.Value = name;
            param = cmd.Parameters.Add("@sal",SqlDbType.Money);
            param.Value = sal;
            param = cmd.Parameters.Add("@type",SqlDbType.NVarChar,1);
            param.Value = type;

            int NoOfRows = cmd.ExecuteNonQuery();
            con.Close();

            if(NoOfRows>0)
                Console.WriteLine(NoOfRows.ToString()+" record(s) inserted");

            Console.ReadLine();
        }

        static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=DESKTOP-ATI7PU9\\MSSQLSERVER01;initial catalog=EmployeeManagement;" +
                "integrated security=true");
            con.Open();
            return con;
        }
    }
}
