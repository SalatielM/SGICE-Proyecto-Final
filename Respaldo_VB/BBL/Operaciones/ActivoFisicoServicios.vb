Imports DAO
Imports MODELOS
Imports Microsoft.EntityFrameworkCore

Public Class ActivoFisicoServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodo() As List(Of ActivoFisico)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of ActivoFisico)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(id As Integer) As ActivoFisico
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of ActivoFisico)(ctx)
            Dim activo = repo.ObtenerPorId(id)
            If activo Is Nothing Then
                Throw New ExcepcionesdeNegocio("El activo físico no existe.")
            End If
            Return activo
        End Using
    End Function

    Public Function ObtenerDtoPorEtiqueta(activoFisico As String) As ActivoFisicoDTO
        If String.IsNullOrWhiteSpace(activoFisico) Then
            Throw New ExcepcionesdeNegocio("Debe escribir una etiqueta para buscar")
        End If

        activoFisico = activoFisico.Trim()

        Using ctx As New AppDbContext()
            Dim activo = ctx.ActivoFisico.
                Include(Function(a) a.Activo).
                ThenInclude(Function(a) a.Marca).
                Include(Function(a) a.Activo).
                ThenInclude(Function(a) a.SubCategoria).
                Include(Function(a) a.Ubicacion).
                Include(Function(a) a.Estado).
                FirstOrDefault(Function(a) a.CodEtiquetaQR = activoFisico OrElse a.NumSerie = activoFisico)

            If activo Is Nothing Then
                Throw New ExcepcionesdeNegocio("El activo no existe o el código es incorrecto")
            End If

            Return New ActivoFisicoDTO With {
                .IdActivoFisico = activo.IdActivoFisico,
                .ActivoId = activo.ActivoId,
                .Activo = activo.Activo.Nombre,
                .CodEtiquetaQR = activo.CodEtiquetaQR,
                .NumSerie = activo.NumSerie,
                .MarcaId = activo.Activo.MarcaId,
                .Marca = activo.Activo.Marca.Nombre,
                .SubCategoriaId = activo.Activo.SubCategoriaId,
                .SubCategoria = activo.Activo.SubCategoria.Nombre,
                .UbicacionId = activo.UbicacionId,
                .Ubicacion = activo.Ubicacion.Nombre,
                .EstadoId = activo.EstadoId,
                .Estado = activo.Estado.Nombre
            }
        End Using
    End Function

    Public Sub ValidarEstadoActivoFisico(id As Integer)
        Dim activo = ObtenerPorId(id)
        Dim estadoServicios As New EstadoServicios()
        estadoServicios.ValidarEstado(activo.EstadoId, TipoEstadoEnum.ActivoFisico)

        If activo.EstadoId <> CInt(EstadoActivoFisico.Disponible) Then
            Throw New ExcepcionesdeNegocio("El activo no se encuentra disponible para ser trasladado.")
        End If
    End Sub

    Public Function Contar() As Integer
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of ActivoFisico)(ctx)
            Return repo.Consultar().Count()
        End Using
    End Function

    Public Function ContarPorEstado(idEstado As Integer) As Integer
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of ActivoFisico)(ctx)
            Return repo.Consultar().Count(Function(x) x.EstadoId = idEstado)
        End Using
    End Function

    Public Function Listar() As List(Of ActivoFisicoDTO)
        Using ctx As New AppDbContext()
            Return ctx.ActivoFisico.
                Include(Function(af) af.Activo).
                    ThenInclude(Function(a) a.SubCategoria).
                        ThenInclude(Function(a) a.Categoria).
            Include(Function(af) af.Activo).
                    ThenInclude(Function(a) a.Marca).
                Include(Function(af) af.Estado).
                Include(Function(af) af.Ubicacion).
                Where(Function(af) af.EstadoId <> CInt(EstadoActivoFisico.DadoDeBaja)).
                Select(Function(af) New ActivoFisicoDTO With {
                    .IdActivoFisico = af.IdActivoFisico,
                    .ActivoId = af.ActivoId,
                    .Activo = af.Activo.Nombre,
                    .CodEtiquetaQR = af.CodEtiquetaQR,
                    .NumSerie = af.NumSerie,
                    .CategoriaId = af.Activo.SubCategoria.CategoriaId,
                    .Categoria = af.Activo.SubCategoria.Categoria.Nombre,
                    .SubCategoriaId = af.Activo.SubCategoriaId,
                    .SubCategoria = af.Activo.SubCategoria.Nombre,
                    .MarcaId = af.Activo.MarcaId,
                    .Marca = af.Activo.Marca.Nombre,
                    .EstadoId = af.EstadoId,
                    .Estado = af.Estado.Nombre,
                    .UbicacionId = af.UbicacionId,
                    .Ubicacion = If(af.Ubicacion IsNot Nothing, af.Ubicacion.Nombre, "Sin Ubicación"),
                    .FechaRegistro = af.FechaRegistro
                }).ToList()
        End Using
    End Function

    Public Function ListarDisponiblesPorSubCategoria(idSubCategoria As Integer) As List(Of ActivoFisicoDTO)
        Using ctx As New AppDbContext()
            Return ctx.ActivoFisico.
                Include(Function(a) a.Activo).
                    ThenInclude(Function(a) a.SubCategoria).
                Include(Function(a) a.Activo).
                    ThenInclude(Function(a) a.Marca).
                Include(Function(a) a.Estado).
                Where(Function(a) a.Activo.SubCategoriaId = idSubCategoria AndAlso a.EstadoId = CInt(EstadoActivoFisico.Disponible)).
                Select(Function(a) New ActivoFisicoDTO With {
                    .IdActivoFisico = a.IdActivoFisico,
                    .ActivoId = a.ActivoId,
                    .Activo = a.Activo.Nombre,
                    .CodEtiquetaQR = a.CodEtiquetaQR,
                    .NumSerie = a.NumSerie,
                    .SubCategoriaId = a.Activo.SubCategoriaId,
                    .SubCategoria = a.Activo.SubCategoria.Nombre,
                    .MarcaId = a.Activo.MarcaId,
                    .Marca = a.Activo.Marca.Nombre,
                    .EstadoId = a.EstadoId,
                    .Estado = a.Estado.Nombre
                }).
                OrderBy(Function(a) a.Activo).
                ToList()
        End Using
    End Function

    Public Function FiltrarActivosFisicos(Optional activoId As Integer? = Nothing, Optional marcaId As Integer? = Nothing, Optional fechaRegistro As DateTime? = Nothing, Optional subCategoriaId As Integer? = Nothing, Optional estadoId As Integer? = Nothing, Optional ubicacionId As Integer? = Nothing, Optional etiquetaBusqueda As String = "") As List(Of ActivoFisicoDTO)
        Using ctx As New AppDbContext()
            Dim query = ctx.ActivoFisico.
                Include(Function(af) af.Activo).
                    ThenInclude(Function(a) a.SubCategoria).
                Include(Function(af) af.Activo).
                    ThenInclude(Function(a) a.Marca).
                Include(Function(af) af.Estado).
                Include(Function(af) af.Ubicacion).AsQueryable()

            If Not String.IsNullOrWhiteSpace(etiquetaBusqueda) Then
                etiquetaBusqueda = etiquetaBusqueda.Trim().ToLower()
                query = query.Where(Function(af) af.CodEtiquetaQR.ToLower().Contains(etiquetaBusqueda))
            End If

            If activoId.HasValue AndAlso activoId.Value > 0 Then
                query = query.Where(Function(a) a.ActivoId = activoId.Value)
            End If

            If marcaId.HasValue AndAlso marcaId.Value > 0 Then
                query = query.Where(Function(a) a.Activo.MarcaId = marcaId.Value)
            End If

            If fechaRegistro.HasValue Then
                query = query.Where(Function(af) af.FechaRegistro.Date = fechaRegistro.Value.Date)
            End If

            If subCategoriaId.HasValue AndAlso subCategoriaId.Value > 0 Then
                query = query.Where(Function(af) af.Activo.SubCategoriaId = subCategoriaId.Value)
            End If

            If estadoId.HasValue AndAlso estadoId.Value > 0 Then
                query = query.Where(Function(af) af.EstadoId = estadoId.Value)
            End If

            If ubicacionId.HasValue AndAlso ubicacionId.Value > 0 Then
                query = query.Where(Function(af) af.UbicacionId = ubicacionId.Value)
            End If

            Return query.Select(Function(af) New ActivoFisicoDTO With {
                .IdActivoFisico = af.IdActivoFisico,
                .ActivoId = af.ActivoId,
                .Activo = af.Activo.Nombre,
                .CodEtiquetaQR = af.CodEtiquetaQR,
                .NumSerie = af.NumSerie,
                .SubCategoriaId = af.Activo.SubCategoriaId,
                .SubCategoria = af.Activo.SubCategoria.Nombre,
                .MarcaId = af.Activo.MarcaId,
                .Marca = af.Activo.Marca.Nombre,
                .EstadoId = af.EstadoId,
                .Estado = af.Estado.Nombre,
                .UbicacionId = af.UbicacionId,
                .Ubicacion = If(af.Ubicacion IsNot Nothing, af.Ubicacion.Nombre, "Sin Ubicación"),
                .FechaRegistro = af.FechaRegistro
            }).ToList()
        End Using
    End Function

    Public Sub Actualizar(activo As ActivoFisico)
        If activo Is Nothing Then
            Throw New ArgumentNullException(NameOf(activo))
        End If

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of ActivoFisico)(ctx)
            repo.Actualizar(activo)
            ctx.SaveChanges()
        End Using
    End Sub

End Class
