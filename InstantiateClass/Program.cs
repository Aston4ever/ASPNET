namespace InstantiateClass;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<PersonModel> persons = new List<PersonModel>();
        
        PersonModel person1 = new PersonModel();
        person1.age = 20;
        person1.gender = "male";
        person1.fistName = "John";
        person1.lastName = "Doe";
        
        persons.Add(person1);

        Console.ReadLine();
    }
}