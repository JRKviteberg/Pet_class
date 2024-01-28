namespace Pet_class;

public class Fish : Pet  // Arver fra Pet-klassen.
{
    // Konstruktør for Fish som kaller baseklassens konstruktør med 'name' og setter spesifikke egenskaper for en fisk.
    public Fish(string name) : base(name)
    {
        Description = "A Colorful Fish";  // Settes spesifikk beskrivelse for Fish.
        Trick = "Play Dead";  // Definerer et triks som er spesifikt for Fish.
        Noise = "Blow Bubbles";  // Selv om fisk vanligvis ikke lager lyd, er dette en kreativ tilnærming.
    }

    // Implementerer den abstrakte metoden MakeNoise fra Pet-klassen, spesifikt for Fish.
    public override void MakeNoise()
    {
        Console.WriteLine($"Fish {Name} Make Noise: {Noise}");
    }
}