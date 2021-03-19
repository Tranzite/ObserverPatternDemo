using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(); // skapar en klass med namnet Subject och ett objekt med namnet subject som säger att det skall skapas ett nytt object inom klassen Subject.?

            Observer observer1 = new Observer("Observer 1"); // samma princip gäller här då klassen Observer skapas och lägger in objektet observer1 i klassen Observer
            subject.Subscribe(observer1); // objektet subject använder en funktion "Subscribe" som ska ta in objektet observer1

            Observer observer2 = new Observer("Observer 2"); // samma sak som på rad 11
            subject.Subscribe(observer2);

            subject.Inventory++;

            Observer observer3 = new Observer("Observer 3"); // samma sak som på rad 11
            subject.Subscribe(observer3);

            subject.Inventory++; // lägger till objektet subject i invetory och lägger till +1 till objektet.

            Console.ReadLine();
        }
    }
}
