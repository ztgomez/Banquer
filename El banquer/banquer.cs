using System;
using System.Collections.Generic;

namespace BanquerAnalogic
{
    public class Banc
    {
        private List<Client> clients;

        public Banc()
        {
            clients = new List<Client>();
        }

        public void AfegirClient(string nom, decimal saldoInicial)
        {
            clients.Add(new Client(nom, saldoInicial));
            Console.WriteLine($"Nou client afegit: {nom} amb saldo inicial de {saldoInicial:C}");
        }

        public Client CercarClient(string nom)
        {
            return clients.Find(client => client.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase));
        }

        public void MostrarClients()
        {
            Console.WriteLine("Llista de clients:");
            foreach (var client in clients)
            {
                Console.WriteLine($"- {client.Nom}: {client.Saldo:C}");
            }
        }
    }
}