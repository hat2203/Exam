using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.ex1
{
    internal class Cylinder
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public double BaseArea { get; set; }
        public double LateralArea { get; set; }
        public double TotalArea { get; set; }
        public double Volume { get; set; }
        public Cylinder()
        {
        }
        public void Input()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Console.Write("Radius:");
            this.Radius = double.Parse(Console.ReadLine());
            Console.Write("Height:");
            this.Height = double.Parse(Console.ReadLine());
        }

        public void Process(double BaseArea, double LateralArea, double TotalArea, double Volume, double Radius, double Height)
        {
            BaseArea = (double)(Radius * Radius * Math.PI);

            LateralArea = (double)(2 * Math.PI * Radius * Height);

            TotalArea = (double)(2 * Math.PI * Radius * (Height + Radius));

            Volume = (double)(Math.PI * Radius * Radius * Height);

            return;
        }
        public void Result()
        {
            Console.WriteLine("Radius : " + Radius);
            Console.WriteLine("Height : " + Height + "\n");
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius : " + Radius + "Height : " + Height);
            Console.WriteLine("BaseArea: " + BaseArea + "" + "LateralArea: " + LateralArea + "" + "TotalArea: " + TotalArea + "" + "Volume: " + Volume);

        }
    }
}
