using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer
{
    public class OEDB
    {
        private static OEDB _Instance = null;
        public static OEDB Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new OEDB();
                return _Instance;
            }
            private set
            {

            }
        }
        private ExamDbContext DbCtx = null;

        private OEDB()
        {
            DbCtx = new ExamDbContext();
            InitDatabaseConnection();
        }
        public void Dummy()
        {
        }
        public ExamDbContext GetDatabaseContext()
        {
            return DbCtx;
        }
        private void InitDatabaseConnection()
        {
            var DummyQuery = DbCtx.Users.Take(1);
            foreach (var account in DummyQuery)
            {
            }
        }
        public bool Commit()
        {
            return DbCtx.SaveChanges() >= 1;
        }
    }
}
