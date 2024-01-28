namespace Pet_class;

public abstract class Pet
{
    // Egenskaper som er felles for alle kjæledyr.
    public string Name { get; }  // Kjæledyrets navn, kun lesbar etter initialisering.
    public string Description { get; protected set; }  // Beskrivelse av kjæledyret, kan settes i avledede klasser.
    public string Trick { get; protected set; }  // Triks kjæledyret kan utføre, kan settes i avledede klasser.
    public string Noise { get; protected set; }  // Lyden kjæledyret lager, kan settes i avledede klasser.
    
    // Konstruktør for å sette kjæledyrets navn ved initialisering.
    protected Pet(string name)
    {
        Name = name;
    }
    
    // En virtuell metode som kan overstyrres av avledede klasser, men har også en standardimplementasjon.
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\nDescription: {Description}\nTrick: {Trick}\nNoise: {Noise}");
    }

    // En abstrakt metode som må implementeres av alle avledede klasser, tvinger dem til å definere hvordan kjæledyret lager lyd.
    public abstract void MakeNoise();
}