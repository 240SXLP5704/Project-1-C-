using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_C_.Entities;

public class Courses
{
    //Kursun Verileri
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    //Kendin hızlıca oluşturmak istersen eğer;
    //"property" ile yapabilirsin (prop)
    public double Price { get; set; }
    
}
