using System.Net.WebSockets;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace ��������֤.A47_SinglRʾ��.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    [Controller]
    public class SocketController : ControllerBase
    {
        private readonly ILogger _logger;

        public SocketController(ILogger<SocketController> logger)
        {
            this._logger = logger;
        }

        //[Route("test")]
        [HttpGet("test")]
        public async Task Get()
        {
            if(this.HttpContext.WebSockets.IsWebSocketRequest)
            {
                using WebSocket websockt = await this.HttpContext.WebSockets.AcceptWebSocketAsync();
                await this.Handle(websockt);
            }
            else
            {
                this.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        private async Task Handle(WebSocket webSocket)
        {
            byte[] buffer = new byte[1024 * 4]; // 4KB buffer size for receiving data.

            //����һ�η���
            WebSocketReceiveResult receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

            while(!receiveResult.CloseStatus.HasValue)
            {
                string resultStr = Encoding.UTF8.GetString(buffer, 0, receiveResult.Count);
                await Console.Out.WriteLineAsync($"���յ���:{resultStr}");

                //׼��Ҫ���͵���Ϣ
                string message = $"��ã����յ���{resultStr}";

                //��message�����д��buffer�У�׼������
                byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
                messageBuffer.CopyTo(buffer, 0);

                //����
                await webSocket.SendAsync(
                    new ArraySegment<byte>(buffer, 0, messageBuffer.Length),
                    receiveResult.MessageType,
                    receiveResult.EndOfMessage, //��һ�η��͵���Ϣ�а�������һ������Ϣ����δ����
                    CancellationToken.None
                    );

                //������һ��
                receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            }

            await webSocket.CloseAsync(
                receiveResult.CloseStatus.Value,
                receiveResult.CloseStatusDescription,
                CancellationToken.None); //�ر�����
        }
    }
}