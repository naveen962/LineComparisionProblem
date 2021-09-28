using System;

namespace LineComparisionUC2
{

    class CalculateDistance
    {
        private int x1, x2, y1, y2;
        private double dist;

        public void CartesiaPoint()
        {
            Console.WriteLine("Enter Points according x1 y1 x2 y2 ");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
        }
        public double LengthCalculation()
        {
            int temp1 = x2 - x1;
            int temp2 = y2 - y1;
            dist = Math.Pow(temp1, 2) + Math.Pow(temp2, 2);
            dist = Math.Sqrt(dist);
            return dist;
        }
        public void DisplayCompare(double line1,double line2)
        {
            if (line1==line2)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LineComeparison Problem");
            double line1, line2;
            CalculateDistance cd = new CalculateDistance();
            cd.CartesiaPoint();
            line1 = cd.LengthCalculation();
            Console.WriteLine("Line1 distance is " + line1);

            cd.CartesiaPoint();
            line2 = cd.LengthCalculation();
            Console.WriteLine("Line2 distance is " + line2);

            cd.DisplayCompare(line1, line2);


        }

    }
}

