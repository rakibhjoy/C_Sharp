using System;


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
        public Course(string courseName, string courseCode, int courseCredit)
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
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CourseCredit { get; set; }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course_Name:" + GetcourseName());
            Console.WriteLine("Course_Code:" + GetcourseCode());
            Console.WriteLine("Course_Credit:" + GetcourseCredit()+"\n");


        }
        

    }
}
