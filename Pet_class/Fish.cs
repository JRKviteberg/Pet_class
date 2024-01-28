namespace Pet_class;

public class Fish : Pet
{
    public Fish(string name) : base(name)
    {
        Description = "A Colorful Fish";
        Trick = "Play Dead";
        Noise = "Blow Bubbles";
    }
    //Implementing abstract method to Make a Noise
    public override void MakeNoise()
    {
        Console.WriteLine($"Fish {Name} Make Noise: {Noise}");
    }
}