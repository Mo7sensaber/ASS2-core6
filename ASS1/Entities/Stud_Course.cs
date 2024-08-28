using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1.Entities
{
    public class Stud_Course
    {
        [ForeignKey("Student")]
        public int stud_ID { get; set; }
        [ForeignKey("course")]
        public int Course_ID { get; set; }
        public Char Grade { get; set; }
        public student Student { get; set; }
        public Course course { get; set; }
    }
}
