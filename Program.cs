// See https://aka.ms/new-console-template for more information


List<Evento> eventos = new();

void CrearEvento()
{
    Evento evento = null;
    Console.WriteLine(@"Seleccione el tipo:
1. Evento
2. Conferencia
3. Taller");
    int tipo = int.Parse(Console.ReadLine());
    switch (tipo)
    {
        case 1:
            evento = new Evento();
            break;
        case 2:
            evento = new Conferencia();
            break;
        case 3:
            evento = new Taller();
            break;
    }
    Console.WriteLine("Ingrese el nombre:");
    evento.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la fecha: DD/MM/YYYY");
    evento.Fecha = Console.ReadLine();
    Console.WriteLine("Ingrese la ubicacion:");
    evento.Ubicacion = Console.ReadLine();

    // if (tipo == 2)
    if (evento is Conferencia)
    {
        Console.WriteLine("Ingrese el tema principal:");
        (evento as Conferencia).TemaPrincipal = Console.ReadLine();
    }
    // if (tipo == 3)
    if (evento is Taller taller)
    {
        Console.WriteLine("Ingrese la capacidad maxima:");
        taller.Capacidad = int.Parse(Console.ReadLine());
    }
    eventos.Add(evento);
}
void ListarEventos()
{
    int i = 1;
    foreach (Evento evento in eventos)
    {
        Console.WriteLine($"{i++}. {evento.ObtenerDescripcion()}");
    }
}
void BuscarEvento()
{
    Console.WriteLine("Ingrese el nombre del evento a buscar");
    string nombre = Console.ReadLine();
    // // Solucion 1
    // foreach (Evento evento in eventos)
    // {
    //     if (evento.Nombre.Contains(nombre))
    //     {
    //         MostrarEvento(evento);
    //     }
    // }

    // Solucion 2
    foreach (Evento evento in eventos.OrderBy(x=> x.Fecha).Where(e => e.Nombre.Contains(nombre)))
    {
        MostrarEvento(evento);
    }


}

void MostrarEvento(Evento evento)
{
    Console.WriteLine(evento.ObtenerDescripcion());
    foreach (var p in evento.Participantes)
        Console.WriteLine(p.ObtenerNombreCompleto2());
}

void InscribirParticipantes()
{
    Console.WriteLine("Ingrese algun dato del evento al que va a asistir: ");
    string dato = Console.ReadLine();
    //Solucion 1
    List<Evento> eventosFiltrados1 = new List<Evento>();
    foreach (Evento e in eventos)
    {
        if (e.ObtenerDescripcion().Contains(dato))
        {
            eventosFiltrados1.Add(e);
        }
    }

    //Solucion 2
    var eventosFiltrados2 = eventos.Where(e => e.ObtenerDescripcion().Contains(dato)).ToArray();

    int i = 1;
    foreach (Evento e in eventosFiltrados1)
    {
        Console.WriteLine($"{i++}. {e.ObtenerDescripcion()}");
    }
    if (eventosFiltrados1.Any())
    {
        Console.WriteLine("Seleccione el evento:");
        int idEvento = int.Parse(Console.ReadLine());
        if (idEvento <= eventosFiltrados1.Count)
        {
            var evento = eventosFiltrados1[idEvento - 1];

            Participante p = new Participante();
            Console.WriteLine("Ingrese el Nombre:");
            p.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido:");
            p.Apellido = Console.ReadLine();
            if (!evento.InscribirParticipante(p))
            {
                Console.WriteLine("Evento lleno");
            }
        }
    }
}

void EventosDeHoy()
{
    string fecha = DateTime.Now.ToString("dd/MM/yyyy");
    foreach (Evento evento in eventos.Where(e => e.Fecha == fecha))
    {
        MostrarEvento(evento);
    }
}

void EventosLlenos()
{
    foreach (Evento evento in eventos.OfType<Taller>().Where(x=> x.Participantes.Count == x.Capacidad))
    {
        MostrarEvento(evento);
    }
}

void MostrarMenu()
{
    Console.WriteLine("1. CrearEvento");
    Console.WriteLine("2. ListarEventos");
    Console.WriteLine("3. BuscarEvento");
    Console.WriteLine("4. InscribirParticipantes");
    Console.WriteLine("5. EventosDeHoy");
    Console.WriteLine("6. EventosLlenos");
    Console.WriteLine("7. Salir");
    Console.WriteLine();
}

MostrarMenu();
Console.WriteLine("Seleccione una opcion: ");
int opcion = int.Parse(Console.ReadLine());
while (opcion != 7)
{
    switch (opcion)
    {
        case 1:
            CrearEvento();
            break;
        case 2:
            ListarEventos();
            break;
        case 3:
            BuscarEvento();
            break;
        case 4:
            InscribirParticipantes();
            break;
        case 5:
            EventosDeHoy();
            break;
    }
    MostrarMenu();
    Console.WriteLine("Seleccione una opcion: ");
    opcion = int.Parse(Console.ReadLine());
}