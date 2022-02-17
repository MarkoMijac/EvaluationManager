using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationManager.Models
{
    public class Evaluation
    {
        public int Id { get; set; }
        public Teacher Teacher { get; set; }
        public DateTime EvaluationDate { get; set; }
        public int Points { get; set; }
        public Activity Activity { get; set; }

        public bool IsSufficientForGrade()
        {
            return Points >= Activity.MinPointsForGrade;
        }

        public bool IsSufficientForSignature()
        {
            return Points >= Activity.MinPointsForSignature;
        }
    }
}
