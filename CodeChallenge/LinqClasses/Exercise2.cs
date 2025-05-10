using System.ComponentModel.Design;
using System.Text.Json;

namespace LinqClasses
{
    public class Exercise2 : IExercise
    {
        public List<object> nestedList;
        public string Execute()
        {
            var flattenList = FlattenList(nestedList);

            return ShowData(flattenList);
        }

        private List<int> FlattenList(List<object> nestedList)
        {
            return nestedList.SelectMany(item =>
            item switch
            {
                int i => new[] { i },
                List<object> sublist => FlattenList(sublist),
                _ => Enumerable.Empty<int>()
            }).ToList(); 
        }

        public void PrepareData()
        {
            nestedList = new List<object>
            {
                new List<object> { 1, 2},
                new List<object>
                {
                    3,
                    new List<object> { 4, 5}
                    , 6

                },
                7
            };
        }

        public string ShowData(object objectToParse)
        {
            return JsonSerializer.Serialize(objectToParse);
        }
    }
}
