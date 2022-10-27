using GTANetworkAPI;

namespace RAGEMP.Server
{
    public class Startup : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            NAPI.World.SetTime(20,30,00);
            NAPI.Util.ConsoleOutput("Gamemode has been started!");
        }
    }
}
