using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Subject : ISubject
    {
        private List<Observer> observers = new List<Observer>(); // skapar en lista med alla observers varav det finns 3 just nu
        private int _int;

        public int Inventory // den hämtar en int variabel som har skapats privat och returnerar den, vi har en if sats som kollar ifall variabeln _int är lägre än value och ifall den är det så skall det skickas en notify metod
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }

        public void Subscribe(Observer observer) // lägger till en observer i observers som är listan.
        {
            Console.WriteLine("To subscribe type yes");
            string subscribeCheck = Console.ReadLine();
            if(subscribeCheck == "yes")
            {
                observers.Add(observer);
            }
        }

        public void Unsubscribe(Observer observer) // tar bort en observer i observers listan
        {
            observers.Remove(observer);
        }

        public void Notify() // skickar ut ett medelande till alla observers i listan. Ifall en observer har "unsubscribeat" så kommer de ej finnas med då de tagits bort från listan. 
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
