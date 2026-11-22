# Especificaciones Técnicas - Proyecto Final ISC-340 (Lenguaje de Programación III)

## 1. Objetivo
Migrar y refactorizar el sistema **SGICE (Sistema de Gestión de Inmobiliarios para Centros Educativos)** a **100% C# (.NET 10 Windows Forms)** bajo una arquitectura estricta de 4 capas, conectado a **SQL Server Express (`PSGestionActivosDB`)** mediante Entity Framework Core.

## 2. Arquitectura Obligatoria (Solución Visual Studio)
La solución `SGICE.sln` debe contener 5 proyectos en C#:
1. `SGICE.Entidades`: Modelos de dominio. Aplicar POO (clase abstracta base `EntidadBase` con propiedades comunes como `Id`, `FechaRegistro`, `Estado` y herencia/polimorfismo donde aplique).
2. `SGICE.Datos`: Capa DAL con Entity Framework Core (reutilizando el DAO existente en C#). Debe incluir `try-catch-finally`, consultas parametrizadas/LINQ y soporte para **transacciones explícitas** (`IDbContextTransaction`) en operaciones críticas (asignación, traslado y descargo de activos).
3. `SGICE.Negocio`: Capa BLL con reglas de negocio, validaciones (cédula dominicana, correos, rangos numéricos, campos requeridos) y manejo jerárquico de excepciones. Cero referencias a `System.Windows.Forms`.
4. `SGICE.Presentacion`: Windows Forms en C#. PROHIBIDO poner código de acceso a datos en los eventos de formularios.
5. `SGICE.Tests`: Proyecto de pruebas unitarias (xUnit) probando al menos 8 métodos críticos de `SGICE.Negocio`.

## 3. Requisitos de Interfaz (UI/UX - Windows Forms)
- **Login (`FrmLogin`)**: Autenticación contra la base de datos.
- **Contenedor Principal (`FrmPrincipal`)**: Formulario **MDI Principal** con menú lateral o `MenuStrip` estructurado, barra de estado (`StatusStrip` mostrando usuario activo y fecha) y `ProgressBar` en cargas/reportes.
- **Mantenimientos (CRUD)**: Centros Educativos, Edificios, Ubicaciones/Aulas, Categorías, Activos Físicos y Usuarios.
- **Validación Visual**: Uso obligatorio del componente `ErrorProvider` en todos los formularios de registro/edición antes de invocar la capa de Negocio.
- **Procesos/Transacciones**: Pantalla de Asignación o Traslado de Activos entre ubicaciones usando transacción explícita.
- **Reportes/Consultas**: Pantalla de consulta con filtros dinámicos, estadísticas básicas (totales por estado/ubicación) y exportación a CSV.

## 4. Reglas de Calidad y Git
- Código limpio (Clean Code), nombres descriptivos en español, comentarios XML (`/// <summary>`) en clases y métodos públicos.
- No dejar ningún archivo `.vb` en la solución final.
