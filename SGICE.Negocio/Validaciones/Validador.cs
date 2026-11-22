using System.Net.Mail;
using System.Text.RegularExpressions;
using SGICE.Negocio.Excepciones;

namespace SGICE.Negocio.Validaciones;

/// <summary>
/// Provee métodos estáticos de validación estricta para reglas de negocio comunes:
/// campos obligatorios, rangos numéricos positivos, formato de correo y validación de cédula dominicana (módulo 10).
/// </summary>
public static class Validador
{
    /// <summary>
    /// Valida que una cadena de texto no sea nula, vacía ni contenga solo espacios en blanco.
    /// </summary>
    /// <param name="valor">Texto a validar</param>
    /// <param name="nombreCampo">Nombre descriptivo del campo para el mensaje de error</param>
    /// <exception cref="ValidacionNegocioExcepcion">Se lanza si el campo está vacío</exception>
    public static void ValidarRequerido(string? valor, string nombreCampo)
    {
        if (string.IsNullOrWhiteSpace(valor))
        {
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El campo '{nombreCampo}' es obligatorio.");
        }
    }

    /// <summary>
    /// Valida que la longitud de un texto esté dentro del rango permitido.
    /// </summary>
    public static void ValidarLongitud(string? valor, int min, int max, string nombreCampo)
    {
        if (string.IsNullOrWhiteSpace(valor)) return;

        string limpio = valor.Trim();
        if (limpio.Length < min || limpio.Length > max)
        {
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El campo '{nombreCampo}' debe tener entre {min} y {max} caracteres.");
        }
    }

    /// <summary>
    /// Valida que la longitud de un texto no exceda un límite máximo.
    /// </summary>
    public static void ValidarLongitudMaxima(string? valor, int max, string nombreCampo)
    {
        if (string.IsNullOrWhiteSpace(valor)) return;

        string limpio = valor.Trim();
        if (limpio.Length > max)
        {
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El campo '{nombreCampo}' no puede tener más de {max} caracteres.");
        }
    }

    /// <summary>
    /// Valida que un identificador numérico sea estrictamente positivo (mayor que cero).
    /// </summary>
    public static void ValidarIdPositivo(int id, string nombreCampo)
    {
        if (id <= 0)
        {
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El identificador '{nombreCampo}' debe ser un entero positivo mayor que cero. Valor recibido: {id}.");
        }
    }

    /// <summary>
    /// Valida que un identificador numérico nullable contenga un valor estrictamente positivo.
    /// </summary>
    public static void ValidarIdPositivo(int? id, string nombreCampo)
    {
        if (!id.HasValue || id.Value <= 0)
        {
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El identificador '{nombreCampo}' debe contener un entero positivo mayor que cero.");
        }
    }

    /// <summary>
    /// Valida que un valor entero se encuentre dentro del rango inclusivo [min, max].
    /// </summary>
    public static void ValidarRangoPositivo(int valor, int min, int max, string nombreCampo)
    {
        if (valor < min || valor > max)
        {
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El campo '{nombreCampo}' debe estar comprendido entre {min} y {max}. Valor actual: {valor}.");
        }
    }

    /// <summary>
    /// Valida que un número entero se encuentre en un rango estrictamente positivo.
    /// </summary>
    /// <param name="valor">Valor a evaluar</param>
    /// <param name="nombreCampo">Nombre descriptivo del campo</param>
    /// <param name="permitirCero">Indica si el valor cero es admisible</param>
    public static void ValidarRangoPositivo(int valor, string nombreCampo, bool permitirCero = false)
    {
        if (permitirCero ? valor < 0 : valor <= 0)
        {
            string condicion = permitirCero ? "mayor o igual a cero" : "estrictamente mayor a cero (positivo)";
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El campo '{nombreCampo}' debe tener un valor {condicion}. Valor actual: {valor}.");
        }
    }

    /// <summary>
    /// Valida que un número decimal se encuentre en un rango positivo.
    /// </summary>
    public static void ValidarRangoPositivo(decimal valor, string nombreCampo, bool permitirCero = false)
    {
        if (permitirCero ? valor < 0m : valor <= 0m)
        {
            string condicion = permitirCero ? "mayor o igual a cero" : "estrictamente mayor a cero (positivo)";
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El campo '{nombreCampo}' debe tener un valor {condicion}. Valor actual: {valor}.");
        }
    }

    /// <summary>
    /// Valida que un número de punto flotante se encuentre en un rango positivo.
    /// </summary>
    public static void ValidarRangoPositivo(double valor, string nombreCampo, bool permitirCero = false)
    {
        if (permitirCero ? valor < 0.0 : valor <= 0.0)
        {
            string condicion = permitirCero ? "mayor o igual a cero" : "estrictamente mayor a cero (positivo)";
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El campo '{nombreCampo}' debe tener un valor {condicion}. Valor actual: {valor}.");
        }
    }

    /// <summary>
    /// Valida estrictamente el formato de una dirección de correo electrónico según los estándares de internet.
    /// </summary>
    /// <param name="correo">Correo electrónico a validar</param>
    /// <param name="obligatorio">Indica si el campo es obligatorio o puede ser omitido si es nulo</param>
    /// <returns>True si es válido</returns>
    public static bool EsCorreoValido(string? correo, bool obligatorio = true)
    {
        if (string.IsNullOrWhiteSpace(correo))
        {
            return !obligatorio;
        }

        string limpio = correo.Trim();
        try
        {
            var direccion = new MailAddress(limpio);
            if (direccion.Address != limpio) return false;

            string[] partes = limpio.Split('@');
            if (partes.Length != 2) return false;

            string dominio = partes[1];
            if (!dominio.Contains('.')) return false;

            return Regex.IsMatch(limpio, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// Valida el formato de correo electrónico y lanza una excepción de negocio si no es válido.
    /// </summary>
    public static void ValidarCorreo(string? correo, string nombreCampo = "Correo Electrónico", bool obligatorio = true)
    {
        if (string.IsNullOrWhiteSpace(correo) && !obligatorio) return;

        if (!EsCorreoValido(correo, obligatorio))
        {
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El formato del campo '{nombreCampo}' no es un correo electrónico válido (ejemplo: usuario@dominio.com).");
        }
    }

    /// <summary>
    /// Valida una Cédula de Identidad y Electoral Dominicana mediante el algoritmo del Módulo 10 (Luhn).
    /// </summary>
    /// <param name="cedula">Número de cédula con o sin guiones</param>
    /// <returns>True si la cédula es matemáticamente válida; False en caso contrario.</returns>
    public static bool EsCedulaDominicanaValida(string? cedula)
    {
        if (string.IsNullOrWhiteSpace(cedula)) return false;

        string limpia = cedula.Replace("-", "").Replace(" ", "").Trim();

        // Debe constar exactamente de 11 dígitos numéricos
        if (!Regex.IsMatch(limpia, @"^\d{11}$")) return false;

        // Se descartan secuencias de prueba o nulas como 00000000000
        if (limpia == "00000000000") return false;

        int suma = 0;
        int[] multiplicadores = { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };

        for (int i = 0; i < 10; i++)
        {
            int resultado = (limpia[i] - '0') * multiplicadores[i];
            if (resultado >= 10)
            {
                resultado = (resultado / 10) + (resultado % 10);
            }
            suma += resultado;
        }

        int digitoCalculado = (10 - (suma % 10)) % 10;
        int digitoReal = limpia[10] - '0';

        return digitoCalculado == digitoReal;
    }

    /// <summary>
    /// Valida la cédula dominicana y lanza una excepción descriptiva si es inválida.
    /// </summary>
    public static void ValidarCedula(string? cedula, string nombreCampo = "Cédula")
    {
        ValidarRequerido(cedula, nombreCampo);

        if (!EsCedulaDominicanaValida(cedula))
        {
            throw new ValidacionNegocioExcepcion(nombreCampo, $"La '{nombreCampo}' ingresada ('{cedula}') no es una cédula dominicana válida.");
        }
    }

    /// <summary>
    /// Valida un número telefónico de República Dominicana (códigos de área 809, 829, 849 seguidos de 7 dígitos).
    /// </summary>
    public static bool EsTelefonoDominicanoValido(string? telefono)
    {
        if (string.IsNullOrWhiteSpace(telefono)) return false;

        string limpio = telefono.Replace("-", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace(" ", "")
                                .Trim();

        return Regex.IsMatch(limpio, @"^(809|829|849)\d{7}$");
    }

    /// <summary>
    /// Valida el teléfono dominicano y lanza una excepción de negocio si no coincide.
    /// </summary>
    public static void ValidarTelefono(string? telefono, string nombreCampo = "Teléfono")
    {
        ValidarRequerido(telefono, nombreCampo);

        if (!EsTelefonoDominicanoValido(telefono))
        {
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El campo '{nombreCampo}' debe ser un teléfono dominicano válido con código de área 809, 829 u 849 (ejemplo: 809-555-1234).");
        }
    }

    /// <summary>
    /// Valida un RNC (Registro Nacional del Contribuyente) de República Dominicana (9 u 11 dígitos).
    /// </summary>
    public static bool EsRncValido(string? rnc)
    {
        if (string.IsNullOrWhiteSpace(rnc)) return false;

        string limpio = rnc.Replace("-", "").Replace(" ", "").Trim();

        if (limpio.Length == 11)
        {
            return EsCedulaDominicanaValida(limpio);
        }

        if (limpio.Length != 9 || !Regex.IsMatch(limpio, @"^\d{9}$"))
        {
            return false;
        }

        int[] pesos = { 7, 9, 8, 6, 5, 4, 3, 2 };
        int suma = 0;

        for (int i = 0; i < 8; i++)
        {
            suma += (limpio[i] - '0') * pesos[i];
        }

        int residuo = suma % 11;
        int digitoCalculado = residuo switch
        {
            0 => 2,
            1 => 1,
            _ => 11 - residuo
        };

        return digitoCalculado == (limpio[8] - '0');
    }

    /// <summary>
    /// Valida el RNC y lanza una excepción si no cumple con la regla matemática.
    /// </summary>
    public static void ValidarRnc(string? rnc, string nombreCampo = "RNC")
    {
        if (string.IsNullOrWhiteSpace(rnc)) return;

        if (!EsRncValido(rnc))
        {
            throw new ValidacionNegocioExcepcion(nombreCampo, $"El '{nombreCampo}' ingresado no es válido.");
        }
    }
}
