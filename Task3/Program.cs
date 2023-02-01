using System.Collections;
using Task3;

namespace Task3;

/*Реалізуйте інтерфейс IEnumerable. Виведіть на консоль
список співробітників, впорядкований за стажем роботи.*/

class Persona : IComparable
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

    public int CompareTo(object per)
    {
        Persona p1 = (Persona)per;
        if (Exp > p1.Exp) return 1;
        if (Exp < p1.Exp) return -1;
        return 0;
    }

    public void PersInfo()
    {
        Console.WriteLine($"Name = {Name} Age = {Age} Experience = {Exp}");
    }
}

class Persons : IEnumerable
{
    private Persona[] mas;
    private int n;

    public Persons()
    {
        mas = new Persona[3];
        n = 0;
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < n; ++i) yield return mas[i];
    }
    public void Add(Persona m)
    {
        if (n >= 3) return;
        mas[n] = m;
        ++n;
    }
    public void Sort()
    {
        Array.Sort(mas);
    }

}

class Program
{
    static void Main(string[] args)
    {
        Persons pers = new Persons();
        pers.Add(new Persona("Іванов", 48, 23));
        pers.Add(new Persona("Петров", 36, 15));
        pers.Add(new Persona("Соколов", 28, 10));
        pers.Sort();
        foreach (Persona x in pers) { x.PersInfo(); }
    }

}