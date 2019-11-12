using System;
using System.Collections.Generic;
using Grpc.Core;

namespace gRPCServer.Services
{
    public interface IBroadcastService
    {
        bool AddReceiver(IServerStreamWriter<DrawPoint> receiver, long id);

        IEnumerable<long> GetReceivers();
        void AddPoint(DrawPoint drawPoint, long sender);

        void RemoveReceiver(long id);
    }
}
