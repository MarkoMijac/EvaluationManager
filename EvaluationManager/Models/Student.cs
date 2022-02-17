using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationManager.Models
{
    public enum StudentStatus
    {
        Upisan,
        ImaPotpis,
        NemaPotpis
    }

    public class Student : Person
    {
        public List<Evaluation> Evaluations { get; set; }
        public int? FinalGrade { get; set; }
        public StudentStatus Status { get; set; }

        public int CalculateTotalPoints()
        {
            int totalPoints = 0;

            foreach (var evaluation in Evaluations)
            {
                totalPoints += evaluation.Points;
            }

            return totalPoints;
        }

        public bool HasSignature()
        {
            foreach (var evaluation in Evaluations)
            {
                if (evaluation.IsSufficientForSignature() == false)
                {
                    return false;
                }
            }

            return true;
        }

        public bool HasGrade()
        {
            foreach (var evaluation in Evaluations)
            {
                if(evaluation.IsSufficientForGrade() == false)
                {
                    return false;
                }
            }

            return true;
        }

        public int? CalculateGrade()
        {
            int? grade = null;

            if(HasGrade() == true)
            {
                int totalPoints = CalculateTotalPoints();

                if (totalPoints >= 91)
                {
                    grade = 5;
                }
                else if (totalPoints >= 76)
                {
                    grade = 4;
                }
                else if (totalPoints >= 61)
                {
                    grade = 3;
                }
                else if (totalPoints >= 50)
                {
                    grade = 2;
                }
                else
                {
                    grade = 1;
                }
            }

            return grade;
        }
    }
}
