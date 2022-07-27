using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCollection
{
    internal class Question1
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();

            int i = 0;
            Console.WriteLine("Enter 10 elements: ");
            try
            {
                for (; i < 10; i++)
                {
                    try
                    {
                        int k = int.Parse(Console.ReadLine());
                        arr.Add(k);
                    }
                    catch (FormatException ex)
                    {
                        throw (ex);
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(i > 1)
                    Console.WriteLine("\n{0} inputs successful", i);
                else
                    Console.WriteLine("\n{0} input successful", i);
            }

            arr.Sort();

            Console.WriteLine("Sorted Array: ");
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }
        }
    }
}
