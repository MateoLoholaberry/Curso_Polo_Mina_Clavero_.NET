namespace Ejercicio_clase_14.Modelos
{
    public class Baraja
    {
        public List<Carta> Cartas;
        public List<Carta> CartasFuera;


        public Baraja()
        {
            Cartas = new List<Carta>();
            CartasFuera = new List<Carta>();
            string[] Palos = {"Basto", "Espada", "Copa", "Oro"};

            foreach (var p in Palos)
            {
                Carta cartaNueva;
                for (int i = 1; i < 11; i++)
                {
                    if (i > 7)
                    {
                        cartaNueva = new Carta
                        {
                            Numero = i+2,
                            Palo = p
                        };

                        Cartas.Add(cartaNueva);
                        continue;
                    }

                    cartaNueva = new Carta
                    {
                        Numero = i,
                        Palo = p
                    };

                    Cartas.Add(cartaNueva);
                }
            }
        }


        public void Barajar()
        {

        }


        public void siguienteCarta()
        {
            Console.WriteLine($"{Cartas[0].Numero} de {Cartas[0].Palo}");
            CartasFuera.Add(Cartas[0]);
            Cartas.RemoveAt(0);
        }


        public void CartasDisponibles()
        {
            Console.WriteLine($"Quedan: {Cartas.Count}");
        }

        public void DarCartas(int cantidad)
        {
            if (Cartas.Count < cantidad)
            {
                Console.WriteLine("No hay cartas suficientes");
            }
            else
            {
                for (var i = 0; i < cantidad; i++)
                {
                    siguienteCarta();
                }
            }
        }


        public void CartasMonton()
        {
            if (CartasFuera.Count == 0)
            {
                Console.WriteLine("No se han sacado cartas de la baraja todavía.");
            }
            else
            {
                foreach (var carta in CartasFuera)
                {
                    Console.WriteLine($"{carta.Numero} de {carta.Palo}");
                }
            }
        }

        public void MostrarBaraja()
        {
            foreach (var carta in Cartas)
            {
                Console.WriteLine($"{carta.Numero} de {carta.Palo}");
            }
        }
    }
}