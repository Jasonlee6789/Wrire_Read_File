using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;


namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            const int END = 999;
            const string DELIM = ",";
            const string FILMNAME = "EmployeeDataNZ.txt";

            Employee emp = new Employee();

            FileStream outFile = new FileStream(FILMNAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            Write("Enter employee number or " + END + " to quit >> ");
            emp.EmpNum = Convert.ToInt32(ReadLine());
            // the upper statement is a priming read – an input statement that gets a first data item or record
            while(emp.EmpNum != END)
            {
                Write("Enter last name >> ");
                emp.Name = ReadLine();
                Write("Enter salary >> ");
                emp.Salary = Convert.ToDouble(ReadLine());
                writer.WriteLine(emp.EmpNum + DELIM + emp.Name + DELIM + emp.Salary);
                Write("Enter next employee number or " + END + " to qoit >> ");
                emp.EmpNum = Convert.ToInt32(ReadLine());
            }
            writer.Close();
            outFile.Close();

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //nsole.WriteLine("Hello World!");
           //onsole.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        
    }
}
