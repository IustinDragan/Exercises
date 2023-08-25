namespace GenericsExercises.Ex1;

public static class GenericList
{
    //Create a generic method that takes in a list of any type and reverses the order of the elements.
    //OBS: I'm using an extension method
    public static List<T> ReverseElements<T>(this List<T> input)
    {
        List<T> inputList = input.ToList();

        var rightPoint = inputList.Count - 1;
        var leftPoint = 0;
        
        List<T> filteredResult = new List<T>();
        int filtredIndex = inputList.Count-1;

        foreach (T element in inputList)
        {
            if (leftPoint <= rightPoint)
            {
                filteredResult.Add(inputList[filtredIndex]);
                filtredIndex--;
            }
        }
        return filteredResult;
    }
}
