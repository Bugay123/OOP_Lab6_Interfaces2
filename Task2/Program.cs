using System.Collections;

namespace Task2;

/*Реалізуйте в класі інтерфейс IComparer для порівняння
співробітників не тільки за віком, але і за стажем роботи на
цьому підприємстві.*/

public class Persona
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Exp { get; set; }
    public Persona(string n, int a, int e)
    {
        Name = n;
        Age = a;
        Exp = e;
    }

    public class SortByAge : IComparer
    {
        //Сортування за віком
        int IComparer.Compare(object ob1, object ob2)
        {
            Persona p1 = (Persona)ob1;
            Persona p2 = (Persona)ob2;
            if (p1.Age > p2.Age) return 1;
            if (p1.Age < p2.Age) return -1;
            return 0;
        }
    }
    public class SortByExp : IComparer
    {
        // сортування за стажем

        public int Compare(object x, object y)
        {
            Persona p1 = (Persona)x;
            Persona p2 = (Persona)y;
            if (p1.Exp > p2.Exp) return 1;
            if (p1.Exp < p2.Exp) return -1;
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[5];
            personas[0] = new Persona("Tom", 23, 3);
            personas[1] = new Persona("Bom", 20, 1);
            personas[2] = new Persona("Tomas", 18, 1);
            personas[3] = new Persona("Bob", 25, 6);
            personas[4] = new Persona("Travis", 23, 5);
            //сортування
            Console.WriteLine("Сортування за віком:");
            Array.Sort(personas, new Persona.SortByAge());
            foreach (Persona p in personas)
                Console.WriteLine($"{p.Name},{p.Age}");

            Console.WriteLine("Сортування за стажем:");
            Array.Sort(personas, new Persona.SortByExp());
            foreach (Persona p in personas)
                Console.WriteLine($"{p.Name},{p.Exp}");

        }
    }
}
