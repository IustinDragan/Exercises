namespace GenericsExercises.Ex3;

public class MyGenericClass<T>
{
    private List<T> _queueData = new List<T>();

    public void MyEnqueue(T item)
    {
        _queueData.Add(item);
    }

    public T MyDequeue()
    {
        if (_queueData.Count == 0)
            throw new InvalidOperationException("Queue is empty");
        
        T lastValue = _queueData[_queueData.Count - 1];
        _queueData.RemoveAt(_queueData.Count-1);
        
        return lastValue;
    }
    
    public T MyPeek { get { return _queueData[_queueData.Count - 1]; } }
}
