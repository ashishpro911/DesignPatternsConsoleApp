/**
 * Decorator Pattern in Simple Terms
 * Think of it like this: You have a plain cake (the base functionality), 
 * and you want to add decorations (additional behaviors) without altering 
 * the cake itself. The decorator pattern lets you wrap the cake with decorations.
 */



namespace DesignPatternsConsoleApp.StructuralDesignPatterns
{
    public class DecoratorDesignPattern
    {
        public DecoratorDesignPattern() { }

        //  Base Component(Cake) Starts
        public interface ICake
        {
            public string MakeCake();
        }

        //Base Cake Created With Simple Cake Class
        public class SimpleCake : ICake
        {
            public string MakeCake()
            {
                return "Plain Cake";
            }
        }

        //  Base Component(Cake) Ends


        //Decorator (Decorations)  -- Starts
        public class CakeDecorator : ICake
        {
            protected ICake _cake;
            public CakeDecorator(ICake cake)
            {
                _cake = cake;
            }
            public virtual string MakeCake()
            {
                return _cake.MakeCake();
            }
        } 


        public class ChocolateDecorator : CakeDecorator
        {
            public ChocolateDecorator(ICake cake) : base(cake)
            {
             
            }

            public override string MakeCake()
            {
                return base.MakeCake() + " With Chocolate";
            }
        }


        public class CreamDecorator : CakeDecorator
        {
            public CreamDecorator(ICake cake) : base(cake)
            {

            }

            public override string MakeCake()
            {
                return base.MakeCake() + " With Cream";
            }
        }

        //Decorator (Decorations)  -- Ends
        //Using These Decoration in Program .cs 
    }
}
