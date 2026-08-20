public class Zombie : Mob
    {
        public Zombie(string nombre, float vida, int vel) : base(nombre, vida, vel, true)
        {
        
        }

        public override void HacerSonido()
        {
            Console.WriteLine($"{this.GetNombre} gruñe.");
        }
    }

public class Jugador : LivingEntity
    {
        public Jugador(string nombre, float vida, int vel) : base(nombre, vida, vel)
        {
        
        }
    }