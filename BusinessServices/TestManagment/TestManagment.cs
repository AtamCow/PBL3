using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.DataServices.Method.Tests;

namespace OnlineExamSystem.BusinessServices.TestManagment
{
    class TestManagment
    {
        private static TestManagment _Instance = null;
        public static TestManagment Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new TestManagment();
                return _Instance;
            }
            private set
            {

            }
        }

        private List<Test> Tests = null;

        public List<Test> GetAllTestCreatedByCurrentTeacher()
        {
            Tests = TestData.Instance.GetAllTestCreatedByCurrentUser();
            return Tests;
        }
        public bool CreateNewTestFromUI(Test NewTest)
        {
            return TestData.Instance.AddNewTest(NewTest);
        }
        public bool UpdateTest(Test NewTest) 
        {
            return OEDB.Instance.Commit(); // chi can z la du
        }
        public bool DeleteTest(int Index)
        {
            foreach (var test in Tests) 
            {
                if (test.TestId == Index)
                {
                    test.Deleted = true;
                    OEDB.Instance.Commit();
                    return true;
                }
            }  
            return false;
        }
        public Test GetTestByTestID(int ID)
        {
            return Tests.Find(T => T.TestId == ID);
        }
    }
}

