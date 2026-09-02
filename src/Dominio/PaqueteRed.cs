public class PaqueteRed
{
    public int Id { get; private set; }
    public string IPOrigen { get; private set; }
    public string IPDestino { get; private set; }
    public string Datos { get; private set; }
    public int Tamano { get; private set; }

    public PaqueteRed(
        int id,
        string ipOrigen,
        string ipDestino,
        string datos,
        int tamano)
    {
        if (id <= 0)
            throw new ArgumentException("El ID debe ser mayor a 0.");

        if (string.IsNullOrWhiteSpace(ipOrigen))
            throw new ArgumentException("La IP de origen es obligatoria.");

        if (string.IsNullOrWhiteSpace(ipDestino))
            throw new ArgumentException("La IP de destino es obligatoria.");

        if (string.IsNullOrWhiteSpace(datos))
            throw new ArgumentException("Los datos son obligatorios.");

        if (tamano <= 0)
            throw new ArgumentException("El tamaño debe ser mayor a 0.");

        Id = id;
        IPOrigen = ipOrigen;
        IPDestino = ipDestino;
        Datos = datos;
        Tamano = tamano;
    }
}