using System;

namespace LineComparisionUC1
{

    class CalculateDistance
    {
        private int x1, x2, y1, y2;
        private double dist;

        public void takeCartesiaPoint()
        {
            Console.WriteLine("Enter Points according x1 y1 x2 y2 ");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
        }
        public double computeDistance()
        {
            int temp1 = x2 - x1;
            int temp2 = y2 - y1;
            dist = Math.Pow(temp1, 2) + Math.Pow(temp2, 2);
            dist = Math.Sqrt(dist);
            return dist;
        }
      
    }

    class Program
    {

            static void Main(string[] args)
            {
                Console.WriteLine("Welcome To LineComeparison Problem");
                double line1, line2;
            CalculateDistance cd = new CalculateDistance();
                cd.takeCartesiaPoint();
                line1 = cd.computeDistance();
                Console.WriteLine("Line1 distance is " + line1);

                cd.takeCartesiaPoint();
                line2 = cd.computeDistance();
                Console.WriteLine("Line2 distance is " + line2);
                
               
            }
        
    }
}

