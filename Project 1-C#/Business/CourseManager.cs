using Project_1_C_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_C_.Business;

public class CourseManager
{
    Courses[] courses = new Courses[3];
        //Constructor
    public CourseManager()
    {
        Courses course1 = new Courses();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ". NET 8 vs...";
        course1.Price = 10;

        Courses course2 = new Courses();
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = "JAVA 17...";
        course2.Price = 20;

        Courses course3 = new Courses();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12...";
        course3.Price = 30;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
    public Courses[] GetAll()
    {
        //Veri Kaynağından Çekilir.
        Console.WriteLine("Kurslar Listelendi.");
        return courses;
    }


}
