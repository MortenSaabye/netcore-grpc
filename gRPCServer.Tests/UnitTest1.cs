using NUnit.Framework;
using gRPCServer.Services;
using Grpc;

namespace gRPCServer.Tests
{
    public class Tests
    {
        private readonly IBroadcastService _broadcastService;
        private IIdentityService _identityService;
        public Tests()
        {
            _broadcastService = new BroadcastService();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IdentityServiceShouldStartFromZero()
        {
            _identityService = new IdentityService();
            var id = _identityService.GetNextId();
            Assert.AreEqual(id, 0);
        }

         [Test]
        public void IdentityServiceShouldIncrement()
        {
            _identityService = new IdentityService();
            _identityService.GetNextId(); //0
            _identityService.GetNextId(); //1
            _identityService.GetNextId(); //2
            Assert.AreEqual(_identityService.GetNextId(), 3);
        }
    }
}