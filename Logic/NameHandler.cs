
using System.Reflection.Metadata;
using Adressbok.Logic;

class NameHandler : Entity
{
    public string firstName;
    public string lastName;

    public NameHandler()
    {
        First = firstName;
        Last = lastName;
    }
    public string First
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
    public string Last
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
    public string Full
    {
        get
        {
            return $"{First} {Last}";
        }
    }
    public override string ToString()
    {
        return Full;
    }

}
