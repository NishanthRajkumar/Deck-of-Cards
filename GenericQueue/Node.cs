namespace GenericQueue;

/// <summary>
/// Holds node details of a node from a list.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Node<T>
{
    public T data;
    public Node<T> next;
    public Node(T data)
    {
        this.data = data;
    }
}
