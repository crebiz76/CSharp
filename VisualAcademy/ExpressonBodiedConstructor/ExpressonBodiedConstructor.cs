using System;

class Pet
{
    public string Name {get; set;}

    public Pet(string name)
    {
        Name = name;
    }
}

class ExpressonBodiedConstructor
{
    static void Main(string[] args)
    {
        Pet pet = new Pet("야옹이");
        System.Console.WriteLine(pet.Name);
    }
}
