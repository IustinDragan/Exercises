namespace GenericsExercises.Ex5;

public class CompareStringProgram : IMyGenericInterface<string>
{
    public void CompareMethode(string input1, string input2)
    {
        if (input1.Length > input2.Length)
            Console.WriteLine($"First word: {input1} is greater than second word: {input2}");
        else
            Console.WriteLine($"Second word: {input2} is greater than first word: {input1}");
    }
}