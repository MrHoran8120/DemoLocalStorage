using Blazored.LocalStorage;


namespace DemoLocalStorage
{
    public class Student
    {

       


        public static List<Student> students = new List<Student>();

        public string Name { get; set; }
        
        public int Id { get; set; }

        public DateOnly Dob { get;set;}

        public Student(string name, int id, DateOnly dob)
        {
            Name = name;
            Id = id;
            Dob = dob;
        }

        public static void printAllStudents()
        {
            foreach (var student in students)
                Console.WriteLine("Student " + student.Name);
        }

        public static string serializeStudentsList()
        {
            string serializedString = System.Text.Json.JsonSerializer.Serialize(Student.students);

            Console.WriteLine("The list is serialized to " + serializedString);
            return serializedString;
        }
        public static  void deserializeStudentListAsync(string mySerializedList)
        {
            Student.students.Clear();
            Student.students = System.Text.Json.JsonSerializer.Deserialize<List<Student>>(mySerializedList);
        }
    }
}
