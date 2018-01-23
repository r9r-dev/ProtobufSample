using System;
using System.Threading.Tasks;
using Grpc.Core;
using NLog;
using rlcx.Protobuf.Examples.AddressBook;

namespace Server.Services
{
    public class SearchService : SearchServer.SearchServerBase
    {
        private readonly Logger _log = LogManager.GetCurrentClassLogger();

        /// <inheritdoc />
        public override Task<SearchResponse> Search(SearchRequest request, ServerCallContext context)
        {
            _log.Info($"Search:{request.Term}");


            var ronan = new Person
            {
                Id = 1234,
                Email = "ronan@gmail.com",
                Name = request.Term,
                Phones =
                {
                    new Person.Types.PhoneNumber
                    {
                        Number = "+33 6 44 66 46 64",
                        Type = Person.Types.PhoneType.Mobile
                    }
                }
            };
            
            return Task.FromResult(new SearchResponse
            {
                People = { ronan }
            });
        }

        
    }
}
