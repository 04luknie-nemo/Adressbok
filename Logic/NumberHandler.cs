using System.Net.WebSockets;
using Adressbok.Logic;

class NumberHandler : Entity
{
    private int nummer;

    public NumberHandler(int nummer)
    {
        Nummer = nummer;
    }
    public override string ToString()
    {
        return Nummer.ToString();
    }
    public int Nummer
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
}