using System.Runtime.ExceptionServices;
using Adressbok.Logic;

class Person : Entity
{
    public NameHandler Name { get; set; }
    public NumberHandler Phone { get; set; }
    public bool IsFavorite { get; set; }

    public Adress AdressTillPerson { get; set; }

    public string birthYear { get; set; }

    public Person(string firstName, string lastName)
    {
        Name = new NameHandler();
        Name.First = firstName;
        Name.Last = lastName;
        Phone = new NumberHandler(0);
    }
    public override string ToString()
    {
        return $"ID: {Id} \nNamn: {Name} \nTelefonnummer: {Phone} \nSkapad: {CreatedAt} \nUppdaterad: {UpdateAt} \nFavorit: {IsFavorite} \n{AdressTillPerson} \n{birthYear}";
    }

}
