public class Conferencia : Evento
{
    public string TemaPrincipal { get; set; }

    public override string ObtenerDescripcion()
    {
        //     var anterior = base.ObtenerDescripcion();
        //     return anterior + " Tema: " + TemaPrincipal;
        return $"{base.ObtenerDescripcion()} Tema: {TemaPrincipal}";
        
        
        // return $"{Nombre} el dia {Fecha} en la sala {Ubicacion} Tema: {TemaPrincipal}";

    }
}