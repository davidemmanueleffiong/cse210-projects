
public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Constructor 1: Default fraction (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: Receives only the numerator
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: Receives numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for numerator
    public int GetTop()
    {
        return _top;
    }

    // Setter for numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for denominator
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction as text
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the fraction as a decimal
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
