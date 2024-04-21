using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUniversityProject
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //Adding universities

            universities.Add(new University { Id = 1, Name = "Yale" });

            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            universities.Add(new University { Id = 3, Name = "Helsinki" });



            //Adding Students

            students.Add(new Student { Id = 0, Name = "Carl", Gender = "Male", Age = 17, UniversityId = 3 });

            students.Add(new Student { Id = 1 , Name = "Carla", Gender = "Female", Age = 17, UniversityId = 1 });

            students.Add(new Student { Id = 2 , Name = "Toni", Gender = "Male", Age = 21, UniversityId = 1 });

            students.Add(new Student { Id = 3 , Name = "Pekka", Gender = "Male", Age = 23, UniversityId = 2 });

            students.Add(new Student { Id = 4 , Name = "Leyla", Gender = "Female", Age = 19, UniversityId = 2 });

            students.Add(new Student { Id = 5 , Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });

            students.Add(new Student { Id = 6, Name = "Linda", Gender = "Female", Age = 22, UniversityId = 2 });

            students.Add(new Student { Id = 7, Name = "Alexandra", Gender = "Female", Age = 25, UniversityId = 3 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
            Console.WriteLine("Male - Students: ");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }

        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "Female" select student;
            Console.WriteLine("Female - Students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }

        }
        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Students sorted by Age:");
            foreach(Student student in sortedStudents)
            {
                student.Print();
            }
        }
        public void AllStudentsFromBejingTech()
        {
            IEnumerable<Student> btjStudents = from student in students join university in universities on student.UniversityId equals university.Id where university.Name == "Beijing Tech" select student;

            Console.WriteLine("Students from Beijing Tech");
            foreach (Student student in btjStudents)
            {
                student.Print();
            }
        }
        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Student> thoseUniStudents = from student in students join university in universities on student.UniversityId equals university.Id where university.Id == Id select student;

            Console.WriteLine("Students from that uni {0}", Id);
            foreach (Student student in thoseUniStudents)
            {
                student.Print();
            }
        }
    }
}
