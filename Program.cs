CustomList<int> List = new CustomList<int>();
List.Add(1);
List.Add(2);
List.Add(3);
List.Add(4);
List.Add(5);
Console.WriteLine( "Count =>" + List.Count);
Console.WriteLine("Capacity => " + List.Capacity); 
Console.WriteLine("contains => "+List.Contains(2));
List.Remove(2);
Console.WriteLine("Count =>" + List.Count);
bool exists = List.Exists(x => x == 3);
Console.WriteLine("exits => " + exists);
Console.WriteLine("Capacity => " + List.Capacity);

foreach (var item in List.GetAllItems())
{
    Console.WriteLine("Items =>:" + item);
}
