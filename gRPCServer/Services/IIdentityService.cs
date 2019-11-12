using System;

namespace gRPCServer.Services
{
    public interface IIdentityService
    {
        long GetNextId();
    }
}
