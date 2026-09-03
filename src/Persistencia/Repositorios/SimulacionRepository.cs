using Aplicacion.Dominio;
using Aplicacion.Interfaces;
using Dapper;

namespace Persistencia.Repositorios;

public class SimulacionRepository : ISimulacionRepository
{
    private readonly IDbConnectionFactory _factory;

    public SimulacionRepository(IDbConnectionFactory factory)
    {
        _factory = factory;
    }

    public void Registrar(Simulacion simulacion)
    {
        using var connection = _factory.CrearConexionDesarrollo();

        connection.Execute(
            "sp_registrar_simulacion",
            new
            {
                IpOrigen = simulacion.Paquete.IpOrigen,
                IpDestino = simulacion.Paquete.IpDestino,
                TamanoBytes = simulacion.Paquete.TamanoBytes,
                TtlInicial = simulacion.Paquete.Ttl,
                LatenciaTotal = simulacion.LatenciaTotal,
                Entregado = simulacion.Paquete.Entregado,
                Descartado = simulacion.Paquete.Descartado
            },
            commandType: System.Data.CommandType.StoredProcedure);
    }

    public Simulacion? ObtenerPorId(int id)
    {
        using var connection = _factory.CrearConexionDesarrollo();

        var data = connection.QueryFirstOrDefault<dynamic>(
            "SELECT * FROM simulaciones WHERE id=@id",
            new { id });

        return data == null ? null : null;
    }

    public IEnumerable<Simulacion> ObtenerTodas()
    {
        using var connection = _factory.CrearConexionDesarrollo();

        connection.Query(
            "SELECT * FROM simulaciones");

        return Enumerable.Empty<Simulacion>();
    }
}
