class Apartament 
{
    public string Surname { get; set; }

    public string Name { get; set; }

    public string NameSu { get; set; }

    public Apartament(string surname, string name, string nameSu)
    {
        Surname = surname;
        Name = name;
        NameSu = nameSu;
    }

    public Apartament()
    {
        Surname = "Unknown";
        Name = "Unknown";
        NameSu ="Unknown";
    }
}