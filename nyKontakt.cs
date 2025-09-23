

using System.Dynamic;

class nyKontakt
{
    private string namn;

    public string Namn
    {

        get
        {
            return namn;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                namn = value;
            }
            else
            {
                namn = "Nonamn";
            }
        }
    }

    public string Nummer { get; set; }

    public bool isFavorite { get; set; }






    // public string Namn { get; set; }
    // public string Nummer { get; set; }

    // // Konstruktor
    // public nyKontakt(string namn, string nummer)
    // {
    //     Namn = namn;
    //     Nummer = nummer;
    // }


    // Cred till macfra

    // Sättare

    // public void sättNamn(string namn) => this.namn = namn;

    // public void sättNummer(string nummer) => this.nummer = nummer;


    // // Hämtare

    // public string hämtaNamn() => this.namn;

    // public string hämtaNummer() => this.nummer;

    // public string Namn
    // {
    //     get
    //     {
    //         return namn;
    //     }
    //     set
    //     {
    //         if (!string.IsNullOrWhiteSpace(value))
    //         {
    //             namn = value;
    //         }
    //         else
    //         {
    //             namn = "Inget Namn";
    //         }
    //     }
    // }

    // public string Nummer
    // {
    //     get
    //     {
    //         return nummer;
    //     }
    //     set
    //     {
    //         if (!string.IsNullOrWhiteSpace(value))
    //         {
    //             nummer = value;
    //         }
    //         else
    //         {
    //             nummer = "Inget Nummer";
    //         }
    //     }
    // }
}