using System.Security.Cryptography.X509Certificates;
using question_3;

internal class Program
{
    public static void obj_max(Person p1, Person p2, Person p3)
    {
        if (p1.age > p2.age)
            if (p1.age > p3.age)
                Console.WriteLine ( $"name : {p1.name}\tage :{p1.age}" );
            else Console.WriteLine ($"name : {p3.name}\tage :{p3.age}");
        else 
            if (p2.age >p3.age)
            Console.WriteLine ($"name : {p2.name}\tage :{p2.age}");
        else Console.WriteLine ($"name : {p3.name}\tage : {p3.age}");


    }




    private static void Main(string[] args)
    { 
    string name1, name2, name3 ; 
    int age1 , age2 , age3 ;


        Console.WriteLine("please enter person number one name & age ");
        name1 = Console.ReadLine()?? "unknowen";
        int.TryParse(Console.ReadLine(), out age1);

        Console.WriteLine("please enter person number one name & age ");
        name2 = Console.ReadLine() ?? "unknowen";
        int.TryParse(Console.ReadLine(), out age2);

        Console.WriteLine("please enter person number one name & age ");
        name3 = Console.ReadLine() ?? "unknowen";
        int.TryParse(Console.ReadLine(), out age3);

        Person p1 = new Person(name1,age1);
        Person p2 = new Person(name2,age2);
        Person p3 = new Person(name3,age3);





       obj_max(p1,p2,p3);



    }
}