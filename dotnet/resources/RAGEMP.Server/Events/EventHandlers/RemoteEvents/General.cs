using GTANetworkAPI;

namespace RAGEMP.Server.Events.EventHandlers.RemoteEvents
{
    public class General : Script
    {
        [RemoteEvent(EventName.FromClientToServer.RegistrationRequest)]
        public async void RegistrationRequest(Player player, string login, string email, string password)
        {

        }
    }
}
