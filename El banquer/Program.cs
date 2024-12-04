using System;

namespace BanquerAnalogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Banc banc = new Banc();
            banc.AfegirClient("Joan", 100);
            banc.AfegirClient("Maria", 200);

            bool sortir = false;

            while (!sortir)
            {
                Console.WriteLine("\nBenvingut al Banc Analògic! Selecciona una opció:");
                Console.WriteLine("1. Mostrar clients");
                Console.WriteLine("2. Ingressar diners");
                Console.WriteLine("3. Retirar diners");
                Console.WriteLine("4. Afegir un nou client");
                Console.WriteLine("5. Sortir");
                Console.Write("Opció: ");
                string opcio = Console.ReadLine();

                switch (opcio)
                {
                    case "1":
                        banc.MostrarClients();
                        break;
                    case "2":
                        Console.Write("Introdueix el nom del client: ");
                        string nomIngressar = Console.ReadLine();
                        Client clientIngressar = banc.CercarClient(nomIngressar);
                        if (clientIngressar != null)
                        {
                            Console.Write("Introdueix la quantitat a ingressar: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal quantitatIngressar))
                            {
                                clientIngressar.IngressarDiners(quantitatIngressar);
                            }
                            else
                            {
                                Console.WriteLine("Quantitat invàlida.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Client no trobat.");
                        }
                        break;
                    case "3":
                        Console.Write("Introdueix el nom del client: ");
                        string nomRetirar = Console.ReadLine();
                        Client clientRetirar = banc.CercarClient(nomRetirar);
                        if (clientRetirar != null)
                        {
                            Console.Write("Introdueix la quantitat a retirar: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal quantitatRetirar))
                            {
                                clientRetirar.RetirarDiners(quantitatRetirar);
                            }
                            else
                            {
                                Console.WriteLine("Quantitat invàlida.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Client no trobat.");
                        }
                        break;
                    case "4":
                        Console.Write("Introdueix el nom del nou client: ");
                        string nouNom = Console.ReadLine();
                        Console.Write("Introdueix el saldo inicial: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal saldoInicial))
                        {
                            banc.AfegirClient(nouNom, saldoInicial);
                        }
                        else
                        {
                            Console.WriteLine("Saldo inicial invàlid.");
                        }
                        break;
                    case "5":
                        sortir = true;
                        Console.WriteLine("Gràcies per utilitzar el Banc Analògic. Fins aviat!");
                        break;
                    default:
                        Console.WriteLine("Opció no vàlida.");
                        break;
                }
            }
        }
    }
}
