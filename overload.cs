using System;

public class overload
{
    public int add(int a, int b=100)//1
    {
        return (a + b);
    }
    public int add(int a, int b, int c)//2
    {
        return (a + b + c);
    }
    public int add(double a, int b)//3
    {
        return Convert.ToInt32(a + b);
    }
    public double add(int a, double b)//4
    {
        return (a + b);
    }
    public double add(double a, double b)//5
    {
        return (a + b);
    }
    public static void Main(string []ar)
    {
        overload obj = new overload();
        Console.WriteLine(obj.add(10,20,30));//call to 2
        Console.WriteLine(obj.add(10.5,90));//call to 3
        Console.WriteLine(obj.add(10.5,20.9));//call to 5
        Console.WriteLine(obj.add(9,10.5));//call to 4
        Console.WriteLine(obj.add(10,20));//call to 1
        Console.WriteLine(obj.add(10));//call to 1
    }
}