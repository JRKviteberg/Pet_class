namespace Pet_class;

class Program
{
    static void Main()
    {
        List<Pet> myPets = new List<Pet>();
        
        //Creating pets (objects)
        Pet fish = new Fish("Bob");
        Pet cat = new Cat("Oscar");
        Pet dog = new Dog("Enzo");
        
        //adding pets to the collection(list?)
        myPets.Add(fish);
        myPets.Add(cat);
        myPets.Add(dog);
        
        //iterating through the collection(list)
        foreach (Pet pet in myPets)
        {
            pet.ShowInfo(); // using virtual method
            pet.MakeNoise(); // using abstract method
            Console.WriteLine();
        }
    }
}