using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }

        public Course(string topic, Teacher instructor)
        {
            Topic = topic;
            Instructor = instructor;
            this.enrolledStudents = new List<Student>();
        }

        public void Display()
        {
            string displayStuff = $" Topic: {Topic} \n\n " +
                $"Instructor: {Instructor} \n\n";
            foreach (Student student in enrolledStudents)
            {

                displayStuff += "\t" + student.ToString() + "\n\n";
            }
            Console.WriteLine(displayStuff);
        }

        public void Add(Student student)
        {
            if (!enrolledStudents.Contains(student))
            {
                this.enrolledStudents.Add(student);
            } else
            {
                Console.WriteLine("No way! You can't add a student twice.");
            }
            
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Topic == course.Topic &&
                   EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor) &&
                   EqualityComparer<List<Student>>.Default.Equals(enrolledStudents, course.enrolledStudents);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Topic, Instructor, enrolledStudents);
        }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.


        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.

        public override string ToString()
        {
            string someString = $"Topic: {Topic} \t Instructor: {Instructor} \n ";
            foreach (Student student in enrolledStudents)
            {
                
                someString += student.ToString();
            }
            return someString;
            }
        }
    }

