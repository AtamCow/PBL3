using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using Microsoft.EntityFrameworkCore;

namespace OnlineExamSystem.DataServices.Method.Tests
{
    public class TestData
    {
        private ExamDbContext DB;
        private static TestData _obj = null;
        public static TestData Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new TestData();
                }
                return _obj;
            }
            private set
            {

            }
        }
        public TestData()
        {
            DB = OEDB.Instance.GetDatabaseContext();
        }
        public List<Test> GetAllTestCreatedBy(User user)
        {
            if (user == null) 
            {
                return null;
            }
            return DB.Tests.Where(Exam => Exam.Creator == user && !Exam.Deleted).ToList();
        }
        public List<Test> GetAllTestCreatedByCurrentUser()
        {
            User CurrentUser = UserData.Instance.GetCurrentUser();
            if (CurrentUser == null || CurrentUser.AccRole != AccRole.Teacher)
                return null;

            return GetAllTestCreatedBy(CurrentUser);
        }
        public bool AddNewTest(Test NewTest)
        {
            User CurrentUser = UserData.Instance.GetCurrentUser();
            if (CurrentUser == null || CurrentUser.AccRole != AccRole.Teacher)
                return false;

            NewTest.Creator = UserData.Instance.GetCurrentUser();

            DB.Tests.Add(NewTest);

            return DB.SaveChanges() > 0;
        }

        // student region
        
        public List<Test> GetAllUpcomingTestFromTakerList()
        {
            User CurrentUser = UserData.Instance.GetCurrentUser();
            if (CurrentUser == null || CurrentUser.AccRole != AccRole.Student)
                return null;

            return DB.TestTakers
                     .Include(TT => TT.Test)
                     .Where(TT => TT.Student == CurrentUser)
                     .Select(TT => TT.Test)
                     .Distinct()
                     .ToList();
        }
        public TestTaker GetUserTestTakerEntityFromTest(Test ReqTest)
        {
            User CurrentUser = UserData.Instance.GetCurrentUser();
            if (CurrentUser == null || CurrentUser.AccRole != AccRole.Student)
                return null;

            return DB.TestTakers.FirstOrDefault(TT => TT.Student == CurrentUser && TT.Test == ReqTest);
        }
        // student region

    }
}
