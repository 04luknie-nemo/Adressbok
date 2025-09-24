namespace Adressbok.Logic;

class Adress : Entity
{
    private string adress;

    public string AdressTillPerson
    {
        get
        {
            return adress;
        }
        set
        {
            adress = value;
            SetUpdatedAt();
        }
    }
    public Adress(string adress)
    {
        AdressTillPerson = adress;
    }
    public override string ToString()
    {
        return $"Adress: {AdressTillPerson}";
    }
}