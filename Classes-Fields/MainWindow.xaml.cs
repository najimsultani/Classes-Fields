using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//Najim Sultani
//Classes ( Fields, Properties and Construtors )
//3-24-23
namespace Classes_Fields
{

    /// Classes are fields variables stored inlong-term memory
    /// Constructor - Defining what's needed to create an onject
    /// properties - Granting or resticting access to fields
    /// methods - Behavior utilzing class fields
    public partial class MainWindow : Window
    {
        //How we add a class 
        //right click on file under Solution and Add class
        List<Student> students = new List<Student>();

        //what is an instance
        //how do we make it
        //what does the new keyword do
        //two types of date: Value and Reference
        //instaniate
        //declare and instantiate

        //create a new Class


        public MainWindow()
        {
            InitializeComponent();

            Instructor Najim = new Instructor("Najim", "Sultani", "42948234");

            Student student = new Student("Joe", "Miller");
            SchoolClass sc = new SchoolClass(Najim, student);

            string format = sc.Instructor.FirstName + " - " + sc.Student.FirstName;

            MessageBox.Show(format);


        }
        public void Example()
        {
            //this is how you create new instance of a movie

            //new keyword means wre are creating a New object in memory
            //how do you access members of an object
            //you use the Dot .
            //Movie jurassicPark = new Movie();
            //jurassicPark.MovieName = "Jurassic Park";
            //jurassicPark.Year = 2022;
            //MessageBox.Show(jurassicPark.Year.ToString());


            //student.FirstName = "Najim";
            //student.LastName = "Sultani";
            //student.CSIGrade = 100;
            //student.GenEdGrade = 120;    



            //what is the new Student() called
            //the default constructor of student

            //what happens to the defult constructor when I make new constuctor
            //It goes alway
            //Student student2 = new Student();
            //Student student3 = new Student();
            //Student student4 = new Student();
            //Student student5 = new Student();
            //Student student6 = new Student();

            //create new instance of a student object
            Student student = new Student("Najim", "Sultani", 100, 120);
            Student student2 = new Student("Joe", "Miller");


            students.Add(student);
            students.Add(student2);

            MessageBox.Show(FormattedStudent(student));
            MessageBox.Show(FormattedStudent(student2));

        }
        public string FormattedStudent(Student student)
        {
            string studentInformation = student.FirstName + " " + student.LastName +
                " - " + student.CSIGrade + " - " + student.GenEdGrade;

            return studentInformation;
        }


    }
}
