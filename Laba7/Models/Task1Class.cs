using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7.Models
{
    [Serializable]
    public struct Student
    {
        public string Name { get; set; }
        public int Group { get; set; }
        public int[] Ses { get; set; }

        public Student(string name, int group, int[] ses)
        {
            Name = name;
            Group = group;
            Ses = ses;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Group: {Group}, Ses: {string.Join(", ", Ses)}";
        }
    }
}
