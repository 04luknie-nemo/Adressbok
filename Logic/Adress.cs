using Adressbok.Logic;

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
}