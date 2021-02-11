using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            uint age;
            String gender;
            DateTime birthday;
            string adress;
            string email;
            string fathername;
            string mothername;

            Console.WriteLine("Enter information: ");
            Console.WriteLine("------***----------");
            Console.Write("Enter student name: ");
            name = Console.ReadLine();
            Console.Write("Enter gender (male/female):");
            gender = Console.ReadLine();
            Console.Write("Enter age: ");
            age = uint.Parse(Console.ReadLine());
            Console.Write("Enter birthday (MM/dd/yyyy): ");
            birthday = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Address: ");
            adress = Console.ReadLine();
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
            Console.Write("Enter Fathername: ");
            fathername = Console.ReadLine();
            Console.Write("Enter Mothername: ");
            mothername = Console.ReadLine();

            Console.WriteLine("*** Student Information ****");
            Console.WriteLine("Student name: "+name);
            Console.WriteLine("Student age: " +age);
            Console.WriteLine("Student gender: " +gender);
            Console.WriteLine("Date of Birth: " +birthday);
            Console.WriteLine("Address: " +adress);
            Console.WriteLine("Email: " +email);
            Console.WriteLine("Student's Father name: " +fathername);
            Console.WriteLine("Student's Mother name: " +mothername);

            Console.ReadLine();
        }
    }
}
