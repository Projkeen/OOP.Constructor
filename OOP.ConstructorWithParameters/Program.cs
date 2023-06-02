public class Person
{
    public string Name;
    public int Age;

    //constructor: it has the same name as a Class, doesn't contain any return type
    public Person()
    {
        Console.WriteLine("Вызов конструктора");
    }

    public Person(string pName, int pAge)
    {
        Name = pName;
        Age = pAge;
    }
    public void Display()
    {
        Console.WriteLine($"name: {Name}, age: {Age}");
    }
}

public class Program
{
    static void Main()
    {
        Person person = new Person("Alexey", 30);
        person.Display();
        Person person2 = new Person();
        person2.Age = 35;
        person2.Name = "Projkeen";
        person2.Display();
    }
}