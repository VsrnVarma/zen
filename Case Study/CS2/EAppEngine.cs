using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS1;

namespace CS2
{
    public class EAppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        public void Introduce()
        {
            try
            {
                con = getConnection();
                Console.Write("Number of courses you want to introduce: ");
                int cno = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < cno; i++)
                {
                    Console.Write("Enter the Course Id: ");
                    int cid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the name: ");
                    string cname = Console.ReadLine();
                    Console.Write("Enter the time taken to complete the course: ");
                    int dur = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the cost: ");
                    int fee = Convert.ToInt32(Console.ReadLine());

                    cmd = new SqlCommand("insert into Course values(@CId,@CName,@Duration,@Fee)",con);
                    cmd.Parameters.AddWithValue("@CId", cid);
                    cmd.Parameters.AddWithValue("@CName", cname);
                    cmd.Parameters.AddWithValue("@Duration", dur);
                    cmd.Parameters.AddWithValue("@Fee", fee);
                    int nor = cmd.ExecuteNonQuery();
                    if (nor > 0)
                        Console.WriteLine("Executed Successfully\n");
                    else
                        Console.WriteLine("Some error occurred");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Some Exception arised");
            }
            finally
            {
                con.Close();
            }


        } 

        public void Register()
        {
            Console.WriteLine("-----------Sign In--------");
            try
            {
                con = getConnection();
                Console.Write("Number of students: ");
                int sno = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < sno; i++)
                {
                    Console.Write("Enter the Student Id: ");
                    int sid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the name: ");
                    string sname = Console.ReadLine();
                    Console.Write("Date of Birth: ");
                    DateTime dob = Convert.ToDateTime(Console.ReadLine());

                    cmd = new SqlCommand("insert into student values(@sid,@sname,@dob)", con);
                    cmd.Parameters.AddWithValue("@sid", sid);
                    cmd.Parameters.AddWithValue("@sname", sname);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    int nor = cmd.ExecuteNonQuery();
                    if (nor > 0)
                        Console.WriteLine("Inserted successfully\n");
                    else
                        Console.WriteLine("There is some error");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            { 
                con.Close();
            }
        }

        public void listOfStudents()
        {
            Console.WriteLine("-----------Student Details-----------");
            con = getConnection();
            cmd = new SqlCommand("select * from student", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Student Id: " + dr[0]);
                Console.WriteLine("Student Name: " + dr[1]);
                Console.WriteLine("Date of Birth: " + dr[2].ToString().Remove(10));
            }
        }

        public void listOfCourses()
        {
            Console.WriteLine("-----------Course Details-----------");
            con = getConnection();
            cmd = new SqlCommand("select * from course", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Course Id: "+dr[0]);
                Console.WriteLine("Course Name: "+dr[1]);
                Console.WriteLine("Duration: " + dr[2]);
                Console.WriteLine("Fees: " + dr[3]);

            }
        }

        public void EnrollStudent(Student std, Course co)
        {
            try
            {
                con = getConnection();
                Console.Write("Number of enrollments: ");
                int sno = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < sno; i++)
                {
                    Console.Write("Enter the Student Id: ");
                    std.StudId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the course Id: ");
                    co.CId= Convert.ToInt32(Console.ReadLine());
                    Console.Write("Date of enrollment: ");
                    DateTime doe = Convert.ToDateTime(Console.ReadLine());

                    cmd = new SqlCommand("insert into Enrollment values(@sid,@cid,@doe)", con);
                    cmd.Parameters.AddWithValue("@sid", std.StudId);
                    cmd.Parameters.AddWithValue("@cid", co.CId);
                    cmd.Parameters.AddWithValue("@doe", doe);
                    int nor = cmd.ExecuteNonQuery();
                    if (nor > 0)
                        Console.WriteLine("Inserted successfully\n");
                    else
                        Console.WriteLine("There is some error");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void listOfEnroll()
        {
            Console.WriteLine("-----------Enrollment Details-----------");
            con = getConnection();
            cmd = new SqlCommand("select * from enrollment", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Student Id: " + dr[0]);
                Console.WriteLine("Course Id: " + dr[1]);
                Console.WriteLine("Date Of Enrollment: " + dr[2].ToString().Remove(10));
            }
        }

        public void updateCourse()
        {
            con = getConnection();
            Console.Write("Enter the id to be updated: ");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("select * from course where Cid=@cid", con);
            cmd.Parameters.AddWithValue("@cid", id);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                        Console.WriteLine(dr[i]);
            }
            con.Close();
            Console.WriteLine("Do you want to make changes? Y/N");
            string s = Console.ReadLine();
            if (s == "Y" || s == "y")
            {
                con.Open();
                Console.Write("Enter the parameter that you want to update: ");
                string upd = Console.ReadLine();
                if (upd == "duration")
                {
                    Console.Write("Enter the new duration: ");
                    int dur = Convert.ToInt32(Console.ReadLine());
                    cmd = new SqlCommand("update employee set duration=@due where empid=@eid", con);
                    cmd.Parameters.AddWithValue("@due", dur);
                    cmd.Parameters.AddWithValue("@eid", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        Console.WriteLine("Record updated successfully");
                    else
                        Console.WriteLine("Error in updating the record");
                }
                else
                {
                    Console.Write("Enter the new fee: ");
                    int fee = Convert.ToInt32(Console.ReadLine());
                    cmd = new SqlCommand("update employee set fee=@fee where empid=@eid", con);
                    cmd.Parameters.AddWithValue("@fee", fee);
                    cmd.Parameters.AddWithValue("@eid", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        Console.WriteLine("Record updated successfully");
                    else
                        Console.WriteLine("Error in updating the record");
                }
            }
            else
                Console.WriteLine("No updating.....");
        }

        public void deleteCourse()
        {
            con = getConnection();
            Console.Write("Enter the id to be deleted:");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("delete from course where cid=@cid", con);
            cmd.Parameters.AddWithValue("@cid", id);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Console.WriteLine("Record deleted successfuly");
            }
            else
                Console.WriteLine("Could not delete the record..");

        }

        public void updateStudent()
        {
            con = getConnection();
            Console.Write("Enter the id to be updated: ");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("select * from student where Sid=@sid", con);
            cmd.Parameters.AddWithValue("@sid", id);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                    Console.WriteLine(dr[i]);
            }
            con.Close();
            Console.WriteLine("Do you want to make changes? Y/N");
            string s = Console.ReadLine();
            if (s == "Y" || s == "y")
            {
                con.Open();
                Console.Write("Enter the parameter that you want to update: ");
                string upd = Console.ReadLine();
                if (upd == "name")
                {
                    Console.Write("Enter the new name: ");
                    string name = Console.ReadLine();
                    cmd = new SqlCommand("update employee set Name=@name where Sid=@sid", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@sid", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        Console.WriteLine("Record updated successfully");
                    else
                        Console.WriteLine("Error in updating the record");
                }
                else
                {
                    Console.Write("Enter the new Dob: ");
                    DateTime dob = DateTime.Parse(Console.ReadLine());
                    cmd = new SqlCommand("update student set Dob=@dob where Sid=@sid", con);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@sid", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        Console.WriteLine("Record updated successfully");
                    else
                        Console.WriteLine("Error in updating the record");
                }
            }
            else
                Console.WriteLine("No updating.....");
        }

        public void deleteStudent()
        {
            con = getConnection();
            Console.Write("Enter the id to be deleted:");
            int id = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("delete from student where Sid=@sid", con);
            cmd.Parameters.AddWithValue("@sid", id);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Console.WriteLine("Record deleted successfuly");
            }
            else
                Console.WriteLine("Could not delete the record..");
        }

        static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=DESKTOP-ATI7PU9\\MSSQLSERVER01;initial catalog=CaseStudy;" +
                "integrated security=true");
            con.Open();
            return con;

        }
    }
}
