using System.Drawing;

public class Rectangle
{
    /// <summary>
    /// width of the rectangle. 
    /// </summary>
    private int width;

    /// <summary>
    /// height of the rectangle.
    /// </summary>
    private int height;

    /// <summary>
    /// Constructor for class Rectangle.
    /// It's the only way to create an instance of this class.
    /// </summary>
    /// <param name="width">width of the rectangle.</param>
    /// <param name="height">height of the rectangle.</param>
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }


    public Rectangle(int width, int height, Color color) : this(width, height)
    {
        this.color = color;
    }

}
