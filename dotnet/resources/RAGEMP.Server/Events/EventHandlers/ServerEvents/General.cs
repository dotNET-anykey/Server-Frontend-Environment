using GTANetworkAPI;

namespace RAGEMP.Server.Events.EventHandlers.ServerEvents
{
    public class General : Script
    {
        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnected(Player player)
        {
        }
    }
}
