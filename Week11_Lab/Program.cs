using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating the new objects
            Email e1 = new Email("Josh","Mark","Reviewing the numbers!", "Please reveiw the numbers Mark");
            Email e2 = new Email("Monica","Tom", "Cleaning the park.","Hello Tom, Lets clean that park on tuesday.");

            File f1 = new File("/system/user","This weeks homework.");
            File f2 = new File("/user/files/week","Everthing in this folder is for this week.");


            //printing the toString for the method 
            Console.WriteLine(e1.toString());
            Console.WriteLine();
            Console.WriteLine(f1.toString());

            // tesing the message 
            Console.WriteLine(ContainsKeyword(e2, "the")); // false - does not contain
            Console.WriteLine(ContainsKeyword(e2, "on")); // true - does contain 

            Console.ReadLine();
        }

        public static bool ContainsKeyword(Document docObject, string keyword)

        {

            if (docObject.toString().IndexOf(keyword, 0) >= 0)

            {

                return true;

            }

            return false;

        }
    }
}
