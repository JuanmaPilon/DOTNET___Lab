using Microsoft.AspNetCore.SignalR;

namespace Lab.Components.Hubs
{
    public class TramiteHub : Hub
    {
        // Método para notificar a todos los clientes sobre actualizaciones
        public async Task NotifyTramiteUpdate()
        {
            await Clients.All.SendAsync("ReceiveTramiteUpdate");
        }
    }
}