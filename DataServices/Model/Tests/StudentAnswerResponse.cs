using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Model.Tests
{
    public class StudentAnswerResponse
    {
        [Key]
        public int StudentAnswerResponseId { get; set; }

        [ForeignKey("TestTakerResult")]
        public int TestTakerResultId { get; set; }
        public virtual TestTakerResult TestTaker { get; set; } // @FIXME name check pls

        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public virtual ICollection<SelectedAnswer> SelectedAnswers { get; set; }
        
        public StudentAnswerResponse()
        {
            SelectedAnswers = new HashSet<SelectedAnswer>();
        }
    }
    public class SelectedAnswer
    {
        [Key]
        public int SelectedAnswerId { get; set; }

        [ForeignKey("StudentAnswerResponse")]
        public int StudentAnswerResponseId { get; set; }
        public virtual StudentAnswerResponse StudentAnswerResponse { get; set; }

        public int AnswerId { get; set; }
    }
}
