


/**The Observer Pattern solves the problem of keeping objects in sync without 
 * tight coupling. It lets you create a subscription mechanism where one 
 * object (subject) changes state, and its dependent objects (observers) are notified 
 * automatically.

 * Key Problems it Solves:
 * Loose Coupling: Observers are decoupled from the subject.
 * Dynamic Relationships: Observers can be added or removed dynamically.
 * Automatic Updates: Observers automatically receive updates when the subject's state changes.
 
 * Practical Use Cases:
 * Event Handling Systems: Notify subscribers about events (e.g., button clicks).
 * Data Binding in UI: Sync UI elements with data changes.
 * Logging Services: Log changes in application state.using System;
*/


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatternsConsoleApp.BehaviouralDesignPatterns
{
    public class ObserverDesignPattern
    {

      /** Step 1: Define the Observer Interface
        * This interface will be implemented by all observers. 
        * Each observer will need to have an Update method that 
        * gets called when the subject's state changes.
        */
        public interface IObserver
        {
            void Update(string message);
        }

       /** Step 2: Define the Subject Interface
         * This interface declares methods to attach, detach, and notify observers. */
        public interface ISubject
        {
            void Attach(IObserver observer);
            void Detach(IObserver observer);
            void Notify(string message);

        }

       /** Step 3: Implement the Subject
         * The Subject class keeps a list of observers and provides 
         * methods to add and remove observers, as well as a method 
         * to notify them.
         */

        public class Subject : ISubject
        {
            private readonly List<IObserver> _observers = new List<IObserver>();
            private string _state;
            public string State
            {
                get => _state;
                set
                {
                    _state = value;
                    Notify(_state);
                }
            }

            public void Attach(IObserver observer)
            {
                _observers.Add(observer);
            }

            public void  Detach(IObserver observer)
            {
                _observers.Remove(observer);
            }

            public void Notify(string message)
            {
                foreach(var observer  in _observers)
                {
                    observer.Update(message);
                }
            }

          /** Implement the Observer
            * The Observer class will implement the IObserver interface and 
            * provide the functionality for the Update method.
            * */
            public class Observer: IObserver
            {
                private readonly string _name;
                public Observer(string name)
                {
                    _name = name;
                }

                public void Update(string message)
                {
                    Console.WriteLine($"Observe {_name} received message: {message}");
                }

            }
        }
    }
}
