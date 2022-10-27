using GTANetworkAPI;

namespace RAGEMP.Server
{
    public class Commands : Script
    {
        [Command("veh", GreedyArg = true)]
        public void CMD_CreateVehicle(Player player, string vehicleName)
        {
            var vehicleHashKey = NAPI.Util.GetHashKey(vehicleName);
            var test = NAPI.Util.VehicleNameToModel(vehicleName);

            player.SendChatMessage(vehicleHashKey.ToString());
            player.SendChatMessage(test.ToString());

            if (vehicleHashKey < 1)
            {
                player.SendChatMessage("Error: Invalid vehicle name.");
            }
            var vehicle = NAPI.Vehicle.CreateVehicle(vehicleHashKey, player.Position,player.Rotation.Z, 111, 111, engine: false);

            player.SetIntoVehicle(vehicle, 0);
        }
    }
}
