namespace Net2.Models
{
    public class Person 
    {
        public string Fullname { get; set; }
        public string Address {get; set; }
        public int Age { get; set; }
        public void EnterData()
        {
            System.Console.WriteLine("Full name =");
            Fullname = Console.ReadLine();
            System.Console.WriteLine("Address = ");
            Address = Console.ReadLine();
            System.Console.WriteLine("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2}", Fullname, Address, Age);
        }
    }

}