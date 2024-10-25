public class Square : Shape
{
    private float side;

    // constructor
    public Square(string color, float side) : base(color)
    {
        this.side = side;
    }

    // override GetArea Method
    public override float GetArea()
    {
        return side * side; // Area = side^2
    }
}