public class CustomList<T>
{
    public T[] List;
    private int count;
    private int capacity;

    public int Count 
    { 
        get =>  count;  
    }
    public int Capacity 
    {
        get => capacity; 
    }

    public CustomList( )
    {
        List = new T[0];
        count = 0;
        capacity = 0;
    }

    public void Add(T item)
    {
        if (count == capacity)
        {
            int newCapacity = capacity == 0 ? 4 : capacity * 2;
            Array.Resize(ref List, newCapacity);
            capacity = newCapacity;
        }

        List[count] = item;
        count++;
    }

    public T Find(Predicate<T> match)
    {
        foreach (T item in List)
        {
            if (match(item))
            {
                return item;
            }
        }

        throw new InvalidOperationException("No matching element found."); ;
    }

    public List<T> FindAll(Predicate<T> match)
    {
        List<T> resultList = new List<T>();

        foreach (T item in List)
        {
            if (match(item))
            {
                resultList.Add(item);
            }
        }

        return resultList;
    }

    public bool Contains(T item)
    {
        return Array.IndexOf(List, item) != -1;
    }

    public bool Exists(Predicate<T> match)
    {
        foreach (T item in List)
        {
            if (match(item))
            {
                return true;
            }
        }

        return false;
    }

    public void Remove(T item)
    {
        int index = Array.IndexOf(List, item);

        if (index != -1)
        {
            for (int i = index; i < count - 1; i++)
            {
                List[i] = List[i + 1];
            }

            count--;
        }
    }
    public IEnumerable<T> GetAllItems()
    {

        return List.Take(count);
    }


}