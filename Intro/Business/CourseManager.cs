using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intro.Entities;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses=new Course[4];
    public CourseManager()
    {

        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net 8";
        course1.Price = 10;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "Java 17 ....";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Phyton";
        course3.Description = "Phyton 3,12 ";
        course3.Price = 10;

        Course course4 = new Course();
        course4.Id = 4;
        course4.Name = "C++";
        course4.Description = "c++ 3,12 ";
        course4.Price = 10;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
        courses[3] = course4;   

    }
    public Course [] GetAll()
    {
        //Veri kaynağından veri çekilir
        return courses;
    }
}
