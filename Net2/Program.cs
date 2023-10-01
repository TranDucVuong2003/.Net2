using Net2.Models;
public class Program
{
    private static void Main(string[] args)
    {
        Student std = new Student();
        std.EnterData();
        std.StudentCode = "123456789";
        std.Display();
    }
}