using System.Text.Json;

namespace LinqClasses
{
    public class Exercise4 : IExercise
    {
        public List<List<string>> names;
        public string Execute()
        {
            HashSet<string> duplicateNames = new HashSet<string>();
            for (int i = 0; i < names.Count-1; i++)
            {
                for (int j = i+1; j < names.Count; j++)
                {
                    foreach (var item in FindDuplicateNames(names[i], names[j]))
                    {
                        duplicateNames.Add(item);
                    }
                }
            }

            return ShowData(duplicateNames);
        }

        private List<string> FindDuplicateNames(List<string> collectionOne, List<string> collectionTwo)
        {
            return collectionOne.Intersect(collectionTwo).ToList();
        }

        public void PrepareData()
        {
            names = new List<List<string>>
            {
                new List<string>
                {
                    "Juan",
                    "Lorenzo",
                    "Fernanda"
                },
                new List<string>
                {
                    "Jose",
                    "Lorenzo",
                    "Esteban"
                },
                new List<string>
                {
                    "Pedro",
                    "Julian",
                    "Esteban"
                },
            };
        }

        public string ShowData(object objectToParse)
        {
            return JsonSerializer.Serialize(objectToParse);
        }
    }
}
