namespace RAGEMP.Server.Events
{
    public static class EventName
    {
        public class FromClientToServer
        {
            public const string RegistrationRequest = "FromClientToServer:RegistrationRequest";
            public const string AuthorizationRequest = "FromClientToServer:AuthorizationRequest";
        }

        public class FromServerToClient
        {
            public const string RegistrationResponse = "FromServerToClient:RegistrationResponse";
            public const string AuthorizationResponse = "FromServerToClient:AuthorizationResponse";
        }
    }
}
