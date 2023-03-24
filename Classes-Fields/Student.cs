using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Fields
{
    public class Student
    {
        //fields
        public string FirstName;
        public string LastName;
        public double CSIGrade;
        public double GenEdGrade;



        //constructor
        //how do you create a constructoe
        //access modifer - Class Name - Parenthses
        //Default Constructor (Takes no arguments

        //constuctors allow restrict what is needed to create an object
        public Student(string firstName, string lastName, int CSI, int GenEd)
        {
            //how you assign values to fields
            FirstName= firstName;   
            LastName= lastName;
            CSIGrade= CSI;
            GenEdGrade= GenEd;
        }

        //create a second constructor
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = -1;
            GenEdGrade = -1;
        }
        //properties

        //methods



    }
}
