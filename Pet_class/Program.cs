namespace Pet_class;

class Program
{
    static void Main()
    {
        List<Pet> myPets = new List<Pet>();  // Oppretter en liste for å holde på kjæledyrene.
        
        // Oppretter kjæledyr (objekter) av forskjellige typer.
        Pet fish = new Fish("Bob");
        Pet cat = new Cat("Oscar");
        Pet dog = new Dog("Enzo");
        
        // Legger til kjæledyr i listen.
        myPets.Add(fish);
        myPets.Add(cat);
        myPets.Add(dog);
        
        // Itererer gjennom listen og kaller metoder for å vise info og lage lyd for hvert kjæledyr.
        foreach (Pet pet in myPets)
        {
            pet.ShowInfo();  // Viser informasjon om kjæledyret.
            pet.MakeNoise();  // Kjæledyret lager sin spesifikke lyd.
            Console.WriteLine();  // Legger til en tom linje for bedre lesbarhet.
        }
    }
}