using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndFiles  //Class
{
    class Student
    {
        public string name { get; set; }  // - is private.  + is pubilc
        public int id { get;  set; }  //Use the get; and set; format to save time by default
        public static int totalstudents;  //Static variable is shared across all instances
        public DateTime enrollDate { get; set; }

        public Student(string name, int id)  : this() //Constructor.  this() calls Student() then it goes into Student(string,int)
        {
            this.name = name;     //Explicitly says this. is the instance where Name is using.
            this.id = id;
            //this.enrollDate = DateTime.Now;  //This. not needed here since it can't be confused
            totalstudents++;
        }

        public Student()  //Default constructor
        {
            name = string.Empty;    //Default empty string
            id = -1;                //Default -1
            enrollDate = DateTime.Now;
            totalstudents++;
        }


        public string getName()
        {
            return name; //Publically returns the Name of the called instance of the class
        }  //Getter

        public void setName(string name)
        {
            this.name = name;  //sets the name of the current student
        }

        public override string ToString()
        {
            //return "Programming is sooo much fun";
            return $"{name} has an id of {id}";  //changes the output
        }
    }
}
