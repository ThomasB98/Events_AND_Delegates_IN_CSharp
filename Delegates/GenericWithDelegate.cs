using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int Comparison<T>(T x, T y);

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PesronSorte
    {
        public void Sort(Person[] people,Comparison<Person> comparison)
        {
            for(int i=0;i<people.Length-1;i++)
            {
                for(int j=i+1;j<people.Length;j++)
                {
                    if(comparison(people[i],people[j])>0)
                    {
                        Person temp= people[i];
                        people[i]=people[j];
                        people[j]=temp;
                    }
                }
            }
        }
    }
    internal class GenericWithDelegate
    {
        public void example()
        {
            Person[] people =
            {
                new Person{Name="Alice",Age=30},
                new Person{Name="Bob",Age=25},
                new Person{Name="Charli",Age =30}
            };

            PesronSorte pesronSorte = new PesronSorte();
            pesronSorte.Sort(people,CompareBYAge);
        }

        static int CompareBYAge(Person a, Person b)
        {
            return a.Age.CompareTo(b.Age);
        }

        static int CompareByName(Person a, Person b)
        {
            return b.Name.CompareTo(a.Name);
        }
    }
}
