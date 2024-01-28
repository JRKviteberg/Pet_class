namespace Pet_class;

public class Dog : Pet
{
    public Dog(string name) : base(name)
    {
        Description = "A Black Dog";
        Trick = "Piss you off, but less then a cat";
        Noise = "Bark";
    }
    //Implementing abstract method to Make a Noise
    public override void MakeNoise()
    {
        Console.WriteLine($"Dog {Name} Make Noise: {Noise}");
    }
}