namespace BanquerAnalogic
{
    public class Client
    {
        public string Nom { get; private set; }
        public decimal Saldo { get; private set; }

        public Client(string nom, decimal saldoInicial)
        {
            Nom = nom;
            Saldo = saldoInicial >= 0 ? saldoInicial : 0;
        }

        public void IngressarDiners(decimal quantitat)
        {
            if (quantitat > 0)
            {
                Saldo += quantitat;
                Console.WriteLine($"S'han ingressat {quantitat:C} al compte de {Nom}. Saldo actual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("La quantitat per ingressar ha de ser positiva.");
            }
        }

        public void RetirarDiners(decimal quantitat)
        {
            if (quantitat > 0)
            {
                decimal comissio = quantitat * 0.01m;
                decimal totalARestar = quantitat + comissio;

                if (Saldo >= totalARestar)
                {
                    Saldo -= totalARestar;
                    Console.WriteLine($"S'han retirat {quantitat:C} del compte de {Nom}. Comissió aplicada: {comissio:C}. Saldo actual: {Saldo:C}");
                }
                else
                {
                    Console.WriteLine($"Operació denegada: El saldo de {Nom} és insuficient.");
                }
            }
            else
            {
                Console.WriteLine("La quantitat per retirar ha de ser positiva.");
            }
        }
    }
}