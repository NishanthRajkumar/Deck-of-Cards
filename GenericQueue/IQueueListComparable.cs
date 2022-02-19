namespace GenericQueue;

/// <summary>
/// This is interface is implemented to use QueueList class for any type
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IQueueListComparable<T>
{
    /// <summary>
    /// Determines whether the specified object is equal to the object calling IsEquals().
    /// </summary>
    /// <param name="obj">The object</param>
    /// <returns>
    ///   <c>true</c> if the specified object is equal; otherwise, <c>false</c>.
    /// </returns>
    public bool IsEquals(T obj);
}
