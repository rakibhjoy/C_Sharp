using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Course
    {
       private string courseName;
        private string courseCode;
        private int courseCredit;

       
        public Course()
        {

        }
        public Course(string courseName,string courseCode,int courseCredit)
       
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;

        }
        public void SetcourseName(string courseName)
        {
            this.courseName = courseName;
        }
        public void SetcourseCode(string courseCode)
        {
            this.courseCode = courseCode;
        }
        public void SetcourseCredit(int courseCredit)
        {
            this.courseCredit = courseCredit;
        }
        public string GetcourseName()
        {
            return courseName;
        }
        public string GetcourseCode()
        {
            return courseCode;
        }
        public int GetcourseCredit()
        {
            return courseCredit;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course_Name:" + GetcourseName());
            Console.WriteLine("Course_Code:" + GetcourseCode());
            Console.WriteLine("Course_Credit:" + GetcourseCredit());
            

        }
        public string CourseName { get;set; }
        public string CourseCode { get; set; }
        public int CourseCredit { get; set; }
       
        static void Main(string[] args)
        {
            Course c1 = new Course("C++","4433",4);           
            Course c2 = new Course();

            c2.SetcourseName("English");
            c2.SetcourseCode("4343");
            c2.SetcourseCredit(3);
            c1.ShowCourseInfo();
            Console.WriteLine("  ");
            c2.ShowCourseInfo();
            Console.WriteLine("  ");
            Console.WriteLine("  ");

            Course c4 = new Course();
            c4.CourseName="C#";
            c4.CourseCode="3232";
            c4.CourseCredit = 3;
            Console.WriteLine("Course Name: "+c4.CourseName);
            Console.WriteLine("Course Code :"+c4.CourseCode);
            Console.WriteLine("Course Credite :"+c4.CourseCredit);
            
            
            
         

            Console.ReadKey();
        }
    
    }
}
