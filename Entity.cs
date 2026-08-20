public class Entity
    {
        private string nombre;
        private float vida;
        public Entity(string nombre, float vida)
        {
            this.nombre = nombre;
            this.vida = vida;
        }
        public float GetVida()
        {
            Console.WriteLine($"Vida de la entidad {this.vida}");
            return this.vida;
        }
        public string GetNombre()
        {
            Console.WriteLine($"Nombre de la entidad {this.nombre}");
            return this.nombre;
        }
    }