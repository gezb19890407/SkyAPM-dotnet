// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TraceSegmentService.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace SkyWalking.NetworkProtocol {
  public static partial class TraceSegmentService
  {
    static readonly string __ServiceName = "SkyWalking.NetworkProtocol.TraceSegmentService";

    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.UpstreamSegment> __Marshaller_UpstreamSegment = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SkyWalking.NetworkProtocol.UpstreamSegment.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SkyWalking.NetworkProtocol.Downstream> __Marshaller_Downstream = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SkyWalking.NetworkProtocol.Downstream.Parser.ParseFrom);

    static readonly grpc::Method<global::SkyWalking.NetworkProtocol.UpstreamSegment, global::SkyWalking.NetworkProtocol.Downstream> __Method_collect = new grpc::Method<global::SkyWalking.NetworkProtocol.UpstreamSegment, global::SkyWalking.NetworkProtocol.Downstream>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "collect",
        __Marshaller_UpstreamSegment,
        __Marshaller_Downstream);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SkyWalking.NetworkProtocol.TraceSegmentServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TraceSegmentService</summary>
    public abstract partial class TraceSegmentServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::SkyWalking.NetworkProtocol.Downstream> collect(grpc::IAsyncStreamReader<global::SkyWalking.NetworkProtocol.UpstreamSegment> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TraceSegmentService</summary>
    public partial class TraceSegmentServiceClient : grpc::ClientBase<TraceSegmentServiceClient>
    {
      /// <summary>Creates a new client for TraceSegmentService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TraceSegmentServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TraceSegmentService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TraceSegmentServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TraceSegmentServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TraceSegmentServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncClientStreamingCall<global::SkyWalking.NetworkProtocol.UpstreamSegment, global::SkyWalking.NetworkProtocol.Downstream> collect(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return collect(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::SkyWalking.NetworkProtocol.UpstreamSegment, global::SkyWalking.NetworkProtocol.Downstream> collect(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_collect, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TraceSegmentServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TraceSegmentServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TraceSegmentServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_collect, serviceImpl.collect).Build();
    }

  }
}
#endregion