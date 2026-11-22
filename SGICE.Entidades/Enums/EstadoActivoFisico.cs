namespace SGICE.Entidades.Enums;

/// <summary>
/// Estados posibles para un activo físico en el inventario.
/// </summary>
public enum EstadoActivoFisico
{
    Disponible = 3,
    Prestado = 4,
    PendienteDeMantenimiento = 5,
    Dañado = 6,
    Extraviado = 7,
    DadoDeBaja = 8,
    NoDisponible = 9
}
