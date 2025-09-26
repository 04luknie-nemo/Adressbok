using Adressbok.Logic;
class Program()
{
    static List<string> deletedPersons = [];
    static void Main()
    {
        List<Person> Persons = new List<Person>();

        while (true)
        {
            Console.WriteLine("\nAdressBok");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("(1) Lägg till kontakt");
            Console.WriteLine("(2) Ta bort kontakt");
            Console.WriteLine("(3) Sök kontakt");
            Console.WriteLine("(4) Lista kontakt");
            Console.WriteLine("(5) Avsluta");

            Console.WriteLine("\nGör ditt val\n");
            string Val = Console.ReadLine();

            if (Val == "1")
            {
                AddPerson(Persons);
            }
            else if (Val == "2")
            {
                RemovePerson(Persons, deletedPersons);
            }
            else if (Val == "3")
            {
                SearchPerson(Persons);
            }
            else if (Val == "4")
            {
                ListPersons(Persons);
            }
            else if (Val == "5")
            {
                Environment.Exit(0);
            }
        }

        // MenyVal
        static void AddPerson(List<Person> nyKontakt)
        {
            Console.WriteLine("\nFörnamn: ");
            string firstNameInput = Console.ReadLine();

            Console.WriteLine("\nEfternamn: ");
            string lastNameInput = Console.ReadLine();

            Console.WriteLine("\nTelefonnummer: ");
            var nummerInput = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLägg till adress");
            string adress = Console.ReadLine();

            Console.WriteLine("\nFödelsedatum: ");
            string birthYearInput = Console.ReadLine();

            Adress minAdress = new Adress(adress);

            Person kontakt = new Person(firstNameInput, lastNameInput);

            kontakt.Phone.Nummer = nummerInput;
            kontakt.AdressTillPerson = minAdress;
            kontakt.birthYear = birthYearInput;

            nyKontakt.Add(kontakt);

            Console.WriteLine("\nVill du göra kontaken till en favorit? ja/nej");
            string favorit = Console.ReadLine();
            if (favorit == "ja" && kontakt != null)
            {
                kontakt.IsFavorite = true;

                Console.WriteLine("\nKontakten lades till!\n");
            }
            else
            {
                Console.WriteLine("\nKontakten lades till!\n");
            }
        }

        static void ListPersons(List<Person> nyKontakt)
        {
            Console.WriteLine("\nKontakter: ");
            if (nyKontakt.Count == 0)
            {
                Console.WriteLine("Inga kontakter finns :( ");
            }
            else
            {
                Console.WriteLine("-----------------------------------");

                for (int i = 0; i < nyKontakt.Count; i++)
                {
                    Console.WriteLine(nyKontakt[i]);
                    Console.WriteLine("-----------------------------------");
                }

                ChangesToPersons(nyKontakt);
            }
        }

        static void SearchPerson(List<Person> nyKontakt)
        {
            Console.WriteLine("\nSök efter Namn eller Nummer: ");
            string sökOrd = Console.ReadLine();

            bool Found = false;
            for (int i = 0; i < nyKontakt.Count; i++)
            {
                if (nyKontakt[i].Name.First == sökOrd || nyKontakt[i].Name.Last == sökOrd)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Kontakten finns med namnet: ");
                    Console.Write($"\n{i + 1}. {nyKontakt[i].Name.Full}");
                    Found = true;
                }
                else if (nyKontakt[i].Phone.Nummer.ToString() == sökOrd)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Kontakten finns med nummret: ");
                    Console.WriteLine($"\n {i + 1}. {nyKontakt[i].Phone}");
                    Found = true;
                }
            }
            if (!Found)
            {
                Console.WriteLine("\nKontakten finns inte");
            }
        }

        static void RemovePerson(List<Person> kontakter, List<string> raderadeKontakter)
        {
            Console.WriteLine("\nSkriv in hela namnet på kontakten som ska tas bort: \n");
            string raderaNamn = Console.ReadLine();

            for (int i = 0; i < kontakter.Count; i++)
            {
                if (kontakter[i].Name.Full == raderaNamn)
                {
                    kontakter.RemoveAt(i);
                    Console.WriteLine("Kontakten togs bort");
                    return; // Stoppa efter borttagning
                }
            }
            Console.WriteLine("Kontakten finns inte");
        }


        // Icke MenyVal
        static void UppdateraNamn(List<Person> nyKontakt)
        {
            Console.WriteLine("Vill du uppdatera ett namn? ja/nej");
            string uppdateraNamnSvar = Console.ReadLine();

            if (uppdateraNamnSvar == "ja")
            {
                Console.WriteLine("(F)örnamn eller (E)fternamn?");
                string FirstOrLastName = Console.ReadLine();

                if (FirstOrLastName == "f")
                {
                    Console.WriteLine("Var snäll och skriv index tack :D");
                    var uppdateraNamnIndex = Console.ReadLine();

                    Console.WriteLine("Skriv det nya Förnamnet");
                    string nyttFörNamn = Console.ReadLine();

                    if (int.TryParse(uppdateraNamnIndex, out int index) && index > 0 && index <= nyKontakt.Count)
                    {
                        nyKontakt[index - 1].Name.First = nyttFörNamn;
                        Console.WriteLine("Förnamnet har uppdaterats!");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt index");
                    }
                }
                else if (FirstOrLastName == "e")
                {
                    Console.WriteLine("Skriv indexet som hör till namnet");
                    var uppdateraNamnIndex = Console.ReadLine();

                    Console.WriteLine("Skriv det nya Efternamnet");
                    string nyttEfterNamn = Console.ReadLine();

                    if (int.TryParse(uppdateraNamnIndex, out int index) && index > 0 && index <= nyKontakt.Count)
                    {
                        nyKontakt[index - 1].Name.Last = nyttEfterNamn;
                        Console.WriteLine("Förnamnet har uppdaterats!");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt index");
                    }
                }
                else
                {
                    Console.WriteLine("Korrekt svar tack");
                }

            }
        }

        static void UppdateraNummer(List<Person> nyKontakt)
        {
            Console.WriteLine("Vill du uppdatera ett telefonnummer? ja/nej");
            string uppdateraNummerSvar = Console.ReadLine();

            if (uppdateraNummerSvar == "ja")
            {
                Console.WriteLine("Skriv indexet som hör till nummret: ");
                var uppdateraNummerIndex = Console.ReadLine();

                Console.WriteLine("Skriv det nya nummret: ");
                var nyttNummer = Console.ReadLine();

                if (int.TryParse(uppdateraNummerIndex, out int index) && index > 0 && index <= nyKontakt.Count)
                {
                    nyKontakt[index - 1].Phone.Nummer = int.Parse(nyttNummer);
                    Console.WriteLine("Telefonnumret har uppdaterats");
                }
                else
                {
                    Console.WriteLine("Ogiltigt index");
                }
            }
        }

        static void TaBortFavorit(List<Person> nyKontakt)
        {
            Console.WriteLine("Vill du ta bort en favorit? ja/nej");
            string taBortFavo = Console.ReadLine();

            if (taBortFavo == "ja")
            {
                Console.WriteLine("Ange index till kontakten");
                var taBortFavoIndex = Console.ReadLine();

                if (int.TryParse(taBortFavoIndex, out int index) && index > 0 && index <= nyKontakt.Count)
                {
                    nyKontakt[index - 1].IsFavorite = false;
                    Console.WriteLine("Favoriten togs bort");
                }
            }
            else if (taBortFavo == "nej")
            {
                Console.WriteLine("Okej tack!");
            }
            else
            {
                Console.WriteLine("Är det så svårt att svara ja eller nej?");
            }
        }

        static void ChangesToPersons(List<Person> nyKontakt)
        {
            System.Console.WriteLine("Vill du göra någon ändring? ja/nej");
            string change = Console.ReadLine();

            if (change == "ja")
            {
                UppdateraNamn(nyKontakt);

                UppdateraNummer(nyKontakt);

                TaBortFavorit(nyKontakt);
            }
            else
            {
                System.Console.WriteLine("Okej :D");
            }
        }



    }
}
