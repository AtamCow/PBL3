
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OnlineExamSystem.DataServicesLayer.Model.Tests
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        public DateTime CreateTime { get; set; }
        public DateTime LastModifyTime { get; set; }

        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        public int DurationInMinutes { get; set; }

        public string JoinPassword { get; set; }

        public bool SwapQuestionAndAnswersOrder { get; set; }

        public bool AllowOnlyOneTry { get; set; }

        public bool StudentCanSeeAnswersAfterDone { get; set; }

        public bool StudentCanSeeFinalScore { get; set; }

        public bool Deleted { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        public decimal MaxScore { get; set; }


        public virtual ICollection<TestTaker> TestTakers { get; set; }

        [ForeignKey("User")]
        public int CreatorId;
        public virtual User Creator { get; set; }


        public int SubmissionCount => TestTakers?.Sum(testTaker => testTaker.TestTakerResults?.Count ?? 0) ?? 0;

        public Test()
        {
            Questions = new HashSet<Question>();
            TestTakers = new HashSet<TestTaker>();
        }

    }
}
