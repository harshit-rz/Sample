using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCollection
{
    class Student
    {
        ArrayList studentDetails;
        public Student(string name, int id, string std)
        {
            studentDetails = new ArrayList() { id, name, std };
        }
        public void Display()
        {
            Console.Write("ID: {0}, Name: {1}, Standard: {2}\n", studentDetails[0], studentDetails[1], studentDetails[2]);
        }
    }
    internal class Question5
    {
        static void Main()
        {
            Student s1 = new Student("zack", 12, "vii");
            Student s2 = new Student("skds", 891, "x");
            Student s3 = new Student("mmkaee", 4732, "viii");

            s1.Display();
            s2.Display();
            s3.Display();
        }
    }
}
