using GenericsExercises.Ex5;

namespace GenericsExercises.Ex5;
//Create a generic interface that defines a method for comparing two items of the same type.
//Implement this interface in a class that compares two items based on their length (for strings)
//or size (for collections).
public class CompareIntProgram : IMyGenericInterface<int>
{
    public void CompareMethode(int input1, int input2)
    {
        if (input1 > input2)
            Console.WriteLine($"First number: {input1} is greater than second number: {input2}");
        else
            Console.WriteLine($"Second number: {input2} is greater than first number: {input1}");
    }
}