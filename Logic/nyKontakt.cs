namespace Adressbok.Logic;

class Contact : Entity
{
    private string firstName;
    private string lastName;
    private string nummer;
    public bool IsFavorite { get; set; }

    public string FirstName
    {
        get { return firstName; }

        set
        {
            firstName = value;
            SetUpdatedAt();
        }
    }
    public string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            lastName = value;
            SetUpdatedAt();
        }
    }

    public string Nummer
    {
        get
        {
            return nummer;
        }
        set
        {
            nummer = value;
            SetUpdatedAt();
        }
    }
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
    public Contact(string firstName, string lastName, string nummer, string adress)
    {
        FirstName = firstName;
        LastName = lastName;
        Nummer = nummer;
    }

    public override string ToString()
    {
        return $"ID: {Id} \nNamn: {FullName} \nTelefonnummer: {Nummer} \nSkapad: {CreatedAt} \nUppdaterad: {UpdateAt} \nFavorit: {IsFavorite} \nAdress: {AdressTillPerson}";
    }
}