using System.Formats.Tar;

namespace Net2.Models
{
    public class Fruit
    {
        public string NameFruit { get; set; }
        public string Colour { get; set; }
        public int SoLuong { get; set; }
        public void EnterData()
        {
            System.Console.WriteLine("Full name =");
            NameFruit = Console.ReadLine();
            System.Console.WriteLine("Colour = ");
            Colour = Console.ReadLine();
            System.Console.WriteLine("SoLuong = ");
            SoLuong = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2}", NameFruit, Colour, SoLuong);
        }
       
    }

}