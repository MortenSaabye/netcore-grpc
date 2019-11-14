using System;
using System.Threading;

namespace gRPCServer.Services
{
    public class IdentityService : IIdentityService
    {
        public IdentityService()
        {
            currentId = -1;
        }
        private long currentId;
        public long GetNextId()
        {
            return Interlocked.Increment(ref currentId);
        }
    }
}
