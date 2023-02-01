namespace Task1
{
    /*Створіть масив об&#39;єктів класу Співробітник. Реалізуйте
інтерфейс IComparable для порівняння співробітників за віком
в методі CompareTo().*/

    public class Persona : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Persona(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public int CompareTo(object pers)
        {
            Persona p = (Persona)pers;
            if (this.Age > p.Age) return 1;
            if (this.Age < p.Age) return -1;
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[5];
            personas[0] = new Persona("Tom", 23);
            personas[1] = new Persona("Bom", 20);
            personas[2] = new Persona("Tomas", 18);
            personas[3] = new Persona("Bob", 25);
            personas[4] = new Persona("Travis", 23);
            //реалізація методу CompareTo потрібна для сортування
            Array.Sort(personas);
            foreach (var p in personas)
                Console.WriteLine($"{p.Name}, {p.Age}");
        }
    }

}