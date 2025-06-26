# PracticaEventos
Sistema de Gestión de Eventos

Imagina que estás desarrollando un sistema para organizar y gestionar diferentes tipos de eventos, como conferencias y talleres, y a los participantes que asisten a ellos.
Requisitos:

   Clase Base Evento:
        Debe tener atributos para el nombre (string), la fecha (string, formato "DD-MM-AAAA") y el ubicacion (string).
        Debe tener un método obtener_descripcion() que devuelva una cadena de texto con la información básica del evento.
        Debe tener una colección (por ejemplo, una lista) para almacenar participantes inscritos.
        Debe tener un método inscribir_participante(participante) que agregue un objeto Participante a la lista de participantes del evento.

   Clase Derivada Conferencia:
        Hereda de Evento.
        Debe tener un atributo adicional para el tema principal (string).
        Sobreescribe el método obtener_descripcion() para incluir también el tema principal.

   Clase Derivada Taller:
        Hereda de Evento.
        Debe tener un atributo adicional para el capacidad maxima (entero).
        Sobreescribe el método obtener_descripcion() para incluir también la capacidad máxima.
        El método inscribir_participante() debe verificar si la capacidad máxima ha sido alcanzada antes de inscribir a un participante. Si se excede, debe imprimir un mensaje indicando que el taller está lleno.

   Clase Participante:
        Debe tener atributos para el nombre (string) y el apellido (string).
        Debe tener un método obtener_nombre_completo() que devuelva el nombre y apellido concatenados.

Program:
Debe tener una coleccion de eventos.
El usuario debe poder:
   Crear Evento
   Listar Eventos
   Buscar Evento (y ver los participantes)
   Inscribir participantes.
   Extra Ver los eventos de hoy