using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInfoSysterm.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; } = "";
        public string City { get; set; } = "";
        public int CourseId { get; set; }
    }
}
