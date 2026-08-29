using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NPC
    {
        public string name { get; set; }
        public int age { get; set; }
        public NPC(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
