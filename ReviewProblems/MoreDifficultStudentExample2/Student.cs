using System;
using System.Collections.Generic;
using System.Text;

namespace MoreDifficultStudentExample2
{
    class Student
    {
        //+ public, - minus
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }
        private double BursarBalance;

        public Student()
        {
            SoonerID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 10000;

        }

        public Student(int id, string fname, string lname, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fname;
            LastName = lname;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment(double amount)
        {
            if(amount > 0)
            {
                BursarBalance = BursarBalance - amount;
            }
            else
            {
                throw new Exception("INVALID PAYMENT AMOUNT");
            }
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }
        public override string ToString()
        {
            string result = $"{FirstName} {LastName} {SoonerID} has a {GPA.ToString("N2")} GPA and owes {BursarBalance}";
            if (IsOnProbation == true)
            {
                result += "\nIs on Probation";
            }
            else
            {
                result += "\nIs not on Probation";
            }
            return result;
        }
    }
}
