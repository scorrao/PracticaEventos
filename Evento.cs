public class Evento
{
    public string Nombre { get; set; }
    public string Fecha { get; set; }
    public string Ubicacion { get; set; }
    public List<Participante> Participantes { get; set; } = new();

    // public abstract string ObtenerDescripcion();
    public virtual string ObtenerDescripcion()
    {
        return $"{Nombre} el dia {Fecha} en la sala {Ubicacion}";
    }
    public virtual bool InscribirParticipante(Participante p)
    {
        Participantes.Add(p);
        return true;
    }
}