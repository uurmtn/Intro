using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concretes
{
    public class EfCourseDal : ICourseDal
    {
        List<Course> courses;
        public EfCourseDal()
        {//Veri tabanı simule edildi.
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#2";
            course1.Description = ".Net 8";
            course1.Price = 10;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java2";
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

            courses = new List<Course> { course1, course2, course3, course4 };
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }
    }
}
