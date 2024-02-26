using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Method
{
    public class TeacherData
    {
        private ExamDbContext DB;

        private static TeacherData _obj = null;
        public static TeacherData Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new TeacherData();
                }
                return _obj;
            }
            private set
            {

            }
        }
        public TeacherData()
        {
            DB = OEDB.Instance.GetDatabaseContext();
        }
        public List<User> GetAllTeacherInDB()
        {
            return DB.Users.Where(x => x.AccRole == AccRole.Teacher && x.IsDeleted == false).ToList();
        }
        public User GetTeacherByEmployeeID(string EmployeeID)
        {
            return DB.Users.FirstOrDefault(x => x.NumericIdentification == EmployeeID);
        }
        public User CreateNewTeacherAccount(
            string FirstName,
            string LastName,
            string PhoneNumber,
            string Email,
            string EmployeeNumer,
            string Password,
            DateTime Birthday,
            Gender InGender)
        {
            User NewTeacher = new User();
            NewTeacher.InfoUpdatedAt = DateTime.Now;
            NewTeacher.CreatedAt = DateTime.Now;

            NewTeacher.AccRole = AccRole.Teacher;
            NewTeacher.FirstName = FirstName;
            NewTeacher.LastName = LastName;
            NewTeacher.NumericIdentification = EmployeeNumer;
            NewTeacher.Email = Email;
            NewTeacher.AvatarURL = "";
            NewTeacher.Gender = InGender;
            NewTeacher.Birthday = Birthday;
            NewTeacher.PhoneNumber = PhoneNumber;
            NewTeacher.HashedPassword = Helper.HashPassword(Password);

            // call
            if (UserData.Instance.CreateNewUser(NewTeacher))
                return NewTeacher;

            return null;
        }
    }
}
