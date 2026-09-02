public class Router : DispositivoRed
{
    public int CantidadPuertos { get; private set; }

    public Router(
        int id,
        string nombre,
        string direccionIP,
        string direccionMAC,
        int cantidadPuertos)
        : base(id, nombre, direccionIP, direccionMAC)
    {
        if (cantidadPuertos <= 0)
            throw new ArgumentException("Debe tener al menos un puerto.");

        CantidadPuertos = cantidadPuertos;
    }
}