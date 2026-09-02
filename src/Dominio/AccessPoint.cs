public class AccessPoint : DispositivoRed
{
    public string SSID { get; private set; }
    public string Canal { get; private set; }

    public AccessPoint(
        int id,
        string nombre,
        string direccionIP,
        string direccionMAC,
        string ssid,
        string canal)
        : base(id, nombre, direccionIP, direccionMAC)
    {
        if (string.IsNullOrWhiteSpace(ssid))
            throw new ArgumentException("El SSID es obligatorio.");

        if (string.IsNullOrWhiteSpace(canal))
            throw new ArgumentException("El canal es obligatorio.");

        SSID = ssid;
        Canal = canal;
    }
}