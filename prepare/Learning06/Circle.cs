public class Circle : Shape
{
    private float radius;

    // constructor
    public Circle(string color, float radius) : base(color)
    {
        this.radius = radius;
    }

    // override GetArea Method
    public override float GetArea()
    {
        return (float)(Math.PI * radius * radius); // Area = pie * radius^2
    }
}