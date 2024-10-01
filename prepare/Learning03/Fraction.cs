﻿namespace Learning03;

public class Fraction
{
    private int _top;
    private int _bottom;
    
    public Fraction()
    {
    }
    
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    
    public int GetTop()
    {
        return _top;
    }
    
    public void SetTop(int top)
    {
        _top = top;
    }
    
    public int GetBottom()
    {
        return _bottom;
    }
    
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    
    public double GetFractionValue()
    {
        return (double)_top / _bottom;
    }
}