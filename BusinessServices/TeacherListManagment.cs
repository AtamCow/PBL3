using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExamSystem.DataServicesLayer.Method;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlineExamSystem.BusinessServicesLayer
{
    public class TeacherListForDisplay
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string EmployeeID { get; set; }
        public DateTime Birthday { get; set; }
        public string GenderText { get; set; }

        public TeacherListForDisplay()
        {
        }
    }
    public class TeacherListManagment
    {
        private static TeacherListManagment _Instance = null;
        public static TeacherListManagment Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new TeacherListManagment();
                return _Instance;
            }
            private set
            {

            }
        }

        public List<TeacherListForDisplay> GetAllTeacherForDisplay()
        {
            List<TeacherListForDisplay> TeacherList4Display = new List<TeacherListForDisplay>();

            int i = 0;
            foreach (var Teacher in TeacherData.Instance.GetAllTeacherInDB())
            {
                TeacherListForDisplay Ens = new TeacherListForDisplay();
                Ens.Index = ++i;
                Ens.Name = Teacher.FirstName + " " + Teacher.LastName;
                Ens.Birthday = Teacher.Birthday;
                Ens.EmployeeID = Teacher.NumericIdentification;
                Ens.GenderText = Teacher.GenderToString();
                TeacherList4Display.Add(Ens);
            }

            return TeacherList4Display;
        }
        public User CreateNewTeacherAccount(string FirstName,
            string LastName,
            string PhoneNumber,
            string Email,
            string EmployeeNumber,
            string Password,
            DateTime Birthday,
            Gender InGender)
        {
            // check if student already have an account
            return TeacherData.Instance.CreateNewTeacherAccount(
                FirstName,
                LastName,
                PhoneNumber,
                Email,
                EmployeeNumber,
                Password,
                Birthday,
                InGender);
        }
        public User FindTeacher(string EmployeeID)
        {
            return TeacherData.Instance.GetTeacherByEmployeeID(EmployeeID);
        }
        public bool RequestDisableListAccount(List<string> EmployeeIDSet)
        {
            foreach (string EmployeeID in EmployeeIDSet)
            {
                User Teacher = FindTeacher(EmployeeID);
                if (Teacher != null)
                    Teacher.IsDeleted = true;
            }
            return OEDB.Instance.Commit();
        }
    }
}
