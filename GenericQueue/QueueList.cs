namespace GenericQueue;

/// <summary>
/// Custom Queue list class based on linked list concept.
/// </summary>
/// <typeparam name="T"></typeparam>
public class QueueList<T> where T : IQueueListComparable<T>
{
    // Head node attribute for the queue list declared
    public Node<T> head = null;

    /// <summary>
    /// Inserts node in queue with the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    public void Enqueue(T data)
    {
        Node<T> node = new Node<T>(data);
        if (head == null)
            head = node;
        else
        {
            Node<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }
    }

    /// <summary>
    /// Removes the specified object from queue.
    /// </summary>
    /// <param name="obj">The object.</param>
    public void Remove(T obj)
    {
        if (head == null)
            return;
        Node<T> temp = head;
        Node<T> prev = temp;
        if (head.data.IsEquals(obj))
        {
            head = head.next;
            return;
        }
        while (temp.data.IsEquals(obj) is false)
        {
            prev = temp;
            temp = temp.next;
            if (temp is null)
                return;
        }
        if (temp is null)
            return;
        prev.next = temp.next;
    }

    /// <summary>
    /// Gets the first node from queue.
    /// </summary>
    /// <returns>the data of the first node</returns>
    public T GetNodeFromQueue()
    {
        Node<T> node = head;
        head = head.next;
        return node.data;
    }

    // Overriding the ToString method of object class
    public override string ToString()
    {
        string info = "";
        Node<T> temp = this.head;
        if (temp == null)
        {
            return "";

        }
        while (temp != null)
        {
            info = info + temp.data + "\n";
            temp = temp.next;
        }
        return info;
    }
}
