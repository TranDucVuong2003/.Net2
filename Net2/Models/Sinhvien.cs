namespace Net2.Models;
public class Sinhvien
{
    public String Fullname { get; set; }
    public String Address { get; set; }
    public int Age { get; set; }
    public int PhoneNumber { get; set; }
    public void EnterData()
     {
            System.Console.WriteLine("Full name =");
            Fullname = Console.ReadLine();
            System.Console.WriteLine("Address = ");
            Address = Console.ReadLine();
            System.Console.WriteLine("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("PhoneNumber = ");
            PhoneNumber = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} - {3}", Fullname, Address, Age, PhoneNumber);
        }
    
}