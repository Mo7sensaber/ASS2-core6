using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Duration { get; set; }
        [ForeignKey("Topic")]
        public int Top_Id { get; set; }
        public List<Stud_Course> Stud_Course { get; set; }
        public Topic Topic { get; set; }
        public List<CourseList> Courses { get; set; }

    }
}
