namespace RAGEMP.Client
{
    public static class EventName
    {
        public class FromClientToCef
        {

        }

        public class FromCefToClient
        {
            public const string RegisterAccount = "FromCefToClient:RegisterAccount";
            public const string AuthorizeAccount = "FromCefToClient:AuthorizeAccount";
        }

        //Copy to server from here

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
