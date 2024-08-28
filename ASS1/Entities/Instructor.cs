using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1.Entities
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int? bouns { get; set; }
        public int Salary { get; set; }
        public string? Adress { get; set; }
        public DateTime? HourRate { get; set; }
        [ForeignKey("Department")]
        public int Dept_ID { get; set;}
        public List<CourseList> Courses { get; set; }
        public Department Department { get; set; }
    }
}
