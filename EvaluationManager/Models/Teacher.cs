using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationManager.Models
{
    public class Teacher : Person
    {
        public string Username { get; set; }
        private string password;

        public bool CheckPassword(string password)
        {
            return this.password == password;
        }
    }
}
