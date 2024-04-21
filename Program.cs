namespace LinqUniversityProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBejingTech();
            //University name and student name ordered
            um.StudentAndUniversityNameCollection();

            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();
            
            foreach (int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            foreach (int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }

            Console.Write("Please enter a ID to search all students from that uni:");
            string input = Console.ReadLine();
            

            try
            {
                int inputAsInt = Convert.ToInt32(input);
                
                um.AllStudentsFromThatUni(inputAsInt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Wrong value!");
            }
            
        }
    }
}
