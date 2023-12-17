using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInfoSysterm.Model
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; } = "";
        public string LecturerName { get; set; } = "";
    }
}

