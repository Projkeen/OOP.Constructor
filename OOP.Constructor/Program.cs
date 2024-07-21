public class Person
{
    public string Name;
    public int Age;

    //constructor: it has the same name as a Class, doesn't contain any return type
    public Person()
    {
        Console.WriteLine("Вызов конструктора");

    }
}

public class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Age = 1;
        Console.WriteLine("Age: " + person.Age);
    }
}