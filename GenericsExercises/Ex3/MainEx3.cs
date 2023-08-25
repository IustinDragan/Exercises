namespace GenericsExercises.Ex3;

public static class MainEx3
{
//Create a generic class that represents a queue, where the items can be of any type.
//The class should have methods to enqueue, dequeue, and peek at the front item, as well as a method to check if the queue is empty.    
    public static void ExecuteEx3()
    {
        MyGenericClass<int> myGenericClass = new MyGenericClass<int>();

        myGenericClass.MyEnqueue(7);
        myGenericClass.MyEnqueue(8);
        myGenericClass.MyEnqueue(9);
        Console.WriteLine(myGenericClass.MyDequeue());
        Console.WriteLine(myGenericClass.MyPeek.ToString());
    }
}

