using System;
using System.Linq;
using rlcx.Protobuf.Examples.AddressBook;
using Grpc.Core;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
            var client = new SearchServer.SearchServerClient(channel);

            while (true)
            {
                var result = Console.ReadLine();
                if (result == "exit")
                {
                    channel.ShutdownAsync().Wait();
                    break;
                }
                
                var reply = client.Search(new SearchRequest
                {
                    Term = result
                });

                var p = reply.People.First();

                Console.WriteLine($"Answer:{p.Name}");

            }
        }
    }
}
