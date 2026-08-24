public class Jugador : LivingEntity
    {
        private int bloques;
        public Jugador(string nombre, float vida, int vel, int bloques) : base(nombre, vida, vel)
        {
            this.bloques = bloques;
        }

        public int colocarbloque()
        {   
            if (bloques <= 0)
            {
                Console.WriteLine("No hay bloques!");
                return -1;
            }
            bloques--;
            Console.WriteLine($"Bloque Colocado, quedan {bloques}.");
            return bloques;
        }
        public int Getbloques()
        {
            Console.WriteLine($"El jugador {GetNombre()} tiene {bloques} bloque/s");
            return bloques;
        }
    }