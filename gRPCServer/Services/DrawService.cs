using System;
using System.Threading.Tasks;
using Grpc.Core;

namespace gRPCServer.Services
{
    public class DrawService : Draw.DrawBase
    {
        private readonly IBroadcastService _broadcastService;
        private readonly IIdentityService _idService;
        public DrawService(IBroadcastService broadcastService, IIdentityService idService)
        {
            _broadcastService = broadcastService;
            _idService = idService;
        }
        public async override Task DrawPoints(IAsyncStreamReader<DrawPointRequest> requestStream, IServerStreamWriter<DrawPoint> responseStream, ServerCallContext context)
        {
            _broadcastService.AddReceiver(responseStream, requestStream.Current.Id);
            while(await requestStream.MoveNext())
            {
                _broadcastService.AddPoint(requestStream.Current.DrawPoint, requestStream.Current.Id);
            }
            _broadcastService.RemoveReceiver(requestStream.Current.Id);
        }

        public override Task<IdResponse> ReceiveId(IdRequest request, ServerCallContext context)
        {
            return Task.FromResult(new IdResponse {
                Id = _idService.GetNextId()
            });
        }

    }
}