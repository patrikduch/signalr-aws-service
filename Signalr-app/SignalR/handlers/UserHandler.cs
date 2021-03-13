using System.Collections.Generic;

namespace NetCore_Dockerization.SignalR.handlers
{
    public static class UserHandler
    {
        public static HashSet<string> ConnectedIds = new HashSet<string>();

    }
}
