using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightGeneratorPegasus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrAirport = new string[] { "Abudhabi", "Adana", "Alanya-Gazipasa", "Almati", "Amman", "Amsterdam", "Ankara", "Antalya", "Atina", "Bagdat", "Bahreyn", "Baku", "Balikesir-Edremit", "Bari", "Barselona", "Basel-Mulhouse", "Basra", "Batman", "Batum", "Belgrad", "Berlin-Bradenburg", "Beyrut", "Billund", "Bingol", "Biskek", "Bologna", "Bremen", "Brüksel-Charleroi", "Budapeste", "Bukres-Otopeni", "Catania", "Cenevre", "Cidde", "Cimkent", "Dalaman", "Dammam", "Denizli", "Diyarbakir", "Doha-DIA", "Doha-DOH", "Dubai", "Dusseldorf", "Eindhoven", "Elazig", "Erbil", "Erivan", "Erzincan", "Erzurum", "Frankfurt-Main", "Gaziantep", "Gence", "Genoa", "Goteborg-Landvetter", "Hamburg", "Hannover", "Hatay", "Helsinki", "Hurgada", "Igdir", "Izmir", "Karachi", "Kars", "Kayseri", "Kazablanka", "Kishinev", "Konya", "Kopenhag", "Koln", "Kuveyt", "Lefkosa-Kuzey Kibris", "Leipzig", "Londra-Stansted", "Lyon-Saint Exupery", "Madrid-Bajaras", "Malatya", "Manchester", "Mardin", "Marsilya", "Maskat", "Medine", "Milan-Bergamo", "Moskova-Domodedovo", "Mugla-Milas Bodrum", "Mus", "Munih", "Nursultan", "Nurnberg", "Ordu-Giresun", "Oslo", "Os", "Paderborn/Lippstadt", "Paris-Charles de Gaulle", "Paris-Orly", "Prag", "Priştine", "Riyad", "Rize-Artvin", "Roma-Fiumicino", "Rotterdam", "Samsun", "Saraybosna", "Sivas", "Sofya", "St.Petersburg", "Stockholm-Arlanda", "Stuttgart", "Sanliurfa", "Sarjah", "Sarm El-Seyh", "Tabriz", "Tehran-IKA", "Tekirdag-Corlu", "Tel Aviv", "Ben Guiron", "Tilfis", "Tiran", "Trabzon", "Uskup", "Van", "Venedik", "Viyana", "Zurih" };
            string turnaround;
            string language;
            bool checkTurnaround = false;
            Random rnd = new Random();

            Console.Write("Which language you will use (Type Türkçe or English): ");
            language = Console.ReadLine();



            if (language == "English" || language == "english")
            {
                Console.Write("Are you gonna make the turnaround, type Yes No: ");
                turnaround = Console.ReadLine();

                if (turnaround == "Yes" || turnaround == "yes")
                {
                    checkTurnaround = true;
                }
                else if (turnaround == "No" || turnaround == "no")
                {
                    checkTurnaround = false;
                }
                else
                {
                    Console.WriteLine("Please write Yes or No");
                    Console.ReadLine();
                    Environment.Exit(0);
                }


                if (checkTurnaround)
                {
                    int index = rnd.Next(arrAirport.Length);
                    Console.WriteLine($"Departure airport is: Istanbul Sabiha Gökçen. Arrival airport is: {arrAirport[index]}");

                    int passanger = rnd.Next(100, 162);
                    Console.WriteLine("Your passanger number is: " + passanger);

                    int cargo = rnd.Next(2000, 4000);
                    Console.WriteLine("Your cargo is: " + cargo + " KG");

                    string[] aircraft = new string[] { "A320", "B738" };
                    index = rnd.Next(aircraft.Length);
                    Console.WriteLine($"Your aircraft is: {aircraft[index]}");
                    Console.WriteLine("For turnaround;");
                    passanger = rnd.Next(100, 162);
                    Console.WriteLine("Your passanger number is: " + passanger);

                    cargo = rnd.Next(2000, 4000);
                    Console.WriteLine("Your cargo is: " + cargo + " KG");

                }
                else
                {
                    int index = rnd.Next(arrAirport.Length);
                    Console.WriteLine($"Departure airport is: Istanbul Sabiha Gökçen. Arrival airport is: {arrAirport[index]}");

                    int passanger = rnd.Next(100, 162);
                    Console.WriteLine("Your passanger number is: " + passanger);

                    int cargo = rnd.Next(2000, 4000);
                    Console.WriteLine("Your cargo is: " + cargo + " KG");

                    string[] aircraft = new string[] { "A320", "B738" };
                    index = rnd.Next(aircraft.Length);
                    Console.WriteLine($"Your aircraft is: {aircraft[index]}");
                }
            }
            else if (language == "Türkçe" || language == "türkçe")
            {
                Console.Write("Dönüş uçuşunu yapacak mısınız?, Lütfen Evet veya Hayır yazın: ");
                turnaround = Console.ReadLine();

                if (turnaround == "Evet" || turnaround == "evet")
                {
                    checkTurnaround = true;
                }
                else if (turnaround == "Hayır" || turnaround == "hayır")
                {
                    checkTurnaround = false;
                }
                else
                {
                    Console.WriteLine("Lütfen Evet veya Hayır yazın");
                    Console.ReadLine();
                    Environment.Exit(0);
                }


                if (checkTurnaround)
                {
                    int index = rnd.Next(arrAirport.Length);
                    Console.WriteLine($"Başlangıç havalimanı: Istanbul Sabiha Gökçen. Varış havalimanı: {arrAirport[index]}");

                    int passanger = rnd.Next(100, 162);
                    Console.WriteLine("Yolcu sayınız: " + passanger);

                    int cargo = rnd.Next(2000, 4000);
                    Console.WriteLine("Kargo miktarınız: " + cargo + " KG");

                    string[] aircraft = new string[] { "A320", "B738" };
                    index = rnd.Next(aircraft.Length);
                    Console.WriteLine($"Uçağınız: {aircraft[index]}");
                    Console.WriteLine("Geri dönüş için;");
                    passanger = rnd.Next(100, 162);
                    Console.WriteLine("Yolcu sayınız: " + passanger);

                    cargo = rnd.Next(2000, 4000);
                    Console.WriteLine("Kargo sayınız: " + cargo + " KG");

                }
                else
                {
                    int index = rnd.Next(arrAirport.Length);
                    Console.WriteLine($"Başlangıç havalimanı: Istanbul Sabiha Gökçen. Varış havalimanı: {arrAirport[index]}");

                    int passanger = rnd.Next(100, 162);
                    Console.WriteLine("Yolcu sayınız: " + passanger);

                    int cargo = rnd.Next(2000, 4000);
                    Console.WriteLine("Kargo miktarınız: " + cargo + " KG");

                    string[] aircraft = new string[] { "A320", "B738" };
                    index = rnd.Next(aircraft.Length);
                    Console.WriteLine($"Uçağınız: {aircraft[index]}");
                }
            }
            else
            {
                Console.WriteLine("Please write Türkçe or English");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.ReadLine();
        }

        

    }
}
