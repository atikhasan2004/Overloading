using System;
class Printer
{
    public void print (int value)
    {
        Console.WriteLine($"Integer: {value}");
    }
     public void print (string value)
    {
        Console.WriteLine($"String: {value}");
    }
}
class Program
{
    static void Main()
    {
        Printer p = new Printer();
        p.print(22);
        p.print("Salman Farshii");
    }
}