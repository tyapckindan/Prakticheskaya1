class Room
{
    public int Num { get; set; }
    private double square;
    public double Square { get => square; 
        set
        {
            if (value <= 0)
                throw new Exception("Площадь не может быть отрицательным числом или равняться нулю!");
            else
                square = value;
        }
        }

    public Room(double square, int num)
    {
        Square = square;
        Num = num;
    }
}