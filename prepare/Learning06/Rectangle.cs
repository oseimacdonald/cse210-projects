public class Rectangle : Shape
{
    private float length;
    private float width;

    // constructor
    public Rectangle(string color, float length, float width) : base(color)
    {
        this.length = length;
        this.width = width;
    }

    // override GetArea Method
    public override float GetArea()
    {
        return length * width; // area = length * width
    }
}