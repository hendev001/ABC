using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samplecode
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID;
            int age;
            string Firstname;
            string LastName;
            int zip;
           
            Console.WriteLine("----- WELCOME TO Sam's Bank---- \n");
            Console.Write("enter your ID ");
            ID = Int32.Parse(Console.ReadLine());
            Console.Write("enter your age ");
            age = Int32.Parse(Console.ReadLine());
            Console.Write("enter the Firstname ");
            Firstname = Convert.ToString(Console.ReadLine());
            Console.Write("enter the Lastname ");
            LastName = Convert.ToString(Console.ReadLine());
            Console.Write("enter Zip ");
            zip = Int32.Parse(Console.ReadLine());
           
            Console.WriteLine("========info =========\n ");
            Console.WriteLine("your ID is : {0} ", ID);
            Console.WriteLine(" your age is  : {0} ", age);
            Console.WriteLine("your Firstname is : {0} ", Firstname);
            Console.WriteLine("your Lastname is : {0} \n ", LastName);
            Console.WriteLine("your Zip is : {0} \n ", zip);
         
            Console.WriteLine("========== we are here to serve you better=========="); // this will displays all the values you have entered.
            Console.ReadKey();
        }
    }
}
