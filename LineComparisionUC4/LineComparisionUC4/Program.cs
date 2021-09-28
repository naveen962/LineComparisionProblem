using System;

using System;

namespace LineComparisionUC4
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
    }
    class Comparision : CalculateDistance
    {
        public void DisplayCompare(double line1, double line2)
        {
            if(line1==line2)
            {
                Console.WriteLine("lines are equal");
            }
           
            else
            {
                Console.WriteLine("lines are not equal");
                if (line1 > line2)
                {
                    Console.WriteLine("line1 is greater");

                }
                else if (line1 < line2)
                {
                    Console.WriteLine("line2 is greater");
                }

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
            Comparision cp = new Comparision();
            cp.DisplayCompare(line1, line2);


        }

    }
}
