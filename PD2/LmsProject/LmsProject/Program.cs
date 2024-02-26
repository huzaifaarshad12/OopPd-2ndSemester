using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LmsProject;

namespace LmsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ccount = 0;
            Course[] ncourses = new Course[5];
            int scount = 0;
            int tcount = 0;
            Students[] speople = new Students[5];
            Teacher[] tpeople = new Teacher[5];
            while (true)
            {
                string option = menu();
                Console.Read();
                if (option == "1")
                {
                    string role;
                    Console.WriteLine("     Sign up    ");
                    Console.WriteLine("1. Enter your Role (teacher / student)");
                    role = Console.ReadLine();
                    if(role == "teacher") 
                    {
                        tpeople[tcount] =addteacher(ref tcount);
                        Console.WriteLine("Successfully Sign Up....");
                    }
                    if(role == "student")
                    {
                        speople[scount] = addstudent(ref scount);
                        Console.WriteLine("Successfully Sign Up....");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == "2")
                {
                    
                        Console.WriteLine("\t Sign in");
                        Console.WriteLine("Enter your role(teacher / student): ");
                        string checkRole = Console.ReadLine();
                        if (checkRole == "teacher")
                        {
                            Console.WriteLine("Enter your name: ");
                            string ttname = Console.ReadLine();
                            Console.WriteLine("Enter your Password");
                            string ttpassword = Console.ReadLine();
                            for(int y =0; y < tcount; y++)
                            {
                                if (tpeople[y].tname == ttname && tpeople[y].tpassword == ttpassword) 
                                {
                                    Console.WriteLine("Successfully Sign In....");
                                    Console.ReadKey();
                                    tmenu(ref ccount,ncourses);
                                    break;
                                }
                            }
                        }
                        else if (checkRole == "student") 
                        {
                            Console.WriteLine("Enter your name: ");
                            string ssname = Console.ReadLine();
                            Console.WriteLine("Enter your Password");
                            string sspassword = Console.ReadLine();
                            for (int y = 0; y < scount; y++)
                            {
                                if (speople[y].sname == ssname && speople[y].sname == sspassword)
                                {
                                    Console.WriteLine("Successfully Sign In....");
                                    Console.ReadKey();
                                    smenu(ref ccount, ncourses, speople);
                                    break;
                                }
                            }
                        }
                    
                }
                else if (option == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
        }
        static string menu()
        {
            Console.WriteLine("1- Sign up");
            Console.WriteLine("2- Sign in");
            Console.WriteLine("3- Exit");
            Console.WriteLine("Select any option");
            string option = Console.ReadLine();
            Console.Read();
            return option;
        }
        static Students addstudent(ref int scount)
        {
            Students s1 = new Students();
            Console.WriteLine("Enter name: ");
            s1.sname = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            s1.spassword = Console.ReadLine();
            Console.WriteLine("Enter your registration number: ");
            s1.regNum = Console.ReadLine();
            scount++;
            return s1;
        }
        static Teacher addteacher(ref int tcount)
        {
            Teacher t1 = new Teacher();
            Console.WriteLine("Enter name: ");
            t1.tname = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            t1.tpassword = Console.ReadLine();
            Console.WriteLine("Enter id: ");
            t1.id = int.Parse(Console.ReadLine());
            tcount++;
            return t1;
        }
        static void smenu(ref int ccount, Course[] ncourses, Students[] speople) 
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tStudent Menu");
                Console.WriteLine("1. Offered Courses");
                Console.WriteLine("2. Current Courses");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\t Offered Courses");
                    for (int i = 0; i < ccount; i++)
                    {
                        Console.WriteLine(i + 1 + " " + ncourses[i]);
                    }
                    Console.WriteLine("Select one of the following or 0 to back");
                    int option1 = int.Parse(Console.ReadLine());
                    if (option1 == 0)
                    {
                        break;
                    }
                    else if(option1 <= ccount && option1 > 0) 
                    {
                        speople[0].id = ncourses[0].id;
                    }
                }
                else if(option == 2) 
                {
                    Console.WriteLine("\tCurrent Courses");
                    for(int i = 0;i < ccount; i++) 
                    {
                        Console.WriteLine(speople[i]);
                    }
                }
            }
        }


        static void tmenu(ref int ccount,Course[] ncourses)
        {
            Console.Clear();
            Console.WriteLine("\tTeacher Menu");
            Console.WriteLine("1. Add Couse");
            int option = int.Parse(Console.ReadLine());
            if(option == 1) 
            {
                ncourses[ccount] = addcourse(ref ccount);
            }
            else 
            {
                Console.WriteLine("Invalid input");
            }
        }

        static Course addcourse(ref int ccount) 
        {
            Console.Clear();
            Console.WriteLine("\tAdd Course");
            Course c1 = new Course();
            Console.WriteLine("Enter course name: ");
            c1.name = Console.ReadLine();
            Console.WriteLine("Enter course id: ");
            c1.id = int.Parse(Console.ReadLine());
            ccount++;
            return c1;
        }
    }
}
