public class Rectangle : Shape
{
    private double _lenght = 0;
    private double _width = 0;

    public double GetLenght()
    {
        return _lenght;
    }
    public void SetLenght(double lenght)
    {
        _lenght = lenght;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth (double width)
    {
        _width = width;
    }
    public override double GetArea()
    {
        return _lenght * _width;
    }
}