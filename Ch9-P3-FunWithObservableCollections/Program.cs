using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9_P3_FunWithObservableCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ObserableCollection<T>

            //// Make a collection to observe and add a few Person objects.
            //ObservableCollection<Person> people = new ObservableCollection<Person>()
            //{
            //    new Person{ FirstName = "Peter", LastName = "Murphy", Age = 52 },
            //    new Person{ FirstName = "Kevin", LastName = "Key", Age = 48 },
            //    new Person{ FirstName = "Ammar", LastName = "Shaukat", Age = 26 },
            //};

            //// Wire up the CollectionChanged event.
            //people.CollectionChanged += people_CollectionChanged;

            //people.RemoveAt(1);

            //people.Add(new Person { FirstName = "faiza ", LastName = "qamar ", Age = 2 });
            //people.Add(new Person { FirstName = "faiza 2", LastName = "qamar 2", Age = 22 });

            ////ShowCurrentItems(people);

            #endregion

            #region ReadOnlyObserableCollection<T>

            //ReadOnlyObservableCollection<Person> ReadOnlyPeople = new ReadOnlyObservableCollection<Person>
            //{
            //    new Person{ FirstName = "person 1 " , LastName = "person 1 lastname " , Age = 22},
            //    new Person{ FirstName = "person 1 " , LastName = "person 1 lastname " , Age = 22},
            //};

            #endregion


            Console.ReadLine();

        }

        private static void ShowCurrentItems(ObservableCollection<Person> people)
        {
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }

        private static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("\n collection changed  event fired");

            // What was the action that caused the event?
            Console.WriteLine("Action for this event: {0}", e.Action);
            // They removed something.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();

            }
            // They added something.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                // Now show the NEW items that were inserted.
                Console.WriteLine("Here are the NEW items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }
}
