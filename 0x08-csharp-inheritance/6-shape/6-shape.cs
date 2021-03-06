using System;

/// <summary>
/// Shape class. Shapely stuff.
/// </summary>
class Shape
{
    /// <summary>
    /// throws a NotImplementedException with message.
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}


/// <summary>
/// Rectangle class derived from Shape class.
/// </summary>
class Rectangle : Shape {
    // width of rectangle
    private int width;
    // height of rectangle
    private int height;

    /// <summary>
    /// Gets or sets field Width. Throws an exception if Width is negative.
    /// </summary>
    public int Width {
        get => width;
        set {
            if(value < 0){
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    /// <summary>
    /// Gets or sets field height. Throws an exception if height is negative.
    /// </summary>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
}