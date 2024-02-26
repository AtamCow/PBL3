using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Method;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.BusinessServices.ClassManagment
{
    public class StudentListForDisplay
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string NumericIdentification { get; set; }
        public DateTime Birthday { get; set; }
        public string GenderText { get; set; }

        public StudentListForDisplay()
        {
        }
    }
    public class StudentListManagment
    {
        private Class CurrentClasses;

        public StudentListManagment(int ClassID)
        {
            CurrentClasses = ClassData.Instance.GetClassById(ClassID);
        }
        public List<StudentListForDisplay> GetStudentListInClass()
        {
            List<StudentListForDisplay> StudentListForDisplays = new List<StudentListForDisplay>();
            if (CurrentClasses.Students == null)
                return StudentListForDisplays;

            int i = 0;
            foreach (var classStudent in CurrentClasses.Students)
            {
                StudentListForDisplay Ens = new StudentListForDisplay();
                Ens.Index = ++i;
                Ens.Name = classStudent.Student.FirstName + " " + classStudent.Student.LastName;
                Ens.Birthday = classStudent.Student.Birthday;
                Ens.NumericIdentification = classStudent.Student.NumericIdentification;
                Ens.GenderText = classStudent.Student.GenderToString();
                StudentListForDisplays.Add(Ens);
            }
            return StudentListForDisplays;
        }
        public bool AddStudentToCurrentClass(string FirstName, string LastName, string MSSV, DateTime Birthday, Gender StdGender)
        {
            // check if student already have an account

            User Student;
            bool NewAccountCreated = false;
            string NumericIdentification = "";
            string Password = "";

            Student = UserData.Instance.GetUserByIDOrEmail(MSSV);
            if (Student == null)
            {
                // create student account first
                NumericIdentification = MSSV;
                Password = MSSV;
                Student = StudentData.Instance.CreateNewStudentAccount(FirstName, LastName, NumericIdentification, Password, Birthday, StdGender);
                if (Student == null)
                    throw new Exception("An error occured, at CreateNewStudentAccount.");

                // notify password
                NewAccountCreated = true;
            }

            // add to class
            ClassStudent classStudent = new ClassStudent
            {
                ClassId = CurrentClasses.ClassId,
                Class = CurrentClasses,
                UserId = Student.UserId,
                Student = Student
            };
            bool AddSuccess = ClassData.Instance.AddStudentToClass(CurrentClasses, classStudent);
            if (AddSuccess && NewAccountCreated)
            {
                MessageBox.Show("Đã tạo mới tài khoản học sinh\nTên đăng nhập: " + NumericIdentification + "\nMật khẩu: " + Password);
            }
            return AddSuccess;
        }

        public ClassStudent FindStudentEntry(string MSSV)
        {
            foreach (var Row in CurrentClasses.Students)
            {
                if (MSSV == Row.Student.NumericIdentification)
                    return Row;
            }
            return null;
        }
        public bool IsStudentInClass(string MSSV)
        {
            return FindStudentEntry(MSSV) != null;
        }
        public bool RemoveStudentFromCurrentClass(string MSSV)
        {
            ClassStudent Entry = FindStudentEntry(MSSV);
            if (Entry == null)
                return false;

            CurrentClasses.Students.Remove(Entry);
            return OEDB.Instance.Commit();

        }

        public string GetClassName()
        {
            return CurrentClasses.Name;
        }
        public string GetClassCourseName()
        {
            return CurrentClasses.CourseName;
        }

        public User GetUserByNumericID(string NumID)
        {
            return UserData.Instance.GetUserByIDOrEmail(NumID);
        }
    }
}
