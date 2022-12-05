Prototype neighbourCow = new NeighbourCow(12, 720);
Prototype neighbourCow2 = neighbourCow.Clone();
neighbourCow.Print();
neighbourCow2.Print();

Console.WriteLine("--------------------------");

Barn barn = new();
barn.capacity = 1000;
barn.hay = 100;

neighbourCow = new MyCow(9, 690, barn);
neighbourCow2 = neighbourCow.Clone();
neighbourCow.Print();
neighbourCow2.Print();

abstract class Prototype
{
    public int performance;
    public int weight;
    public abstract Prototype Clone();
    virtual public void Print()
    {
        Console.WriteLine("Литров молока в день: " + performance + "\nВес:" + weight);
    }
}

class NeighbourCow : Prototype
{

    public NeighbourCow(int performance, int weight)
    {
        this.performance = performance;
        this.weight = weight;
        
    }

    public override Prototype Clone()
    {
        return new NeighbourCow(performance, weight);
    }

}

class MyCow : Prototype
{
    public Barn Barn { get; set; }
    public MyCow(int performance, int weight, Barn barn)
    {
        this.performance = performance;
        this.weight = weight;
        Barn = barn;
    }

    public override Prototype Clone()
    {
        return new MyCow(performance, weight, Barn);
    }
    public override void Print()
    {
        Console.WriteLine("Литров молока в день: " + performance + "\nВес:" + weight + "\n" +
            @"Сарай: 
Вместимость: " + Barn.capacity + " кг" +  
"\nСено: " + Barn.hay + " кг");
    }
}
class Barn
{
    public int capacity;
    public int hay;
}