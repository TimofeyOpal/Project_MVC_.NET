using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Project_2.Controllers
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", Context.User.Identity.Name, message);
        }
    }
}
