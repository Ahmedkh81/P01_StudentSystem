using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<Resource> Resources { get; } = new List<Resource>();
        public ICollection<Homework> Homeworks { get; } = new List<Homework>();
        public ICollection<StudentCourse> StudentCourses { get; } = new List<StudentCourse>();
    }
}
