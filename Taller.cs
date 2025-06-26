public class Taller : Evento
{
    public int Capacidad { get; set; }

    public override string ObtenerDescripcion()
    {
        return $"{base.ObtenerDescripcion()} Capacidad: {Capacidad}";
    }

    public override bool InscribirParticipante(Participante p)
    {
        if (Participantes.Count < Capacidad)
        {
            // Participantes.Add(p);
            // return true;
            return base.InscribirParticipante(p);
        }
        else
            return false;
    }
    
}