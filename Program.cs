using static DesignPatternsConsoleApp.BehaviouralDesignPatterns.ObserverDesignPattern.Subject;
using static DesignPatternsConsoleApp.BehaviouralDesignPatterns.ObserverDesignPattern;
using static DesignPatternsConsoleApp.StructuralDesignPatterns.DecoratorDesignPattern;

public class Program
{

    public static void ObservalDesignPatter()
    {
        var subject = new Subject();

        var observer1 = new Observer("Observer1");
        var observer2 = new Observer("Observer2");

        subject.Attach(observer1);
        subject.Attach(observer2);

        // Changing state
        subject.State = "State has changed!";
        // Automatically notifies all observers

        subject.Detach(observer1);

        // Changing state again
        subject.State = "Observer1 has been detached.";
        // Only notifies Observer2
    }


    public static void DecoratorDesignPattern()
    {
        ICake plainCake = new SimpleCake();
        ICake chocolateCake = new ChocolateDecorator(plainCake);
        ICake CreamCake = new CreamDecorator(chocolateCake);

        Console.WriteLine(plainCake.MakeCake());
        Console.WriteLine(chocolateCake.MakeCake());
        Console.WriteLine(CreamCake.MakeCake());
    }



    public static void Main(string[] args)
    {

        /**-----------------------Behavioural Design Patter----------------*/
        ObservalDesignPatter();


        /**-----------------------Structural Design Pattern----------------*/
        //DecoratorDesignPattern();


    }
}
