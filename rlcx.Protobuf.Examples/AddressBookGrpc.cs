// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: AddressBook.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace rlcx.Protobuf.Examples.AddressBook {
  public static partial class SearchServer
  {
    static readonly string __ServiceName = "test.SearchServer";

    static readonly grpc::Marshaller<global::rlcx.Protobuf.Examples.AddressBook.SearchRequest> __Marshaller_SearchRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::rlcx.Protobuf.Examples.AddressBook.SearchRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::rlcx.Protobuf.Examples.AddressBook.SearchResponse> __Marshaller_SearchResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::rlcx.Protobuf.Examples.AddressBook.SearchResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::rlcx.Protobuf.Examples.AddressBook.SearchRequest, global::rlcx.Protobuf.Examples.AddressBook.SearchResponse> __Method_Search = new grpc::Method<global::rlcx.Protobuf.Examples.AddressBook.SearchRequest, global::rlcx.Protobuf.Examples.AddressBook.SearchResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Search",
        __Marshaller_SearchRequest,
        __Marshaller_SearchResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::rlcx.Protobuf.Examples.AddressBook.AddressBookReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SearchServer</summary>
    public abstract partial class SearchServerBase
    {
      public virtual global::System.Threading.Tasks.Task<global::rlcx.Protobuf.Examples.AddressBook.SearchResponse> Search(global::rlcx.Protobuf.Examples.AddressBook.SearchRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SearchServer</summary>
    public partial class SearchServerClient : grpc::ClientBase<SearchServerClient>
    {
      /// <summary>Creates a new client for SearchServer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SearchServerClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SearchServer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SearchServerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SearchServerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SearchServerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::rlcx.Protobuf.Examples.AddressBook.SearchResponse Search(global::rlcx.Protobuf.Examples.AddressBook.SearchRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Search(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::rlcx.Protobuf.Examples.AddressBook.SearchResponse Search(global::rlcx.Protobuf.Examples.AddressBook.SearchRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Search, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::rlcx.Protobuf.Examples.AddressBook.SearchResponse> SearchAsync(global::rlcx.Protobuf.Examples.AddressBook.SearchRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::rlcx.Protobuf.Examples.AddressBook.SearchResponse> SearchAsync(global::rlcx.Protobuf.Examples.AddressBook.SearchRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Search, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SearchServerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SearchServerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SearchServerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Search, serviceImpl.Search).Build();
    }

  }
}
#endregion