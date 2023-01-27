
var compareObjects = new Compare<object>();

var obj1 = new object();
var obj2 = new object();

Console.WriteLine(compareObjects.CompareEquals(obj1, obj1));

var compareInts = new Compare<int>();

Console.WriteLine(compareInts.CompareEquals(1,2));


class Compare<T>
{
    public bool CompareEquals(T a, T b)
    {
        return a.Equals(b);
    }
}