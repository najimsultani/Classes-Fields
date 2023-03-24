using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Classes_Fields
{
    public class Instructor
    {
        //Fields
        string _firstName;
        string _lastName;
        string _phone;

        //Constructor
        public Instructor(string firstName, string lastName, string phone)
        {
            _firstName = firstName; 
            _lastName = lastName;   
            _phone = phone; 
        }

        //property

        //how do you define a property
        //Access Modifier - type of the field - name of the feild Uper case No paerentheses\
        //two new key words 
        //getter and setter
        //getter allows the user to READ the value
        //Setter allows the user to WRITE the value

        //get is used to read the information, if you only have a get - it's read only
        public string LastName
        {
            //get
            get
            {
                return _lastName;  
            }
            //get
            set
            {
                //this code block runs if the value is not empty string
                if(value != "")
                {
                    _lastName = value;    
                }
                else
                {
                    MessageBox.Show("Please Enter a valid Last Name");
                }
                //Value is the value being assigned by the user
                //lastName = value;  
            }



        }//last Name

        //string firstName;
        //string lastName;


        public string Phone
        {
            get =>  _phone;
            set => _phone = value;   
        }


        public string FirstName { 
            get => _firstName; 
            set => _firstName = value; }
    }
}
