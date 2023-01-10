using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.ex2
{
    internal class Animal
    {
        public int Weight { get; set; }
        public string Name { get; set; }

        public Animal(int Weight, string Name)
        {
            SetMe(Weight, Name);
        }

        public void Show()
        {
            Console.WriteLine("Name: " + Name + "  ,  Weight:" + Weight);
        }

        public void SetMe(int Weight, string Name)
        {
            this.Weight = Weight;
            this.Name = Name;
        }
    }
}
