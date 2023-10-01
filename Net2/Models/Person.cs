using System.Formats.Tar;

namespace Net2.Models
{
    public class Person
    {
        public string Fullname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public void EnterData()
        {
            System.Console.WriteLine("Full name =");
            Fullname = Console.ReadLine();
            System.Console.WriteLine("Address = ");
            Address = Console.ReadLine();
            System.Console.WriteLine("Age = ");

            try
            {
                // Cau lenh co the xay ra ngoai le
                Age = Convert.ToInt16(Console.ReadLine());
            }catch(Exception e){
                // Cau lenh xu li ngoai le 
                Age = 0;
            }
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2}", Fullname, Address, Age);
        }
        public void Display2(String ten, int tuoi)
        {
            System.Console.WriteLine("Sinh vien {0} - {1}", ten, tuoi);
        }
        public int GetYearOfBirth(int age)
        {
            int yearofBirth = 2023 - age;
            return yearofBirth;
        }
    }

}