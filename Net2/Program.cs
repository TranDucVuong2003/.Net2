using Net2.Models;
public class Program
{
    private static void Main(string[] args)
    {
        // Khoi tao 2 doi tuong class Person
        Person ps2 = new Person();
        String t = "Tran Van Bo";
        int tu = 20;
        System.Console.WriteLine("{0} sinh  nam {1}", t, ps2.GetYearOfBirth(22) );
    }
}