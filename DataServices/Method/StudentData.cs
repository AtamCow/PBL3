using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Method
{
    public class StudentData
    {
        private static StudentData _obj = null;
        public static StudentData Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new StudentData();
                }
                return _obj;
            }
            private set
            {

            }
        }
        public User CreateNewStudentAccount(string FirstName, string LastName, string Identification, string Password, DateTime Birthday, Gender InGender)
        {
            // new student object
            User NewStudent = new User();
            NewStudent.InfoUpdatedAt = DateTime.Now;
            NewStudent.CreatedAt = DateTime.Now;
            NewStudent.AccRole = AccRole.Student;
            NewStudent.FirstName = FirstName;
            NewStudent.LastName = LastName;
            NewStudent.NumericIdentification = Identification;
            NewStudent.Email = "";
            NewStudent.AvatarURL = "";
            NewStudent.Gender = InGender;
            NewStudent.Birthday = Birthday;
            NewStudent.HashedPassword = Helper.HashPassword(Password);
            // call

            if (UserData.Instance.CreateNewUser(NewStudent))
                return NewStudent;

            return null;
        }
    }
}
