namespace Pet_class;

public class Cat : Pet  // Arver fra Pet-klassen.
{
    // Konstruktør for Cat som kaller baseklassens konstruktør med 'name' og setter spesifikke egenskaper for en katt.
    public Cat(string name) : base(name)
    {
        Description = "A white Cat";  // Settes spesifikk beskrivelse for Cat.
        Trick = "Piss you off";  // Definerer et triks som er spesifikt for Cat.
        Noise = "Mjau";  // Angir lyden en katt lager.
    }

    // Implementerer den abstrakte metoden MakeNoise fra Pet-klassen, spesifikt for Cat.
    public override void MakeNoise()
    {
        Console.WriteLine($"Cat {Name} Make Noise: {Noise}");
    }
}