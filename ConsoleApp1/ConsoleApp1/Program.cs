using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type baseType = typeof(User);
            if (!baseType.IsAbstract)
                throw new Exception($"{baseType.Name} type should be abstract");


            User admin = new Admin("Admin", "Joao", Gender.Male, 25);

            User moderator = new Moderator("Moderator", "Felipe", Gender.Male, 24);

            var name = admin.GetUserName();
            Console.WriteLine($"Type of user {name} is {admin.GetUserType()}");
            Console.WriteLine($"Age of user {name} is {admin.GetAge()}");
            Console.WriteLine($"Gender of user {name} is {admin.GetGender()}");

            name = moderator.GetUserName();
            Console.WriteLine($"Type of user {name} is {moderator.GetUserType()}");
            Console.WriteLine($"Age of user {name} is {moderator.GetAge()}");
            Console.WriteLine($"Gender of user {name} is {moderator.GetGender()}");
        }



    }
}

public enum Gender
{
    Male,
    Female,
    Other
}

public abstract class User
{
    public abstract string GetUserName();
    public abstract int GetAge();
    public abstract Gender GetGender();

    public abstract string GetUserType();


    public User(string type, string name, Gender gender, int age)
    {
        Type = type;
        Name = name;
        Gender = gender;
        Age = age;
    }
    public string Type { get; private set; }
    public string Name { get; private set; }
    public Gender Gender { get; private set; }
    public int Age { get; set; }

}

public  class Admin : User
{
 
    public Admin(string type, string name, Gender gender, int age) : base(type, name, gender, age)
    {
          
    }

    public override int GetAge()
    {
        return this.Age;
    }

    public override Gender GetGender()
    {
        return this.Gender;
    }

    public override string GetUserName()
    {
        return this.Name;
    }

    public override string GetUserType()
    {
        return this.Type;
    }
}

public class Moderator : User
{

    public Moderator(string type, string name, Gender gender, int age) : base(type, name, gender, age)
    {
   
    }

    public override int GetAge()
    {
        return this.Age;
    }

    public override Gender GetGender()
    {
        return this.Gender;
    }

    public override string GetUserName()
    {
        return this.Name;
    }

    public override string GetUserType()
    {
        return this.Type;
    }
}

