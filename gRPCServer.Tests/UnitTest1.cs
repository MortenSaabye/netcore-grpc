using NUnit.Framework;
using gRPCServer.Services;
using Grpc;

namespace gRPCServer.Tests
{
    public class Tests
    {
        private readonly IBroadcastService _broadcastService;
        public Tests()
        {
            _broadcastService = new BroadcastService();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // var receiver = new IServerStreamWriter<DrawPoint>();
            Assert.Pass();
        }
    }
}