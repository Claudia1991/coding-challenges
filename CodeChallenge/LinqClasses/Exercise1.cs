using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace LinqClasses
{
    public class Exercise1 : IExercise
    {
        public List<Student> students;
        public string Execute()
        {
            var listGroupAndOrdered = students.OrderByDescending(x => x.GPA).GroupBy(x=>x.Grade);
            return ShowData(listGroupAndOrdered);
        }

        public void PrepareData()
        {
            students = new List<Student>
            {
                new Student{ Name = "Juan", Grade = "A", GPA= 3.8 },
                new Student{ Name = "Jose", Grade = "B", GPA= 2.8 },
                new Student{ Name = "Juana", Grade = "A", GPA= 1.9 },
                new Student{ Name = "Josefa", Grade = "C", GPA= 5.8 },
            };
        }

        public string ShowData(object objectToParse)
        {
            return JsonSerializer.Serialize(objectToParse);
        }
    }
}
