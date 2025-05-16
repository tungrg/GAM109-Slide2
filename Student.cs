using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Student(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
