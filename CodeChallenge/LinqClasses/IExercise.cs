namespace LinqClasses
{
    internal interface IExercise
    {
        void PrepareData();
        string ShowData(object objectToParse);
        string Execute();
    }
}
