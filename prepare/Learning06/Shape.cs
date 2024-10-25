public abstract class Shape
{
    private string color;

    // constructor
    public Shape(string color)
    {
        this.color = color;
    }

    // getter for color
    public string GetColor()
    {
        return color;
    }

    // abstract method to calculate area
    public abstract float GetArea();

}