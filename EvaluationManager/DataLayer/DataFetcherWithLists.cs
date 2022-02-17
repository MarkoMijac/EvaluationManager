using EvaluationManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationManager.DataLayer
{
    public class DataFetcherWithLists : IDataFetcher
    {
        readonly List<Student> students = new List<Student>()
        {
            new Student{ Id = 1, FirstName = "Ivan", LastName = "Hovat", Status = StudentStatus.Upisan },
            new Student{ Id = 2, FirstName = "Petar", LastName = "Novak", Status = StudentStatus.Upisan },
            new Student{ Id = 3, FirstName = "Marija", LastName = "Perić", Status = StudentStatus.Upisan },
            new Student{ Id = 4, FirstName = "Klara", LastName = "Lukić", Status = StudentStatus.Upisan },
            new Student{ Id = 5, FirstName = "Luka", LastName = "Ivanić", Status = StudentStatus.Upisan },
        };

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
