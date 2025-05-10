using System.Text.Json;

namespace LinqClasses
{
    public class Exercise7 : IExercise
    {
        public List<int> numbers;
        public string Execute()
        { 
            var numbersExplicit = numbers.Select(x => x.ToString().ToCharArray())
                                         .SelectMany(x => x)
                                         .GroupBy(x => x)
                                         .Select(x => new { Digit = x.Key, Count = x.Count() });

            return ShowData(numbersExplicit);
        }

        public void PrepareData()
        {
            numbers = new List<int>
            {
                123,
                456,
                123,
                567,
                89,
                0
            };
        }

        public string ShowData(object objectToParse)
        {
            return JsonSerializer.Serialize(objectToParse);
        }
    }
}
