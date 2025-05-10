namespace Biblioteca;
using System.Globalization;
public static class Validaciones
{
    public static bool EsPositivo(int valor)
    {
        return valor >= 0;
    }

    public static bool EsFechaValida(string fechaTexto, out DateTime fecha)
    {
        return DateTime.TryParseExact(
            fechaTexto,
            "yyyy-MM-dd",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out fecha
        );
    }
}