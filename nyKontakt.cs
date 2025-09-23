using System.Security.Cryptography.X509Certificates;

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

    public Entity(int id, int idSlumpare)
    {
        id = idSlumpare;
        CreatedAt = DateTime.Now;
    }
}
public class nyKontakt : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nummer { get; set; }

    public bool isFavorite { get; set; }

    public nyKontakt(int id, int idSlumpare, string firstName, string lastName, string nummer) : base(id, idSlumpare)
    {
        FirstName = firstName;
        LastName = lastName;
        Nummer = nummer;
    }

    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}

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
