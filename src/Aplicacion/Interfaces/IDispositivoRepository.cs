using Aplicacion.Dominio;

namespace Aplicacion.Interfaces;

public interface IDispositivoRepository
{
    IEnumerable<DispositivoRed> ObtenerTodos();
    DispositivoRed? ObtenerPorId(int id);
    void Agregar(DispositivoRed dispositivo);
}
