using question_4;

internal class Program
{



    public static void Display_info(Regtangle r)
    {
        Console.WriteLine($"height = {r.Height} , width = {r.Width},arae = {r.get_area} "); 


    }
    private static void Main(string[] args)
    {
        Regtangle r1 = new Regtangle();
        Console.WriteLine ("please enter height & width");
        double.TryParse(Console.ReadLine() , out double x );
        r1.Width = x ;
        double.TryParse(Console.ReadLine(), out double y);
        r1.Height = y;

        Display_info(r1);
    }
}