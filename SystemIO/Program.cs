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
            //const int END = 999;
            //const string DELIM = ",";

            const char DELIM = ',';
            const string FILMNAME = "EmployeeDataNZ.txt";

            Employee emp = new Employee();

            //FileStream outFile = new FileStream(FILMNAME, FileMode.Create, FileAccess.Write);

            // upper is to write , below is to read 

            FileStream inFile = new FileStream(FILMNAME, FileMode.Open, FileAccess.Read);


            //StreamWriter writer = new StreamWriter(outFile);

            //upper is to write , below is to read 

            StreamReader reader = new StreamReader(inFile);
            string recordIn;
            string[] fields;


            // Write("Enter employee number or " + END + " to quit >> ");

            //upper is to write , below is to read 

            WriteLine("\n{0,-5}{1,-12}{2,8}\n", "Num", "Name", "Salary");

            //emp.EmpNum = Convert.ToInt32(ReadLine());

            // the upper statement is a priming read – an input statement that gets a first data item or record

            recordIn = reader.ReadLine();

           /* while (emp.EmpNum != END)
            {
                Write("Enter last name >> ");
                emp.Name = ReadLine();
                Write("Enter salary >> ");
                emp.Salary = Convert.ToDouble(ReadLine());
                writer.WriteLine(emp.EmpNum + DELIM + emp.Name + DELIM + emp.Salary);
                Write("Enter next employee number or " + END + " to qoit >> ");
                emp.EmpNum = Convert.ToInt32(ReadLine());
            }*/

            while(recordIn != null)
            {
                fields = recordIn.Split(DELIM);
                emp.EmpNum = Convert.ToInt32(fields[0]);
                emp.Name = fields[1];
                emp.Salary = Convert.ToDouble(fields[2]);
                WriteLine("{0,-5}{1,-12}{2,8}",emp.EmpNum, emp.Name, emp.Salary.ToString("C"));

                recordIn = reader.ReadLine();
            }
            //writer.Close();
            //upper is to write , below is to read 
            reader.Close();

            //outFile.Close();
            //upper is to write , below is to read 
            inFile.Close();


            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //nsole.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }


    }
}
