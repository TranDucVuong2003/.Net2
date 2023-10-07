using System.Xml;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Net2.Controllers;
public class StudentController : Controller
{
    public IActionResult Money()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Money(int Number1, int Number2, int Number3)
    {
        float Delta = (Number2 * Number2) - 4 * Number1 * Number3;
        string strOutput = "";
        if (Delta > 0)
        {
            double x1 = (-Number2 + Math.Sqrt(Delta)) / (2 * Number1);
            double x2 = (-Number2 - Math.Sqrt(Delta)) / (2 * Number1);
            strOutput = "X1 = " + x1 + "X2 = " + x2;
        }
        else if (Delta == 0)
        {
            double x = -Number2 / (2 * Number1);
            strOutput = "Phương trình có nghiệm kép:" + x;
        }
        else
        {
            strOutput = "Phương trình không có nghiệm thực";

        }
        ViewBag.Ketqua = strOutput;
        return View();
    }

}
