using System; 
class AreaCalc
{
    public int Area(int side)
    {
        return side*side;//Area of a Square
    }
    public int Area(int length,int width)
    {
        return length*width;//Area of a Rectangle
    }
    
}
class Program
{
    static void Main()
    {
        AreaCalc Cal =new AreaCalc();
        Console.WriteLine($"Area of a Square: {Cal.Area(5)}");
        Console.WriteLine($"Area of a Rectangle: {Cal.Area(5,5)}");
    }
}