using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticTeh.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Surname { get; set; } 
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Dateofenrollment { get; set; }
        public string Groups { get; set; }
        public int Course { get; set; }


        public string Status { get; set; }
        public int StudentId { get; set; }
    }
}
