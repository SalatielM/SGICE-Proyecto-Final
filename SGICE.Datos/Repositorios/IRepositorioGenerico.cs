using System.Linq.Expressions;
using SGICE.Entidades;

namespace SGICE.Datos.Repositorios;

/// <summary>
/// Interfaz para el repositorio genérico con operaciones CRUD y consultas parametrizadas.
/// </summary>
/// <typeparam name="T">Entidad del dominio derivada de EntidadBase</typeparam>
public interface IRepositorioGenerico<T> where T : EntidadBase
{
    IEnumerable<T> ObtenerTodos();
    Task<IEnumerable<T>> ObtenerTodosAsync();

    T? ObtenerPorId(int id);
    Task<T?> ObtenerPorIdAsync(int id);

    IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado);
    Task<IEnumerable<T>> BuscarAsync(Expression<Func<T, bool>> predicado);

    void Agregar(T entidad);
    Task AgregarAsync(T entidad);

    void Actualizar(T entidad);
    Task ActualizarAsync(T entidad);

    void Eliminar(T entidad);
    Task EliminarAsync(T entidad);

    void EliminarPorId(int id);
    Task EliminarPorIdAsync(int id);

    IQueryable<T> Consultar();
    int GuardarCambios();
    Task<int> GuardarCambiosAsync();
}
