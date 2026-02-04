using System;
class Calculator
{
    public int Add(int a,int b)
    {
        return a+b;
    }
    public int Add(int a,int b,int c)
    {
        return a+b+c;
    }
}
class Program
{
    static void Main(string []args)
    {
        Calculator var = new Calculator();
        Console.WriteLine(var.Add(12, 10, 8)); // Output: 30
        Console.WriteLine(var.Add(22, 8));     // Output: 30
    }    
}