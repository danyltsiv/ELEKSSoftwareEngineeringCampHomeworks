// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: WaiterService.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace WaiterServiceProto {
  public static class WaiterService
  {
    static readonly string __ServiceName = "WaiterServiceProto.WaiterService";

    static readonly Marshaller<global::WaiterServiceProto.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::WaiterServiceProto.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::WaiterServiceProto.productArr> __Marshaller_productArr = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::WaiterServiceProto.productArr.Parser.ParseFrom);
    static readonly Marshaller<global::WaiterServiceProto.Order> __Marshaller_Order = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::WaiterServiceProto.Order.Parser.ParseFrom);
    static readonly Marshaller<global::WaiterServiceProto.Bool> __Marshaller_Bool = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::WaiterServiceProto.Bool.Parser.ParseFrom);
    static readonly Marshaller<global::WaiterServiceProto.Id> __Marshaller_Id = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::WaiterServiceProto.Id.Parser.ParseFrom);
    static readonly Marshaller<global::WaiterServiceProto.orderArr> __Marshaller_orderArr = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::WaiterServiceProto.orderArr.Parser.ParseFrom);

    static readonly Method<global::WaiterServiceProto.Empty, global::WaiterServiceProto.productArr> __Method_checkProducts = new Method<global::WaiterServiceProto.Empty, global::WaiterServiceProto.productArr>(
        MethodType.Unary,
        __ServiceName,
        "checkProducts",
        __Marshaller_Empty,
        __Marshaller_productArr);

    static readonly Method<global::WaiterServiceProto.Order, global::WaiterServiceProto.Bool> __Method_addOrder = new Method<global::WaiterServiceProto.Order, global::WaiterServiceProto.Bool>(
        MethodType.Unary,
        __ServiceName,
        "addOrder",
        __Marshaller_Order,
        __Marshaller_Bool);

    static readonly Method<global::WaiterServiceProto.Id, global::WaiterServiceProto.Bool> __Method_closeOrder = new Method<global::WaiterServiceProto.Id, global::WaiterServiceProto.Bool>(
        MethodType.Unary,
        __ServiceName,
        "closeOrder",
        __Marshaller_Id,
        __Marshaller_Bool);

    static readonly Method<global::WaiterServiceProto.Id, global::WaiterServiceProto.Bool> __Method_cancelOrder = new Method<global::WaiterServiceProto.Id, global::WaiterServiceProto.Bool>(
        MethodType.Unary,
        __ServiceName,
        "cancelOrder",
        __Marshaller_Id,
        __Marshaller_Bool);

    static readonly Method<global::WaiterServiceProto.Empty, global::WaiterServiceProto.orderArr> __Method_getActiveOrders = new Method<global::WaiterServiceProto.Empty, global::WaiterServiceProto.orderArr>(
        MethodType.Unary,
        __ServiceName,
        "getActiveOrders",
        __Marshaller_Empty,
        __Marshaller_orderArr);

    static readonly Method<global::WaiterServiceProto.Empty, global::WaiterServiceProto.orderArr> __Method_getClosedOrders = new Method<global::WaiterServiceProto.Empty, global::WaiterServiceProto.orderArr>(
        MethodType.Unary,
        __ServiceName,
        "getClosedOrders",
        __Marshaller_Empty,
        __Marshaller_orderArr);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::WaiterServiceProto.WaiterServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for WaiterService</summary>
    [System.Obsolete("Client side interfaced will be removed in the next release. Use client class directly.")]
    public interface IWaiterServiceClient
    {
      global::WaiterServiceProto.productArr checkProducts(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::WaiterServiceProto.productArr checkProducts(global::WaiterServiceProto.Empty request, CallOptions options);
      AsyncUnaryCall<global::WaiterServiceProto.productArr> checkProductsAsync(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::WaiterServiceProto.productArr> checkProductsAsync(global::WaiterServiceProto.Empty request, CallOptions options);
      global::WaiterServiceProto.Bool addOrder(global::WaiterServiceProto.Order request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::WaiterServiceProto.Bool addOrder(global::WaiterServiceProto.Order request, CallOptions options);
      AsyncUnaryCall<global::WaiterServiceProto.Bool> addOrderAsync(global::WaiterServiceProto.Order request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::WaiterServiceProto.Bool> addOrderAsync(global::WaiterServiceProto.Order request, CallOptions options);
      global::WaiterServiceProto.Bool closeOrder(global::WaiterServiceProto.Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::WaiterServiceProto.Bool closeOrder(global::WaiterServiceProto.Id request, CallOptions options);
      AsyncUnaryCall<global::WaiterServiceProto.Bool> closeOrderAsync(global::WaiterServiceProto.Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::WaiterServiceProto.Bool> closeOrderAsync(global::WaiterServiceProto.Id request, CallOptions options);
      global::WaiterServiceProto.Bool cancelOrder(global::WaiterServiceProto.Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::WaiterServiceProto.Bool cancelOrder(global::WaiterServiceProto.Id request, CallOptions options);
      AsyncUnaryCall<global::WaiterServiceProto.Bool> cancelOrderAsync(global::WaiterServiceProto.Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::WaiterServiceProto.Bool> cancelOrderAsync(global::WaiterServiceProto.Id request, CallOptions options);
      global::WaiterServiceProto.orderArr getActiveOrders(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::WaiterServiceProto.orderArr getActiveOrders(global::WaiterServiceProto.Empty request, CallOptions options);
      AsyncUnaryCall<global::WaiterServiceProto.orderArr> getActiveOrdersAsync(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::WaiterServiceProto.orderArr> getActiveOrdersAsync(global::WaiterServiceProto.Empty request, CallOptions options);
      global::WaiterServiceProto.orderArr getClosedOrders(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::WaiterServiceProto.orderArr getClosedOrders(global::WaiterServiceProto.Empty request, CallOptions options);
      AsyncUnaryCall<global::WaiterServiceProto.orderArr> getClosedOrdersAsync(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::WaiterServiceProto.orderArr> getClosedOrdersAsync(global::WaiterServiceProto.Empty request, CallOptions options);
    }

    /// <summary>Interface of server-side implementations of WaiterService</summary>
    [System.Obsolete("Service implementations should inherit from the generated abstract base class instead.")]
    public interface IWaiterService
    {
      global::System.Threading.Tasks.Task<global::WaiterServiceProto.productArr> checkProducts(global::WaiterServiceProto.Empty request, ServerCallContext context);
      global::System.Threading.Tasks.Task<global::WaiterServiceProto.Bool> addOrder(global::WaiterServiceProto.Order request, ServerCallContext context);
      global::System.Threading.Tasks.Task<global::WaiterServiceProto.Bool> closeOrder(global::WaiterServiceProto.Id request, ServerCallContext context);
      global::System.Threading.Tasks.Task<global::WaiterServiceProto.Bool> cancelOrder(global::WaiterServiceProto.Id request, ServerCallContext context);
      global::System.Threading.Tasks.Task<global::WaiterServiceProto.orderArr> getActiveOrders(global::WaiterServiceProto.Empty request, ServerCallContext context);
      global::System.Threading.Tasks.Task<global::WaiterServiceProto.orderArr> getClosedOrders(global::WaiterServiceProto.Empty request, ServerCallContext context);
    }

    /// <summary>Base class for server-side implementations of WaiterService</summary>
    public abstract class WaiterServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::WaiterServiceProto.productArr> checkProducts(global::WaiterServiceProto.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::WaiterServiceProto.Bool> addOrder(global::WaiterServiceProto.Order request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::WaiterServiceProto.Bool> closeOrder(global::WaiterServiceProto.Id request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::WaiterServiceProto.Bool> cancelOrder(global::WaiterServiceProto.Id request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::WaiterServiceProto.orderArr> getActiveOrders(global::WaiterServiceProto.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::WaiterServiceProto.orderArr> getClosedOrders(global::WaiterServiceProto.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for WaiterService</summary>
    #pragma warning disable 0618
    public class WaiterServiceClient : ClientBase<WaiterServiceClient>, IWaiterServiceClient
    #pragma warning restore 0618
    {
      public WaiterServiceClient(Channel channel) : base(channel)
      {
      }
      public WaiterServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      ///<summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected WaiterServiceClient() : base()
      {
      }
      ///<summary>Protected constructor to allow creation of configured clients.</summary>
      protected WaiterServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::WaiterServiceProto.productArr checkProducts(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return checkProducts(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::WaiterServiceProto.productArr checkProducts(global::WaiterServiceProto.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_checkProducts, null, options, request);
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.productArr> checkProductsAsync(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return checkProductsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.productArr> checkProductsAsync(global::WaiterServiceProto.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_checkProducts, null, options, request);
      }
      public virtual global::WaiterServiceProto.Bool addOrder(global::WaiterServiceProto.Order request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return addOrder(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::WaiterServiceProto.Bool addOrder(global::WaiterServiceProto.Order request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_addOrder, null, options, request);
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.Bool> addOrderAsync(global::WaiterServiceProto.Order request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return addOrderAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.Bool> addOrderAsync(global::WaiterServiceProto.Order request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_addOrder, null, options, request);
      }
      public virtual global::WaiterServiceProto.Bool closeOrder(global::WaiterServiceProto.Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return closeOrder(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::WaiterServiceProto.Bool closeOrder(global::WaiterServiceProto.Id request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_closeOrder, null, options, request);
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.Bool> closeOrderAsync(global::WaiterServiceProto.Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return closeOrderAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.Bool> closeOrderAsync(global::WaiterServiceProto.Id request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_closeOrder, null, options, request);
      }
      public virtual global::WaiterServiceProto.Bool cancelOrder(global::WaiterServiceProto.Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return cancelOrder(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::WaiterServiceProto.Bool cancelOrder(global::WaiterServiceProto.Id request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_cancelOrder, null, options, request);
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.Bool> cancelOrderAsync(global::WaiterServiceProto.Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return cancelOrderAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.Bool> cancelOrderAsync(global::WaiterServiceProto.Id request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_cancelOrder, null, options, request);
      }
      public virtual global::WaiterServiceProto.orderArr getActiveOrders(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return getActiveOrders(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::WaiterServiceProto.orderArr getActiveOrders(global::WaiterServiceProto.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getActiveOrders, null, options, request);
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.orderArr> getActiveOrdersAsync(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return getActiveOrdersAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.orderArr> getActiveOrdersAsync(global::WaiterServiceProto.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getActiveOrders, null, options, request);
      }
      public virtual global::WaiterServiceProto.orderArr getClosedOrders(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return getClosedOrders(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::WaiterServiceProto.orderArr getClosedOrders(global::WaiterServiceProto.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getClosedOrders, null, options, request);
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.orderArr> getClosedOrdersAsync(global::WaiterServiceProto.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return getClosedOrdersAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::WaiterServiceProto.orderArr> getClosedOrdersAsync(global::WaiterServiceProto.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getClosedOrders, null, options, request);
      }
      protected override WaiterServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WaiterServiceClient(configuration);
      }
    }

    /// <summary>Creates a new client for WaiterService</summary>
    public static WaiterServiceClient NewClient(Channel channel)
    {
      return new WaiterServiceClient(channel);
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    #pragma warning disable 0618
    public static ServerServiceDefinition BindService(IWaiterService serviceImpl)
    #pragma warning restore 0618
    {
      return ServerServiceDefinition.CreateBuilder(__ServiceName)
          .AddMethod(__Method_checkProducts, serviceImpl.checkProducts)
          .AddMethod(__Method_addOrder, serviceImpl.addOrder)
          .AddMethod(__Method_closeOrder, serviceImpl.closeOrder)
          .AddMethod(__Method_cancelOrder, serviceImpl.cancelOrder)
          .AddMethod(__Method_getActiveOrders, serviceImpl.getActiveOrders)
          .AddMethod(__Method_getClosedOrders, serviceImpl.getClosedOrders).Build();
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    #pragma warning disable 0618
    public static ServerServiceDefinition BindService(WaiterServiceBase serviceImpl)
    #pragma warning restore 0618
    {
      return ServerServiceDefinition.CreateBuilder(__ServiceName)
          .AddMethod(__Method_checkProducts, serviceImpl.checkProducts)
          .AddMethod(__Method_addOrder, serviceImpl.addOrder)
          .AddMethod(__Method_closeOrder, serviceImpl.closeOrder)
          .AddMethod(__Method_cancelOrder, serviceImpl.cancelOrder)
          .AddMethod(__Method_getActiveOrders, serviceImpl.getActiveOrders)
          .AddMethod(__Method_getClosedOrders, serviceImpl.getClosedOrders).Build();
    }

  }
}
#endregion
