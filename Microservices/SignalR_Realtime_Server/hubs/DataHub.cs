using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.SignalR;

namespace SignalR_Realtime_Server
{
    public class DataHub : Hub
    {
        private readonly IHubContext<DataHub> _hubContext;
        public static List<Connected_User> oList_Connected_User = new List<Connected_User>();

        public DataHub(IHubContext<DataHub> hubContext)
        {
            _hubContext = hubContext;
        }
        public void Connect_User(string User_Identifier)
        {
            if (oList_Connected_User.Select(connected_User => connected_User.USER_IDENTIFIER).Contains(User_Identifier))
            {
                oList_Connected_User[oList_Connected_User.FindIndex(connected_User => connected_User.USER_IDENTIFIER == User_Identifier)].CONNECTION_ID = Context.ConnectionId;
            }
            else
            {
                oList_Connected_User.Add(new Connected_User()
                {
                    USER_IDENTIFIER = User_Identifier,
                    CONNECTION_ID = Context.ConnectionId
                });
            }
        }
        public void Disconnect_User(string User_Identifier)
        {
            oList_Connected_User.RemoveAll(connected_User => connected_User.USER_IDENTIFIER == User_Identifier);
        }
        public void Send_Data(Params_Send_Data i_Params_Send_Data)
        {
            try
            {
                var connection_ids = oList_Connected_User.GroupBy(x => x.CONNECTION_ID).Select(x => x.Key).ToList();
                _hubContext.Clients.Clients(connection_ids).SendAsync(i_Params_Send_Data.Event_Name, i_Params_Send_Data.Message);
            }
            catch { }
        }
    }
    public class Connected_User
    {
        public string CONNECTION_ID { get; set; }
        public string USER_IDENTIFIER { get; set; }
    }
}