using Grpc.Core;
using NLog;
using rlcx.Protobuf.Examples.AddressBook;
using Server.Properties;
using Server.Services;

namespace Server
{
    public class ServerService
    {
        private readonly int _port = Settings.Default.ListeningPort;
        private Grpc.Core.Server _grpcServer;
        private readonly Logger _log = LogManager.GetCurrentClassLogger();

        public void Start()
        {
            _grpcServer = new Grpc.Core.Server
            {
                Services = { SearchServer.BindService(new SearchService())},
                Ports = {new ServerPort("localhost", _port, ServerCredentials.Insecure)}
            };

            _grpcServer.Start();

            _log.Info("Server listening on port " + _port);
            
        }

        public void Stop()
        {
            _grpcServer.ShutdownAsync().Wait();
        }


        
    }
}