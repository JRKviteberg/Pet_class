namespace Pet_class;

public class Cat : Pet
{
    public Cat(string name) : base(name)
    {
        Description = "A white Cat";
        Trick = "Piss you off";
        Noise = "Mjau";
    }
    //Implementing abstract method to Make a Noise
    public override void MakeNoise()
    {
        Console.WriteLine($"Cat {Name} Make Noise: {Noise}");
    }
}