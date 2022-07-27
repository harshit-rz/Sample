using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCollection
{
    internal class Question3
    {
        static void Main()
        {
            #region using sortedList to store organisation data
            SortedList employeeDetails = new SortedList();
            Console.WriteLine("Enter Employee details or exit to exit:");
            for(int i = 1; ; i++)
            {
                Console.Write("Employee Code: ");
                int eCode;
                string ?temp = Console.ReadLine();
                try
                {
                    
                    if(temp == "")
                    {
                        throw new Exception("Employee Code cannot be empty");
                    }
                    if (temp.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    eCode = int.Parse(temp);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                    continue;
                }
                Console.Write("Name: ");
                string ?eName = Console.ReadLine();
                if(eName == "")
                {
                    Console.WriteLine("Name Cannot be null");
                    i--;
                    continue;
                }
                try
                {
                    employeeDetails.Add(eCode, eName);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Duplicate Employee Code");
                    i--;
                    continue;
                }
            }

            Console.WriteLine("Sorted Details");
            foreach(var k in employeeDetails.Keys) { 
                Console.WriteLine(k + " " + employeeDetails[k]);
            }
            #endregion
        }
    }
}
