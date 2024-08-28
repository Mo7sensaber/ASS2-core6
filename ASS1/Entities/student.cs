using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1.Entities
{
    public class student
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? address { get; set; }
        public int? Age { get; set; }
        [ForeignKey("departments")]
        public int Dep_Id { get; set; }
        public List<Stud_Course> studCourses { get; set; }
        public Department departments { get; set; }

    }
}
