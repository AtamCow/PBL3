using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.BusinessServices.ClassManagment
{
    public class ClassManagment
    {
        private static ClassManagment _Instance = null;
        public static ClassManagment Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ClassManagment();
                return _Instance;
            }
            private set
            {

            }
        }


        public List<Class> GetAllClassByCurrentTeacher()
        {
            return ClassData.Instance.GetAllClassByCurrentTeacher();
        }
        public bool AddNewClass(string ClassName, string CourseName)
        {
            // sang loc du lieu trc khi call
            if (ClassName.Length <= 0 || CourseName.Length <= 0)
                return false;

            Class NewClass = new Class();
            NewClass.Name = ClassName;
            NewClass.CourseName = CourseName;

            return ClassData.Instance.AddNewClassByCurrentTeacher(NewClass);
        }
        public bool RemoveClassByIndex(int index)
        {
            return ClassData.Instance.RemoveClassByIndex(index);
        }
        //  
    }
}
