using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student someStudent = new Student("BananaColin", 123, 12, 3.5);
            Student anotherStudent = new Student("Dennis", 124, 12, 3.0);
            Student finalStudent = new Student("Daniel", 125, 12, 3.0);
            Teacher someDude = new Teacher("The", "Gerard", "C-Sharp", 20);
            Course newCourse = new Course("PhilosiCode", someDude);
            newCourse.Add(someStudent);
            newCourse.Add(anotherStudent);
            newCourse.Add(finalStudent);
            newCourse.Add(someStudent);

            newCourse.Display();
        }
    }
}
