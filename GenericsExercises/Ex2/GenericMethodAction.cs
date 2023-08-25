namespace GenericsExercises.Ex2;

public static class GenericMethodAction
{
    public static List<T> ActionMethode<T>(this List<T> input, Action<T> action)
    {
        foreach (T item in input)
        {
            action(item);
        }
        return input;
    } 
}