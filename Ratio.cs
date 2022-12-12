public sealed class Ratio
{
    private double _ratio = 1D;
    public const double Pico = 1.0 / 1000000000000;
    public const double Nano = 1.0 / 1000000000;
    public const double Micro = 1.0 / 1000000;
    public const double Milli = 1.0 / 1000;
    public const double Centi = 1.0 / 100;
    public const double Deci = 1.0 / 10;
    public const double Deca = 10.0 / 1;
    public const double Hecto = 100.0 / 1;
    public const double Kilo = 1000.0 / 1;
    public const double Mega = 1000000.0 / 1;
    public const double Giga = 1000000000.0 / 1;
    public const double Tera = 1000000000000.0 / 1;
    public const double Peta = 1000000000000000.0 / 1;
    public const double Exa = 1000000000000000000.0 / 1;

    public Ratio()
    {
    }

    public Ratio(double numerator, double denominator)
    {
        this._ratio = numerator / denominator;
    }

    public void SetRatio(double numerator, double denominator) => this._ratio = numerator / denominator;
    public void SetRatio(double ratio) => this._ratio = ratio;
    public double GetRatio() => _ratio;


    public bool RatioEqual(Ratio r) => GetRatio() == r.GetRatio();
    public bool RatioNotEqual(Ratio r) => GetRatio() != r.GetRatio();
    public bool RatioLess(Ratio r) => r.GetRatio() < GetRatio();
    public bool RatioLessEqual(Ratio r) => r.GetRatio() <= GetRatio();
    public bool RatioGreater(Ratio r) => r.GetRatio() > GetRatio();
    public bool RatioGreaterEqual(Ratio r) => r.GetRatio() >= GetRatio();

    public double RatioMultiply(Ratio r, bool changeValue = true)
    {
        var ratio = GetRatio() * r.GetRatio();

        if (changeValue)
        {
            _ratio = ratio;
        }

        return ratio;
    }

    public double RatioSubtract(Ratio r, bool changeValue = true)
    {
        var ratio = GetRatio() - r.GetRatio();

        if (changeValue)
        {
            _ratio = ratio;
        }

        return ratio;
    }


    public double RatioAdd(Ratio r, bool changeValue = true)
    {
        var ratio = GetRatio() + r.GetRatio();

        if (changeValue)
        {
            _ratio = ratio;
        }

        return ratio;
    }

    public double RatioDivide(Ratio r, bool changeValue = true)
    {
        var ratio = GetRatio() / r.GetRatio();
        if (changeValue)
        {
            _ratio = ratio;
        }

        return ratio;
    }

    private bool Equals(Ratio other)
    {
        return _ratio.Equals(other._ratio);
    }

    public override bool Equals(object obj)
    {
        return ReferenceEquals(this, obj) || obj is Ratio other && Equals(other);
    }

    public override int GetHashCode()
    {
        return _ratio.GetHashCode();
    }

    public static explicit operator double(Ratio ratio) => ratio.GetRatio();
    public static explicit operator string(Ratio ratio) => ratio.GetRatio().ToString();

    public static bool operator <=(Ratio lhs, Ratio rhs)
    {
        return lhs.GetRatio() <= rhs.GetRatio();
    }


    public static bool operator >=(Ratio lhs, Ratio rhs)
    {
        return lhs.GetRatio() >= rhs.GetRatio();
    }

    public static bool operator <(Ratio lhs, Ratio rhs)
    {
        return lhs.GetRatio() < rhs.GetRatio();
    }

    public static bool operator >(Ratio lhs, Ratio rhs)
    {
        return lhs.GetRatio() > rhs.GetRatio();
    }

    public static bool operator ==(Ratio lhs, Ratio rhs)
    {
        return lhs.GetRatio() == rhs.GetRatio();
    }

    public static bool operator !=(Ratio lhs, Ratio rhs)
    {
        return lhs.GetRatio() != rhs.GetRatio();
    }


    public static Ratio operator +(Ratio lhs, Ratio rhs)
    {
        lhs.SetRatio(lhs.GetRatio() + rhs.GetRatio());
        return lhs;
    }

    public static Ratio operator -(Ratio lhs, Ratio rhs)
    {
        lhs.SetRatio(lhs.GetRatio() - rhs.GetRatio());
        return lhs;
    }

    public static Ratio operator *(Ratio lhs, Ratio rhs)
    {
        lhs.SetRatio(lhs.GetRatio() * rhs.GetRatio());
        return lhs;
    }

    public static Ratio operator /(Ratio lhs, Ratio rhs)
    {
        lhs.SetRatio(lhs.GetRatio() / rhs.GetRatio());
        return lhs;
    }
}