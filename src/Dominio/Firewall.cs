public class Firewall : DispositivoRed
{
    public bool BloqueaTrafico { get; private set; }

    public Firewall(
        int id,
        string nombre,
        string direccionIP,
        string direccionMAC,
        bool bloqueaTrafico)
        : base(id, nombre, direccionIP, direccionMAC)
    {
        BloqueaTrafico = bloqueaTrafico;
    }
}