using Net2.Models;
public class Program 
{
    private static void Main(string[] args)
    {
        // Khoi tao 2 doi tuong class Person
        Person ps1 = new Person();
        Person ps2 = new Person();
        // Gan gia tri cho thuoc tinh cua doi tuong ps1
        ps1.Fullname = "Nguyen Van A";
        ps1.Address = "Ha Noi";
        ps1.Age = 18;
        // goi phuong thuc hien thi thong bao 
        ps1.Display();
        // khoi tao doi tuong trong Student
        Student st1 = new Student();
        // Gan gtri
        st1.Fullname = "Tran Duc Vuong";
        st1.Class = "DCCTCT66A2";
        st1.PhoneNumber = "0375422346" ;
        st1.Age = 20 ;
        st1.Display();
    }
}