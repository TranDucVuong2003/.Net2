using System.ComponentModel.DataAnnotations;

namespace MVC.Net2.Models;
public class Food {
    [Key]
    public int ID {get; set; }
    public string Name {get; set; }
    public int SoLuong {get; set; }
    public string NguonGoc {get; set; }
}