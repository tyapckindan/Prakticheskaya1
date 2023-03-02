class Building
{
    public string Street { get; set; }
    public string Num { get; set; }
    private double square;
    public double Square
    {
        get => square;
        set
        {
            if (value <= 0)
                throw new Exception("Площадь не может быть отрицательным числом или равняться нулю!");
            else
                square = value;
        }
    }
    public double Payment { get; set; }

    public Building(double payment, double square, string num, string street)
    {
        Payment = payment;
        Square = square;
        Num = num;
        Street = street;
    }
}