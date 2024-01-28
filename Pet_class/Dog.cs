namespace Pet_class;

public class Dog : Pet  // Arver fra Pet-klassen.
{
    // Konstruktør for Dog som kaller baseklassens konstruktør med 'name' og setter spesifikke egenskaper for en hund.
    public Dog(string name) : base(name)
    {
        Description = "A Black Dog";  // Settes spesifikk beskrivelse for Dog.
        Trick = "Piss you off, but less than a cat";  // Definerer et triks som er spesifikt for Dog.
        Noise = "Bark";  // Angir lyden en hund lager.
    }

    // Implementerer den abstrakte metoden MakeNoise fra Pet-klassen, spesifikt for Dog.
    public override void MakeNoise()
    {
        Console.WriteLine($"Dog {Name} Make Noise: {Noise}");
    }
}