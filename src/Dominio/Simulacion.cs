public class Simulacion
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public List<DispositivoRed> Dispositivos { get; private set; }
    public List<PaqueteRed> Paquetes { get; private set; }

    public Simulacion(int id, string nombre)
    {
        if (id <= 0)
            throw new ArgumentException("El ID debe ser mayor a 0.");

        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre es obligatorio.");

        Id = id;
        Nombre = nombre;
        Dispositivos = new List<DispositivoRed>();
        Paquetes = new List<PaqueteRed>();
    }
}