
var compare = new Compare();

Console.WriteLine(compare.CompareEquals(1, 2));
Console.WriteLine(compare.CompareEquals("a", "b"));
Console.WriteLine(compare.CompareEquals(1d, 1.1d));


class Compare
{
    public bool CompareEquals(string a, string b)
    {
        return (a == b);
    }

    public bool CompareEquals(int a, int b)
    {
        return (a == b);
    }

    public bool CompareEquals(double a, double b)
    {
        return (a == b);
    }
}