using question_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Person [] p =
          {
            new Person ("mohamed" ,  20  ) ,
            new Person ("EZZ WALiD " , 20 ) ,
            new Person ("dad" , 55 )
          };


        foreach (Person ppp in p)
        {
            Console.WriteLine(ppp);  
        
        }


    }

}