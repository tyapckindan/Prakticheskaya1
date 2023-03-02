internal class Program
{
    private static void Main(string[] args)
    {
        void Calculate(double square, double payment)
        {
            Console.WriteLine($"Ежемесячная плата равна: {square} * {payment} = " + square * payment);
        }

        City city = new("Лолоково");

        Building building = new(350, 1250, "117А", "Переулок Самоделкиных");

        Building BOffice = new(300, 125, "22Б", "Проспект Криворукова");

        Room room = new(22.5, 225);

        Office office = new("Пирожки", "Пирожки У Тани");

        Apartament people = new("Альбертов", "Альберт", "Альбертович");

        try
        {
            Console.Write("Введите площадь помещения: ");
            room.Square = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите площадь офиса: ");
            BOffice.Square = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Расчёт ежемесячной платы за помещение");
            Calculate(room.Square, building.Payment);

            Console.WriteLine("Расчёт ежемесячной платы за офис.");
            Calculate(BOffice.Square, BOffice.Payment);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

    }
}