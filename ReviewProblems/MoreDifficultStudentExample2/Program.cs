using System;

namespace MoreDifficultStudentExample2
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Student myStudent = new Student(5,"Adam","Ackerman",100000);
            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            try
            {
                myStudent.MakePayment(-500);
                Console.WriteLine(myStudent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                return;
            }
        }
    }
}
