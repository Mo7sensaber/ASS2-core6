using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1.Entities
{
    public class CourseList
    {
        [ForeignKey("Instructor")]
        public int inst_ID { get; set; }
        
        [ForeignKey("Course")]
        public int Course_ID { get; set;}
        public string? evaluate { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }

    }
}
