using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            double currentQuality = this.Gpa * this.NumberOfCredits;
            double addedQuality = grade * courseCredits;
            double totalCredits = NumberOfCredits + courseCredits;
            double newGpa = (currentQuality + addedQuality) / (totalCredits);

            Gpa = newGpa;

            this.NumberOfCredits += courseCredits;

            // Update the appropriate properties: NumberOfCredits, Gpa
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            if (credits >= 90)
            {
                return "Senior";
            }
            else if (credits >= 60)
            {
                return "Junior";
            }
            else if (credits >= 30)
            {
                return "Sophomore";
            } else if (credits >= 0)
            {
                return "Freshman";
            } else
            {
                return "nah playa!";
            }
            // Determine the grade level of the student based on NumberOfCredits
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                Name == student.Name &&
                StudentId == student.StudentId;
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId);
        }


        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
        public override string ToString()
        {
            return $"\tStudent's name: {Name} \n" +
                $"\tStudent ID: {StudentId} \n" +
                $"\tNumber of Credits: {NumberOfCredits} \n" +
                $"\tGPA: {Gpa}";
        }

    }
}
