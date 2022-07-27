using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCollection
{
    internal class Question2
    {
        #region Take names in arraylist and print in descending order
        static void Main() { 
            ArrayList studentNames = new ArrayList();

            //for(int i = 1; ;i++)
            //{
            //    Console.WriteLine("Enter Name of Student {0} or Enter 'exit' to leave: ", i);
            //    try
            //    {
            //        string ?temp = Console.ReadLine();
            //        int p = Convert.ToInt32(temp);

            //        if (p != 0 && temp[0] != '0')
            //        {
            //            throw new Exception("Name cannot be a number");
            //        }
            //        if(temp.Equals("exit", StringComparison.OrdinalIgnoreCase))
            //        {
            //            break;
            //        }

            //        studentNames.Add(temp);
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        i--;
            //    }
            //}

            int p;

            for (int i = 1; ; i++)
            {
                Console.WriteLine("Enter Name of Student {0} or Enter 'exit' to leave: ", i);
                string temp = Console.ReadLine();
                
                try
                {
                    p = Convert.ToInt32(temp);
                }
                catch (FormatException)
                {
                    if (temp.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }

                    if(temp == null)
                    {
                        Console.WriteLine("Name cannot be NULL");
                        i--;
                        continue;
                    }

                    studentNames.Add(temp);
                    continue;
                }
                Console.WriteLine("Name cannot be Number");
                i--;
            }

            studentNames.Sort();

            Console.WriteLine("Sorted Name List: ");
            for(int i = studentNames.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(studentNames[i]);
            }
        }
        #endregion
    }
}
