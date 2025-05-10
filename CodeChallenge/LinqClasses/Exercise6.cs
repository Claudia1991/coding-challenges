using System.Text.Json;

namespace LinqClasses
{
    public class Exercise6 : IExercise
    {
        public List<Student> Students;
        public string Execute()
        {
            var uniqueNames = Students.DistinctBy(x => x.Name).Select(x => x.Name);

            return ShowData(uniqueNames);
        }

        public void PrepareData()
        {
            Students = new List<Student>
            {
                new Student
                {
                    Name = "Ana",
                    Grade = "A",
                    GPA = 3.5
                },
                new Student
                {
                    Name = "Ana",
                    Grade = "B",
                    GPA = 2.5
                },
                new Student
                {
                    Name = "Bob",
                    Grade = "A",
                    GPA = 3.5
                },
                new Student
                {
                    Name = "Dylan",
                    Grade = "B",
                    GPA = 3.5
                },
            };
        }

        public string ShowData(object objectToParse)
        {
            return JsonSerializer.Serialize(objectToParse);
        }
    }
}
