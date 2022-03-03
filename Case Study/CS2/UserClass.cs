using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS1;

namespace CS2
{
    public interface IUserClass
    {
        void showFirstScreen();
        void showStudentScreen();
        void showAdminScreen();
        void showAllStudentsScreen();
        void showStudentRegistrationScreen();
        void introduceNewCourseScreen();
        void showAllCoursesScreen();
        void showAllEnrollmentsScreen();
        void updateCourseScreen();
        void deleteCourseScreen();
        void updateStudentScreen();
        void deleteStudentScreen();
    }

    public class UserApp : IUserClass
    {
        EAppEngine ae = new EAppEngine();
        Student std = new Student();
        Course co = new Course();

        public void showFirstScreen()
        {
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
            }

        }

        public void showAdminScreen()
        {
            char res;
            Console.WriteLine("=======Admin Screen=======");
            do
            {
                Console.WriteLine("What do you want to do");
                Console.WriteLine("1. Student List\n2. Enrollment List\n3. Introduce Course\n4. Update Course\n5. Delete Course");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                    showAllStudentsScreen();
                if (choice == 2)
                    showAllEnrollmentsScreen();
                if (choice == 3)
                    introduceNewCourseScreen();
                if (choice == 4)
                    updateCourseScreen();
                if (choice == 5)
                    deleteCourseScreen();

                Console.Write("Do you want to continue in this screen? ");
                res = Convert.ToChar(Console.ReadLine());

            } while (res.Equals("y") || res.Equals("Y"));
        }

        public void showStudentScreen()
        {
            char res;
            Console.WriteLine("======Student Screen======");
            do
            {
                Console.WriteLine("Are You");
                Console.WriteLine("1. Already a user");
                Console.WriteLine("2. New User");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine("What you want to do");
                    Console.WriteLine("1. Update Your information\n2. Delete Your Account\n3. Courses Available\n4. Enroll");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                        updateStudentScreen();
                    if (choice == 2)
                        deleteStudentScreen();
                    if (choice == 3)
                        showAllCoursesScreen();
                    if (choice == 4)
                        ae.EnrollStudent(std, co);      
                }

                if (c == 2)
                { 
                    showStudentRegistrationScreen();
                }   

                Console.Write("Do you want to continue in this screen: ");
                res = Convert.ToChar(Console.ReadLine());
            } while (res.Equals("y")||res.Equals("Y"));
        }

        public void introduceNewCourseScreen()
        {
            ae.Introduce();
        }

        public void showStudentRegistrationScreen()
        {
            ae.Register();
        }

        public void showAllCoursesScreen()
        {
            ae.listOfCourses();
        }

        public void showAllStudentsScreen()
        {
            ae.listOfStudents();
        }

        public void showAllEnrollmentsScreen()
        {
            ae.listOfEnroll();
        }

        public void updateCourseScreen()
        {
            ae.updateCourse();
        }

        public void deleteCourseScreen()
        {
            ae.deleteCourse();
        }

        public void updateStudentScreen()
        {
            ae.updateStudent();
        }

        public void deleteStudentScreen()
        {
            ae.deleteStudent();
        }

        static void Main()
        {
            UserApp ua = new UserApp();
            ua.showFirstScreen();
        }
    }


}
