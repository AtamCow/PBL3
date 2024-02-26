using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Model.School
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        public string Name { get; set; }
        public string CourseName { get; set; }

        [ForeignKey("OwnedTeacher")]
        public int OwnedTeacherId { get; set; }
        public virtual User? OwnedTeacher { get; set; }

        public virtual ICollection<ClassStudent> Students { get; set; }
        
        public int StudentsCount => Students?.Count ?? 0;

        public bool IsDeleted { get; set; }

        public Class()
        {
            Students = new HashSet<ClassStudent>();
        }

    }
    public class ClassStudent
    {
        [Key]
        public int ClassStudentId { get; set; }

        [ForeignKey("Class")]
        public int ClassId { get; set; }

        [ForeignKey("Student")]
        public int UserId { get; set; }

        public virtual Class Class { get; set; }
        public virtual User Student { get; set; }
    }
}
