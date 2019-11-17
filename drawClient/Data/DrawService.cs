using System;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using gRPCClient;
using System.Drawing;

namespace drawClient.Data
{
    public delegate void ReceivedPointDelegate(int x, int y, string colorHex);
    public class DrawService : IDrawService, IDisposable
    {
        private readonly Draw.DrawClient _client;
        private readonly GrpcChannel _channel;
        private long id;
        public ReceivedPointDelegate pointDelegate { get; set; }
        private readonly IClientStreamWriter<DrawPointRequest> _requestStream;
        private readonly IAsyncStreamReader<DrawPoint> _responseStream;
        private readonly AsyncDuplexStreamingCall<DrawPointRequest, DrawPoint> _stream;
        public DrawService(GrpcChannel channel)
        {
            _channel = channel;
            _client = new Draw.DrawClient(channel);
            id = _client.ReceiveId(new IdRequest()).Id;
            _stream = _client.DrawPoints();
            _requestStream = _stream.RequestStream;
            _responseStream = _stream.ResponseStream;
        }

        public Task SendPoint(int x, int y, string colorHex)
        {
            System.Drawing.Color col = ColorTranslator.FromHtml(colorHex);
            var drawReq = new DrawPointRequest()
            {
                Id = id,
                DrawPoint = new DrawPoint()
                {
                    Color = new gRPCClient.Color()
                    {
                        R = (int)col.R,
                        B = (int)col.B,
                        G = (int)col.G
                    },
                    Point = new gRPCClient.Point()
                    {
                        X = x,
                        Y = y
                    }
                } 
            };
            _requestStream.WriteAsync(drawReq);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _stream.Dispose();
        }
    }
}
