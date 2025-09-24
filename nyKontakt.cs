public class Contact : Entity
{
    private string firstName;

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
            SetUpdatedAt();

        }
    }
    public string LastName { get; set; }
    private string nummer;

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
    public bool isFavorite { get; set; }

    public Contact(string firstName, string lastName, string nummer)
    {
        FirstName = firstName;
        LastName = lastName;
        Nummer = nummer;
    }
}
public class Entity
{
    public int Id
    {
        get
        {
            int idSlumpare = Random.Shared.Next(1, 1000000);
            return idSlumpare;
        }
    }
    public DateTime CreatedAt;

    public Entity()
    {
        CreatedAt = DateTime.Now;
    }

    public DateTime UpdateAt { get; private set; }

    public void SetUpdatedAt()
    {
        UpdateAt = DateTime.Now;
    }
}

