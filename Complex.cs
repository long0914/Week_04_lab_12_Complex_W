public class Complex
{
    public int Real { get; }
    public int Imaginary { get; }

    public double Modulus => Math.Sqrt(Real * Real + Imaginary * Imaginary);
    public double Argument => Math.Atan2(Imaginary, Real);

    public static Complex Zero => new Complex(0, 0);

    public Complex(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public override string ToString()
    {
        return $"({Real}, {Imaginary})";
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);
    }

    public static Complex operator -(Complex operand)
    {
        return new Complex(-operand.Real, -operand.Imaginary);
    }

    public static bool operator ==(Complex a, Complex b)
    {
        return a.Real == b.Real && a.Imaginary == b.Imaginary;
    }

    public static bool operator !=(Complex a, Complex b)
    {
        return !(a == b);
    }

    // public override bool Equals(object? obj) // Make obj nullable
    // {
    //     if (obj is Complex other)
    //     {
    //         return this == other;
    //     }
    //     return false;
    // }

    // public override int GetHashCode()
    // {
    //     return HashCode.Combine(Real, Imaginary);
    // }
}
