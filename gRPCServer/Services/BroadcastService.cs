using System.Collections.Concurrent;
using System.Collections.Generic;
using System;
using Grpc.Core;

namespace gRPCServer.Services
{
    public class BroadcastService: IBroadcastService
    {
        public BroadcastService()
        {
            receivers = new ConcurrentDictionary<long, IServerStreamWriter<DrawPoint>>();
        }
        private ConcurrentDictionary<long, IServerStreamWriter<DrawPoint>> receivers;

        public void AddPoint(DrawPoint drawPoint, long sender)
        {
            foreach(KeyValuePair<long, IServerStreamWriter<DrawPoint>> kvp in receivers)
            {
                if(kvp.Key == sender) continue;
                kvp.Value.WriteAsync(drawPoint);
            }
        }

        public bool AddReceiver(IServerStreamWriter<DrawPoint> receiver, long id)
        {
            return receivers.TryAdd(id, receiver);
        }

        public IEnumerable<long> GetReceivers()
        {
            return receivers.Keys;
        }

        public void RemoveReceiver(long id)
        {
            receivers[id] = null;
        }
    }
}