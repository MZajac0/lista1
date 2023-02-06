namespace Lista3
{
    public class Osoba
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PESEL { get; set; }

        public Osoba()
        {
            this.Name = "";
            this.Surname = "";
            this.PESEL = "";
        }

        public Osoba(string name, string surname, string pesel)
        {
            this.Name = name;
            this.Surname = surname;
            this.PESEL = pesel;
        }
        public Osoba(Osoba osoba)
        {
            this.Name = osoba.Name;
            this.Surname = osoba.Surname;
            this.PESEL = osoba.PESEL;
        }



    }
}
