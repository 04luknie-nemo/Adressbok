class Program()
{
    static List<string> raderadeKontakter = [];

    static void Main()
    {
        List<Contact> kontakter = new List<Contact>();

        while (true)
        {
            Console.WriteLine("\nAdressBok");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("(1) Lägg till kontakt");
            Console.WriteLine("(2) Lista kontakter");
            Console.WriteLine("(3) Sök kontakt");
            Console.WriteLine("(4) Ta bort kontakt");
            Console.WriteLine("(5) Avsluta");

            Console.WriteLine("\nGör ditt val\n");
            string Val = Console.ReadLine();

            if (Val == "1")
            {
                LäggTillKontakt(kontakter);
            }
            else if (Val == "2")
            {
                ListaKontakter(kontakter);
            }
            else if (Val == "3")
            {
                SökKontakt(kontakter);
            }
            else if (Val == "4")
            {
                TaBortKontakt(kontakter, raderadeKontakter);
            }
            else if (Val == "5")
            {
                Environment.Exit(0);
            }
        }

        static void LäggTillKontakt(List<Contact> nyKontakt)
        {
            Console.WriteLine("\nFörnamn: ");
            string firstNameInput = Console.ReadLine();

            Console.WriteLine("\nEfternamn: ");
            string lastNameInput = Console.ReadLine();

            Console.WriteLine("\nTelefonnummer: ");
            string nummerInput = Console.ReadLine();

            Contact kontakt = new Contact(firstNameInput, lastNameInput, nummerInput);

            nyKontakt.Add(kontakt);

            Console.WriteLine("\nVill du göra kontaken till en favorit? ja/nej");
            string favorit = Console.ReadLine();
            if (favorit == "ja")
            {
                kontakt.isFavorite = true;

                Console.WriteLine("\nKontakten lades till!\n");
            }
            else
            {
                Console.WriteLine("\nKontakten lades till!\n");
            }
        }

        static void ListaKontakter(List<Contact> nyKontakt)
        {
            Utskrift(nyKontakt);

            UppdateraNamn(nyKontakt);

            UppdateraNummer(nyKontakt);

            TaBortFavorit(nyKontakt);

            Console.ReadLine();

            if (nyKontakt.Count == 0)
            {
                Console.WriteLine("\nIngen kontakt finns ännu :(");
            }
        }

        static void SökKontakt(List<Contact> nyKontakt)
        {
            Console.WriteLine("\nSök efter Namn eller Nummer: ");
            string sökOrd = Console.ReadLine();

            bool Found = false;
            for (int i = 0; i < nyKontakt.Count; i++)
            {
                if (nyKontakt[i].FirstName == sökOrd || nyKontakt[i].LastName == sökOrd)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Kontakten finns med namnet: ");
                    Console.Write($"\n{i + 1}. {nyKontakt[i].FullName}");
                    Found = true;
                }
                else if (nyKontakt[i].Nummer == sökOrd)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Kontakten finns med nummret: ");
                    Console.WriteLine($"\n {i + 1}. {nyKontakt[i].Nummer}");
                    Found = true;
                }
            }
            if (!Found)
            {
                Console.WriteLine("\nKontakten finns inte");
            }
        }

        static void TaBortKontakt(List<Contact> kontakter, List<string> raderadeKontakter)
        {
            Console.WriteLine("\nSkriv in hela namnet på kontakten som ska tas bort: \n");
            string raderaNamn = Console.ReadLine();

            for (int i = 0; i < kontakter.Count; i++)
            {
                if (kontakter[i].FullName == raderaNamn)
                {
                    kontakter.RemoveAt(i);

                    Console.WriteLine("Kontakten togs bort");
                }
                else
                {
                    Console.WriteLine("kontakten finns inte");
                }
            }
        }

        static void UppdateraNummer(List<Contact> nyKontakt)
        {
            Console.WriteLine("Vill du uppdatera ett telefonnummer? ja/nej");
            string uppdateraNummerSvar = Console.ReadLine();

            if (uppdateraNummerSvar == "ja")
            {
                Console.WriteLine("Skriv indexet som hör till nummret: ");
                var uppdateraNummerIndex = Console.ReadLine();

                Console.WriteLine("Skriv det nya nummret: ");
                string nyttNummer = Console.ReadLine();

                if (int.TryParse(uppdateraNummerIndex, out int index) && index > 0 && index <= nyKontakt.Count)
                {
                    nyKontakt[index - 1].Nummer = nyttNummer;
                    Console.WriteLine("Telefonnumret har uppdaterats");
                }
                else
                {
                    Console.WriteLine("Ogiltigt index");
                }


            }
            else if (uppdateraNummerSvar == "nej")
            {
                Console.WriteLine("Okej :)");
            }

            else
            {
                Console.WriteLine("Är det så svårt att svara ja eller nej?");
            }
        }

        static void UppdateraNamn(List<Contact> nyKontakt)
        {
            Console.WriteLine("Vill du uppdatera ett namn? ja/nej");
            string uppdateraNamnSvar = Console.ReadLine();

            if (uppdateraNamnSvar == "ja")
            {
                Console.WriteLine("(F)örnamn eller (E)fternamn?");
                string FirstOrLastName = Console.ReadLine();

                if (FirstOrLastName == "f")
                {
                    Console.WriteLine("Skriv indexet som hör till namnet");
                    var uppdateraNamnIndex = Console.ReadLine();

                    Console.WriteLine("Skriv det nya Förnamnet");
                    string nyttFörNamn = Console.ReadLine();

                    if (int.TryParse(uppdateraNamnIndex, out int index) && index > 0 && index <= nyKontakt.Count)
                    {
                        nyKontakt[index - 1].FirstName = nyttFörNamn;
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
                        nyKontakt[index - 1].LastName = nyttEfterNamn;
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

        static void Utskrift(List<Contact> nyKontakt)
        {
            Console.WriteLine("\nKontakter: ");
            Console.WriteLine("-----------------------------------");

            for (int i = 0; i < nyKontakt.Count; i++)
            {
                Console.WriteLine($"({i + 1}) ID: {nyKontakt[i].Id} \n    {nyKontakt[i].FullName} - {nyKontakt[i].Nummer} \n    Favorit - {nyKontakt[i].isFavorite} \n    Skapad - {nyKontakt[i].CreatedAt} \n    Uppdaterad - {nyKontakt[i].UpdateAt}");
                Console.WriteLine("-----------------------------------");
            }
        }

        static void TaBortFavorit(List<Contact> nyKontakt)
        {
            Console.WriteLine("Vill du ta bort en favorit? ja/nej");
            string taBortFavo = Console.ReadLine();

            if (taBortFavo == "ja")
            {
                Console.WriteLine("Ange index till kontakten");
                var taBortFavoIndex = Console.ReadLine();

                if (int.TryParse(taBortFavoIndex, out int index) && index > 0 && index <= nyKontakt.Count)
                {
                    nyKontakt[index - 1].isFavorite = false;
                    Console.WriteLine("Favoriten togs bort");
                }
            }
            else if (taBortFavo == "nej")
            {
                Console.WriteLine("Okej :)");
            }
            else
            {
                Console.WriteLine("Är det så svårt att svara ja eller nej?");
            }
        }
    }
}