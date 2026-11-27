# REGLAS DE REDISEÑO VISUAL (WINDOWS FORMS CLÁSICO - SGICE)

## 1. Objetivo y Restricciones Técnicas
- Refactorizar exclusivamente la interfaz gráfica de `SGICE.Presentacion` (archivos `.Designer.cs` y `.cs`) para replicar el estilo clásico de Windows Forms de escritorio (azul acero institucional `#8EB1D1`, fondo gris `SystemColors.Control` / `#EFEFEF` y controles estándar con borde).
- **PROHIBIDO** modificar la lógica de negocio, llamadas a servicios (`SGICE.Negocio`), entidades, validaciones o eventos existentes.
- **ELIMINACIÓN DE UIHelper**:
  1. Eliminar todas las llamadas a `UIHelper.Estilar...` en todos los constructores de los formularios.
  2. Si algún formulario usa `UIHelper.ExportarDataGridViewACsv` o `ExportarDataTableACsv`, mover esa lógica de exportación CSV a una clase normal (ej. `Utilidades\ExportadorCsv.cs`) y **eliminar por completo el archivo `UIHelper.cs`**.
- **COMPATIBILIDAD CON VISUAL STUDIO DESIGNER**: Mantener intacta la estructura `public partial class` y `InitializeComponent()`. No usar `System.Drawing.Drawing2D` ni dibujos personalizados en eventos `Paint`.

## 2. Paleta de Colores y Tipografía (Estilo Referencia)
- **Fondo general de formularios y paneles**: `SystemColors.Control` (`#F0F0F0`).
- **Encabezado superior de cada formulario hijo**: `Panel` (`Dock = Top`, `Height = 32`), `BackColor = Color.FromArgb(142, 177, 209)` (azul acero claro), con un `Label` centrado en mayúsculas (`REGISTRO DE CATEGORÍAS`, `REGISTRO DE SUB-CATEGORÍAS`, `ENTRADA DE ACTIVOS A INVENTARIO`, etc.), fuente `Georgia` o `Segoe UI`, `11pt`, `Bold`, color `Color.Black`. Eliminar banners morados/magenta e iconos grandes decorativos.
- **Tipografía general**:
  - Etiquetas (`Label`) y encabezados de `GroupBox` y `DataGridView`: `Segoe UI`, `9pt`, `Bold`, color `Color.Black`.
  - Cajas de texto (`TextBox`), `ComboBox`, `DateTimePicker` y celdas de tablas: `Segoe UI`, `9pt`, `Regular`.
- **Controles de entrada (`TextBox`, `ComboBox`, `DateTimePicker`)**: Fondo blanco (`SystemColors.Window`), `BorderStyle = BorderStyle.FixedSingle` (o `Fixed3D`), altura estándar (`23px`).

## 3. Estructura de Formularios de Catálogo / Mantenimiento (Distribución Vertical)
Organizar todos los formularios de mantenimiento de arriba hacia abajo (NO en dos columnas izquierda/derecha):
1. **Barra superior de título**: `Panel` azul acero (`#8EB1D1`, `Height = 32`) con título centrado en mayúsculas.
2. **Barra de búsqueda rápida**: `Panel` superior (`Height = 36`) con un `TextBox` ancho a la izquierda (`PlaceholderText = "Buscar..."`) y un `Button` cuadrado pequeño a la derecha para buscar/filtrar.
3. **Sección de captura de datos (`GroupBox`)**:
   - Usar un `GroupBox` con borde visible y título en negrita (ej. `Datos de la Categoría`, `Datos del Activo o Mobiliario`, `Datos del Edificio`).
   - Distribuir los campos (`Label` a la izquierda + `TextBox`/`ComboBox` a la derecha) en 1 o 2 filas horizontales limpias, y si hay `Descripción` u `Observación`, colocarla debajo ocupando todo el ancho del `GroupBox` (`Multiline = true`, `Height = 45`).
4. **Barra de botones de acción (alineados a la derecha)**:
   - Botones estándar (`FlatStyle = FlatStyle.Standard`, `Height = 28`, `Width = 105`, fuente `9pt Bold`) con fondos pastel suaves y borde visible:
     - **Nuevo**: `Color.FromArgb(224, 247, 250)` (celeste muy suave)
     - **Guardar / Actualizar**: `Color.FromArgb(232, 245, 233)` (verde menta muy suave)
     - **Eliminar / Cancelar**: `Color.FromArgb(255, 235, 238)` (rosado/rojo muy suave)
5. **Sección de listado (`GroupBox` + `DataGridView`)**:
   - Encerrar la tabla dentro de un `GroupBox` inferior (`Dock = Fill`) con título en negrita (ej. `Lista de Categorías`, `Lista de Sub-Categorías`).
   - Configurar `DataGridView`:
     - `BackgroundColor = Color.White`, `BorderStyle = BorderStyle.FixedSingle`, `RowHeadersVisible = true`, `RowHeadersWidth = 25`, `RowTemplate.Height = 24`.
     - Encabezados claros (`BackColor = SystemColors.Control`, `ForeColor = Color.Black`, `Font = 9pt Bold`, `EnableHeadersVisualStyles = true`).
     - `AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill` y **ocultar (`Visible = false`)** las columnas de auditoría (`FechaCreacion`, `FechaActualizacion`, `UsuarioRegistroId`, `UsuarioRegistro`, `UsuarioActualizacionId`, `UsuarioActualizacion`, `EstadoId`) para que las columnas principales nunca salgan cortadas.

## 4. Formularios de Movimientos (Entradas, Salidas, Traslados, Préstamos, Mantenimientos)
- Seguir exactamente la misma distribución vertical por bloques con `GroupBox`:
  1. `GroupBox` superior: Datos generales del movimiento (Número, Fecha, Referencia, Observación).
  2. `GroupBox` intermedio: Selección de activo + cantidad + botón `Agregar` (`#E8F5E9`).
  3. `GroupBox` de detalle: `DataGridView` con el detalle de ítems agregados y botones `Eliminar Fila` (`#FFEBEE`) y `Editar Físicos` (`#E8F5E9`) abajo a la derecha.
  4. `GroupBox` inferior (si aplica activos físicos): Tabla de activos físicos (`Nombre`, `Etiqueta`, `No. Serie`, `Ubicación`, `Estado`) y botones finales `Limpiar Campos` (`#E0F7FA`) y `Guardar ...` (`#E8F5E9`) abajo a la derecha.

## 5. Formulario Principal (`FrmPrincipal`) y `FrmLogin`
- **`FrmLogin`**: Dividir en 2 columnas (`50% / 50%`): izquierda fondo blanco con el logo institucional y el texto `SISTEMA DE GESTION DE INMOBILIARIOS PARA CENTROS EDUCATIVOS`; derecha panel azul acero (`#8EB1D1`) con icono de usuario arriba, campos `Usuario` y `Contraseña`, y botones `Iniciar` (`#E8F5E9`) y `Salir` (`#FFEBEE`).
- **`FrmPrincipal`**:
  - Barra superior (`Height = 28`, fondo `#EFEFEF`) con botón hamburguesa (`≡`) y título `SISTEMA DE GESTION DE INMOBILIARIOS PARA CENTROS EDUCATIVOS`.
  - Panel lateral izquierdo (`Width = 175`, fondo `#8EB1D1`) con el logo arriba y botones de menú desplegable estilo acordeón (`Inicio`, `Inventario`, `Movimientos`, `Préstamos`, `Mantenimiento`, `Admin.`, `Reportes`, `Acerca de`).
  - Panel contenedor central donde se incrustan los formularios hijos (`TopLevel = false`, `FormBorderStyle = FormBorderStyle.None`, `Dock = Fill`) o pantalla `Inicio` con tarjetas de resumen (`Activos Totales`, `Disponibles`, `Dañados`, `Perdidos`, `Préstamos Pendientes`, etc.).
