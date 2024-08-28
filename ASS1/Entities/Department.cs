using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1.Entities
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey("instructor")]
        public int Ins_ID { get; set; }
        public DateTime? HiringDate { get; set; }
        public student student { get; set; }
        public Instructor instructor { get; set; }

    }
}
