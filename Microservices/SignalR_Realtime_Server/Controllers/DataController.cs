using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace SignalR_Realtime_Server
{
    [Route("api/data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IHubContext<DataHub> _hubContext;

        public DataController(IHubContext<DataHub> hubContext)
        {
            _hubContext = hubContext;
        }
        [HttpPost]
        [Route("send")]
        public IActionResult Send_Data(Params_Send_Data i_Params_Send_Data)
        {
            using (DataHub oDataHub = new DataHub(_hubContext))
            {
                oDataHub.Send_Data(i_Params_Send_Data);
            }
            return Ok();
        }
    }
    public class Params_Send_Data
    {
        public string Message { get; set; }
        public string Event_Name { get; set; }
        public string USER_IDENTIFIER { get; set; }
    }
}
