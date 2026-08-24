public class LivingEntity : Entity
    {
        private int vel;

        public LivingEntity(string nombre, float vida, int vel) : base(nombre, vida)
        {
            this.vel = vel;
        }

        public virtual void HacerSonido()
        {
            Console.WriteLine($"{GetNombre()} hace un sonido.");
        }

        public int GetVel()
        {
            Console.WriteLine($"La entidad tiene {vel} de velocidad");
            return vel;
        }
    }