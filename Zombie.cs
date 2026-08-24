public class Zombie : Mob
    {
        private string arma;
        public Zombie(string nombre, float vida, int vel, string arma) : base(nombre, vida, vel, true)
        {
            this.arma = arma;
        }

        public override void HacerSonido()
        {
            Console.WriteLine($"{GetNombre()} gruñe.");
        }

        public string GetArma()
        {
            Console.WriteLine($"Zombie {GetNombre()} usa {arma}");
            return arma;
        }
    }
