public class Circle : Shape
{
    public double _radius = 0;

    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return  Math.PI * (_radius * _radius);
    }
} 