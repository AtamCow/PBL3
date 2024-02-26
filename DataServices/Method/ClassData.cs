using Microsoft.EntityFrameworkCore;
using OnlineExamSystem.DataServicesLayer.Model.School;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OnlineExamSystem.DataServicesLayer
{
    public class ClassData
    {
        private ExamDbContext DB;
        private static ClassData _obj = null;
        public static ClassData Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ClassData();
                }
                return _obj;
            }
            private set
            {

            }
        }
        public ClassData() 
        {
            DB = OEDB.Instance.GetDatabaseContext();
        }
        public List<Class> GetAllClassByCurrentTeacher()
        {
            User CurrentUser = UserData.Instance.GetCurrentUser();
            if (CurrentUser == null || (AccRole)CurrentUser.AccRole != AccRole.Teacher)
                return null;

            int RequestedTeacherId = CurrentUser.UserId;

            var classes = DB.Classes
                .Where(c => c.OwnedTeacher == CurrentUser && !c.IsDeleted)
                .ToList();

            return classes;
        }
        public Class GetClassById(int RequestedClassId)
        {
            var classes = DB.Classes.FirstOrDefault(c => c.ClassId == RequestedClassId);

            if (classes == null)
                throw new NullReferenceException("GetClassById null return");

            return classes;
        }
        public bool AddNewClassByCurrentTeacher(Class NewClass)
        {
            User CurrentUser = UserData.Instance.GetCurrentUser();
            if (CurrentUser == null || (AccRole)CurrentUser.AccRole != AccRole.Teacher)
                return false;

            NewClass.OwnedTeacherId = CurrentUser.UserId;
            NewClass.OwnedTeacher = CurrentUser;
            NewClass.Students = new List<ClassStudent>();

            DB.Classes.Add(NewClass);

            return DB.SaveChanges() == 1;
        }
        public bool RemoveClassByIndex(int Index)
        {
            Class CNeededToRemove = DB.Classes.FirstOrDefault(x => x.ClassId == Index);
            CNeededToRemove.IsDeleted = true;
            return OEDB.Instance.GetDatabaseContext().SaveChanges() == 1;
        }
        public bool AddStudentToClass(Class CurrentClass, ClassStudent classStudent)
        {
            CurrentClass.Students.Add(classStudent);
            return DB.SaveChanges() == 1;
        }
    }
}
