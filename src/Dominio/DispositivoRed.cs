public class DispositivoRed
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public string DireccionIP { get; private set; }
    public string DireccionMAC { get; private set; }
    public bool Activo { get; private set; }

    public DispositivoRed(
        int id,
        string nombre,
        string direccionIP,
        string direccionMAC)
    {
        if (id <= 0)
            throw new ArgumentException("El ID debe ser mayor a 0.");

        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre es obligatorio.");

        if (string.IsNullOrWhiteSpace(direccionIP))
            throw new ArgumentException("La dirección IP es obligatoria.");

        if (string.IsNullOrWhiteSpace(direccionMAC))
            throw new ArgumentException("La dirección MAC es obligatoria.");

        Id = id;
        Nombre = nombre;
        DireccionIP = direccionIP;
        DireccionMAC = direccionMAC;
        Activo = true;
    }
}