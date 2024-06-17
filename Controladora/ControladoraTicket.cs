using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System.Collections.ObjectModel;

namespace Controladora
{
    public class ControladoraTicket
    {
        Context context;

        private ControladoraTicket()
        {
            context = new Context();
        }

        private static ControladoraTicket instancia;

        public static ControladoraTicket Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new ControladoraTicket();
                return instancia;
            }
        }

        public ReadOnlyCollection<Ticket> RecuperarTicket()
        {
            try
            {
                Context.Instancia.Tickets.ToList().AsReadOnly();
                return Context.Instancia.Tickets.ToList().AsReadOnly();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string AgregarTicket(Ticket ticket)
        {
            try
            {
                var listaTickets = Context.Instancia.Tickets.ToList().AsReadOnly();
                var ticketEncontrado = listaTickets.FirstOrDefault(t => t.Computadora.ComputadoraId == ticket.ComputadoraId); //busco el ticket a agregar por id en la lista de tickets para evitar que se repitan
                if (ticketEncontrado == null)
                {
                    Context.Instancia.Tickets.Add(ticket);
                   
                    int agregados = Context.Instancia.SaveChanges();
                    if (agregados > 0)
                    {
                        return $"El ticket se agregó correctamente";
                    }
                    else return $"El ticket no se ha podido agregar";
                }
                else
                {
                    return $"El ticket ya existe";
                }
            }
            catch (Exception ex)
            {
                return "Error desconocido" + ex;
            }
        }

        public string ModificarTicket(Ticket ticket)
        {
            try
            {
                var listaTickets = Context.Instancia.Tickets.ToList().AsReadOnly();
                var ticketEncontrado = listaTickets.FirstOrDefault(t => t.Computadora.ComputadoraId == ticket.ComputadoraId); //busco el ticket a modificar por id en la lista de tickets para evitar que se repitan los id de las computadoras s
                if (ticketEncontrado != null)
                {

                    Context.Instancia.Tickets.Update(ticket);
                    int insertados = context.SaveChanges();

                    if (insertados > 0)
                    {
                        return $"El ticket se modificó correctamente";
                    }
                    else return $"El ticket no se ha podido modificar";
                }
                else
                {
                    return $"El ticket no existe";
                }
            }
            catch (Exception ex)
            {
                return "Error desconocido" + ex ;
            }
        }

        public string EliminarTicket(Ticket ticket)
        {
            try
            {
                var listaComputadoras= Context.Instancia.Computadoras.ToList().AsReadOnly();
                var listaTickets = Context.Instancia.Tickets.ToList().AsReadOnly();
                var ticketEncontrado = listaComputadoras.FirstOrDefault(t => t.ComputadoraId == ticket.ComputadoraId); //busco el ticket a eliminar por id en la lista de tickets para evitar que se repitan
                if (ticketEncontrado != null)
                {
                    Context.Instancia.Tickets.Remove(ticket);
                    int eliminados = Context.Instancia.SaveChanges();
                    if (eliminados > 0)
                    {
                        return $"El ticket se eliminó correctamente";
                    }
                    else return $"El ticket no se ha podido eliminar";
                }
                else
                {
                    return $"El ticket no existe";
                }
            }
            catch (Exception ex)
            {
                return "Error desconocido" + ex;
            }
        }

    }
}
