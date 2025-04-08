using System.Drawing;
internal class Program
{



    public static float Distance ( Point P1,Point P2)

    {
        return (float) (Math.Sqrt(((P2.X - P1.X) * (P2.X - P1.X)) + ((P2.Y - P1.Y) * (P2.Y - P1.Y))));
     
    }
  

    // why didnt it worked until we used static  in distance function  





    private static void Main(string[] args)
    {
        int x1, y1;
        Console.WriteLine("please enter the first point X & Y ");
        x1 = int.Parse(Console.ReadLine());
        y1 = int.Parse(Console.ReadLine());
        Point p1 = new Point(x1, y1);

        int x2, y2;
        Console.WriteLine("please enter the second point X & Y ");
         x2 = int.Parse(Console.ReadLine());
         y2 = int.Parse(Console.ReadLine());
        Point p2 = new Point(x2, y2);



        float result = Distance(p1 ,p2 );
        Console.WriteLine($"the result is {result} D"); 
    }
}