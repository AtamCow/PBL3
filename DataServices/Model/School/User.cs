using OnlineExamSystem.DataServicesLayer.Model.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Model.School
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        // can be: MSSV, ma so can bo
        [Required]
        public string NumericIdentification { get; set; }

        [Required]
        public string HashedPassword { get; set; }


        public string Email { get; set; }

        [Required]
        public AccRole AccRole { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }


        public Gender Gender { get; set; }

        public DateTime Birthday { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime InfoUpdatedAt { get; set; }

        public string AvatarURL { get; set; }

        public bool IsBlocked { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        public virtual ICollection<Test> TestsCreated { get; set; }

        public User()
        {
            TestsCreated = new HashSet<Test>();
            ClassStudents = new HashSet<ClassStudent>();
        }
        public User(int id, string mSSV, string hashedPassword, string email, AccRole accRole, string firstName, string lastName, Gender gender, DateTime birthday, DateTime createdAt, DateTime infoUpdatedAt)
        {
            UserId = id;
            NumericIdentification = mSSV;
            HashedPassword = hashedPassword;
            Email = email;
            AccRole = accRole;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Birthday = birthday;
            CreatedAt = createdAt;
            InfoUpdatedAt = infoUpdatedAt;
        }
        public string GenderToString()
        {
            switch (Gender)
            {
                case Gender.None:
                    return "Không";
                case Gender.Male:
                    return "Nam";
                case Gender.Female:
                    return "Nữ";
                default:
                    return "N/A";
            }
        }
        public string AccRoleString()
        {
            AccRole x = (AccRole)Enum.ToObject(typeof(AccRole), this.AccRole);
            return x.ToString();
        }
        public string GetFirstClassName()
        {
            var firstClassStudent = ClassStudents.FirstOrDefault();
            if (firstClassStudent != null)
            {
                return firstClassStudent.Class.Name;
            }
            else
            {
                return "Không phân lớp";
            }
        }
    }
    public enum AccRole
    {
        Administrator,
        Teacher,
        Student
    }
    public enum Gender
    {
        None,
        Male,
        Female
        
    }
}
