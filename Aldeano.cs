public class Aldeano : Mob
{
    private List<string> objetos;
    public Aldeano(string nombre, int vida, int vel, List<string> objetos) : base(nombre, vida, vel, false)
    {
        this.objetos = objetos;
    }
    public string quitarobjeto(int i)
    {
        if (objetos.Count == 0)
        {
            Console.WriteLine("El aldeano no tiene objetos!");
            return "Sin objetos.";

        }

        if (i < objetos.Count && i >= 0)
        {
            string objeto = objetos[i];
            objetos.RemoveAt(i);
            return objeto;
        }
        else
        {
            Console.WriteLine("Objeto no existe!");
            return "indice fuera de rango";
        }
    }
    public List<string> agregarobjeto(string objetonew)
    {
        objetos.Add(objetonew);
        Console.WriteLine($"Se añadio el objeto {objetonew}");
        return objetos;
    }
}