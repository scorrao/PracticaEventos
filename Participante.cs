public class Participante
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public string ObtenerNombreCompleto()
    {
        return $"{Nombre} {Apellido}";
    }
    public string ObtenerNombreCompleto2()
    {
        return $"{Apellido}, {Nombre}";
    }
}