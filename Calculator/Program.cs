using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pierwszaLiczba = ""; //deklaruję zmienną typu string o nazwie pierwszaLiczba i przypisuję do niej pusty string
            string drugaLiczba = ""; //deklaruję zmienną typu string o nazwie drugaLiczba i przypisuję do niej pusty string
            string wybraneDzialanie = ""; //deklaruję zmienną typu string o nazwie wybraneDziałanie i przypisuje do niej pusty string

            int liczba1 = 0; //deklaruję zmienną typu int i przypisuję do niej wartość 0
            int liczba2 = 0; //deklaruję zmienną typu int i przypisuję do niej wartość 0
            int wykonaDzialanie = 0; //deklaruję zmienną typu int i przypisuję do niej wartość 0
            int wynik = 0; //deklaruję zmienną typu int i przypisuję do niej wartość 0
            bool czyString1ToLiczba = false; //deklaruję zmienną typu bool i przypisuje do niej wartość false
            bool czyString2ToLiczba = false; //deklaruję zmienną typu bool i przypisuje do niej wartość false
            bool czyString3ToLiczba = false; //deklaruję zmienną typu bool i przypisuje do niej wartość false

            Console.WriteLine("Wpisz pierszą cyfrę "); //drukuję w konsoli zdanie informacyjne
            pierwszaLiczba = Console.ReadLine(); //odczytuję z konsoli watość, którą przekazał użytkownik i przypisuje ją do zmiennej pierwszaLiczba
            Console.WriteLine("Wpisz drugą cyfrę "); //drukuję w konsoli zdanie informacyjne
            drugaLiczba = Console.ReadLine(); //odczytuję z konsoli wartość, którą przekazal użytkownik i przypisuje ją do zmiennej drugaLiczba
            Console.WriteLine("Jeśli chcesz dodać wpisz 1, jeśli odjąć to wpisz 2, jeśli chcesz pomnożyć wpisz 3, a jeśli podzielić to 4 "); //drukuję w konsoli zdanie informacyjne
            wybraneDzialanie = Console.ReadLine(); //odczytuję z konsoli wartość, którą przekazał użytkownik i przypisuje ją do zmiennej wybraneDzialanie

            czyString1ToLiczba = int.TryParse(pierwszaLiczba, out liczba1); //Za pomocą int.TryParse sprawdzam czy zmienna o nazwie pierwszaLiczba to int.
            //Po sprawdzeniu jeżeli zmienna pierwszaLiczba to liczba przypisuje do zmiennej czyStringToLiczba wartość true, jeżeli nie jest liczbą przypisuje wartość false
            //Jednocześnie jeśeli zmienna pierwszaLiczba to liczba przypisuje jej wartość do zmiennej liczba1
         
            czyString2ToLiczba = int.TryParse(drugaLiczba, out liczba2); //Za pomocą int.TryParse sprawdzam czy zmienna o nazwie drugaLiczba to int.
            //Po sprawdzeniu jeżeli zmienna drugaLiczba to liczba, przypisuje do zmiennej czystring2ToLiczba wartość true, jeżeli nie jest liczbą przypisuje wartośc false
            //Jednocześnie jeżeli zmienna drugaLiczba to liczba przypisuje jej wartość do zmiennej liczba2

            czyString3ToLiczba = int.TryParse(wybraneDzialanie, out wykonaDzialanie); //Za pomocą int.TryParse sprawdzam czy zmienna o nazwie wykonaDzialanie to int.
            //Po sprawdzeniu jeżeli zmienna wykonaDzialanie to liczba, przypisuje do zmiennej czystring3ToLiczba wartość true, jeżeli nie jest liczbą przypisuje wartośc false
            //Jednocześnie jeżeli zmienna wykonaDzialanie to liczba przypisuje jej wartość do zmiennej wykonaDzialanie

            if (czyString1ToLiczba && czyString2ToLiczba && czyString3ToLiczba) //Sprawdzam warunek jeżeli wszystkie z tych zmiennych to są liczby wykonuje to co jest w body
            {
                if (wykonaDzialanie == (int)Dzialanie.dodawanie) //Sprawdzam wrunek jesli zmienna wykonaDzialanie jest równa odpowiedniej wartości enuma Dzialanie(dodawanie) to wykonaj to co jest w body
                {
                    wynik = liczba1 + liczba2; //Dodaje liczbe1 do liczby2 i przypisuje wynik do zmiennej wynik
                    Console.WriteLine("Wynik dodawania: " + wynik); //Drukuje w konsoli zdanie informacyjne i zmienną wynik
                }
                else if (wykonaDzialanie == (int)Dzialanie.odejmowanie) //Sprawdzam warunek, jeśli zmienna wykonaDzialanie jest równa odpowiedniej wartości enuma Dzialanie(odejmowanie) to wykonaj to co jest w body
                {
                    wynik = liczba1 - liczba2; //Odejmuje liczbę1 od liczby2 i przypisuje wynik do zmiennej wynik
                    Console.WriteLine("Wynik odejmowania: " + wynik); //Drukuje w konsoli zdanie informacyjne i zmienną wynik
                }
                else if (wykonaDzialanie == (int)Dzialanie.mnozenie) //Sprawdzam warunek, jeśli zmienna wykonaDzialanie jest równa odpowiedniej wartości enuma Dzialanie(mnozenie) to wykonaj to co jest w body
                {
                    wynik = liczba1 * liczba2; //Mnoży liczba1 i liczba2 i przypisuje wynik do zmiennej wynik
                    Console.WriteLine("Wynik mnożenia: " + wynik); //Drukuje w konsoli zdanie informacyjne i zmienną wynik
                }
                else if (wykonaDzialanie == (int)Dzialanie.dzielenie) //Sprawdzam warunek, jeśli zmienna wykonaDzialanie jest równa odpowiedniej wartości enuma Dzialanie(dzielenie) to wykonaj to co jest w body
                {
                    wynik = liczba1 / liczba2; //Dzieki liczba1 przez liczba2 i przypisuje wynik do zmiennej wynik
                    Console.WriteLine("Wynik dzielenia: " + wynik); //Drukuje w konsoli zdanie informacyjne i zmienną wynik
                }
            }
            else //To wykonuję jeśli któraś z tych zmiennych (czyString1ToLiczba && czyString2ToLiczba && czyString3ToLiczba) ma wartość false to wykonuje to co jest poniżej
            {
                Console.WriteLine("To nie jest liczba"); //Drukuje w konsoli zdanie informacyjne 
            }
        }
    }
}
