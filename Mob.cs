public class Mob : LivingEntity
    {
        private bool hostil;

        public Mob(string nombre, float vida, int vel, bool hostil) : base(nombre, vida, vel)
        {
            this.hostil = hostil;
        }
    }