internal class Program
{
    private static void Main(string[] args)
    {
        Jugador jugador1 = new Jugador("Juan", 20, 5, 10);
        Zombie zombiebasico = new Zombie("No Muerto", 10, 3, "Espada de madera");
        Aldeano aldeano1 = new Aldeano("Roberto", 15, 4, ["Pico", "Hacha", "Diamante"]);

        jugador1.colocarbloque();
        jugador1.Getbloques();
        jugador1.GetVida();
        
        zombiebasico.GetArma();
        zombiebasico.GetVel();
        
        aldeano1.quitarobjeto(2);
        aldeano1.agregarobjeto("Hierro");
        aldeano1.GetNombre();
    }
}