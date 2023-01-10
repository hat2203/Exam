using Exam.ex1;
using Exam.ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder c = new Cylinder();
            c.Input();
            c.Result();

            Animal an = new Animal(100, "Lion");
            an.Show();
            Animal am = new Animal(120, "Tiger");
            am.Show();
        }
    }
}
