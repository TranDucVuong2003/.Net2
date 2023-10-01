using System.Net.WebSockets;

namespace Net2.Models;
public class Student
{
    public String Fullname { get; set; }
    public String Class { get; set; }
    public int Age { get; set; }
    public String PhoneNumber { get; set; }
    public void EnterData()
     {
            System.Console.WriteLine("Full name =");
            Fullname = Console.ReadLine();
            System.Console.WriteLine("Class = ");
            Class = Console.ReadLine();
            System.Console.WriteLine("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("PhoneNumber = ");
            PhoneNumber = Console.ReadLine();
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} - {3}", Fullname, Class, Age, PhoneNumber);
        }
    
}