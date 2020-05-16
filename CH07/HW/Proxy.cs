class ProxyPattern
{
    static void Main()
    {

        Dictionary<double, double> cache = new Dictionary<double, double>();
        IArea area;

        // �Ĥ@���p��:
        area = new ProxyCalArea(cache, 5.5);
        Console.WriteLine("The area of the square is {0}", area.CalSquare());
        Console.WriteLine("");

        // �T�{Dictionary�x�s���e
        Console.WriteLine("In cache list:");
        foreach (var Item in cache)
        {
            Console.WriteLine("Side= " + Item.Key + ", Area= " + Item.Value);
        }

        // �ĤG���p��:
        Console.WriteLine("");
        area = new ProxyCalArea(cache, 5.5);
        Console.WriteLine("The area of the square is {0}", area.CalSquare());
    }
}

interface IArea
{

    double CalSquare();
}

// �N�z������
class ProxyCalArea : IArea
{
    private IArea real;
    private Dictionary<double, double> cache;
    private double side;

    public ProxyCalArea(Dictionary<double, double> cache, double side)
    {
        this.cache = cache;
        this.side = side;
        real = new realCalArea(side);
    }

    public double CalSquare()
    {
        if (cache.ContainsKey(side))
            Console.WriteLine("-- Get value from cache --");
        else
            cache.Add(side, real.CalSquare());
        return cache[side];
    }
}

// �u�ꪺ����
class realCalArea : IArea
{

    private double side;

    public realCalArea(double side)
    {
        this.side = side;
    }

    public double CalSquare()
    {
        Console.WriteLine("-- Calculated by RealObj  --");
        return side * side;
    }
}
