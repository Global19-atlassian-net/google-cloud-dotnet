// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/recommendationengine/v1beta1/catalog_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.RecommendationEngine.V1Beta1 {
  /// <summary>
  /// Service for ingesting catalog information of the customer's website.
  /// </summary>
  public static partial class CatalogService
  {
    static readonly string __ServiceName = "google.cloud.recommendationengine.v1beta1.CatalogService";

    static readonly grpc::Marshaller<global::Google.Cloud.RecommendationEngine.V1Beta1.CreateCatalogItemRequest> __Marshaller_google_cloud_recommendationengine_v1beta1_CreateCatalogItemRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.RecommendationEngine.V1Beta1.CreateCatalogItemRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> __Marshaller_google_cloud_recommendationengine_v1beta1_CatalogItem = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.RecommendationEngine.V1Beta1.GetCatalogItemRequest> __Marshaller_google_cloud_recommendationengine_v1beta1_GetCatalogItemRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.RecommendationEngine.V1Beta1.GetCatalogItemRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsRequest> __Marshaller_google_cloud_recommendationengine_v1beta1_ListCatalogItemsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsResponse> __Marshaller_google_cloud_recommendationengine_v1beta1_ListCatalogItemsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.RecommendationEngine.V1Beta1.UpdateCatalogItemRequest> __Marshaller_google_cloud_recommendationengine_v1beta1_UpdateCatalogItemRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.RecommendationEngine.V1Beta1.UpdateCatalogItemRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.RecommendationEngine.V1Beta1.DeleteCatalogItemRequest> __Marshaller_google_cloud_recommendationengine_v1beta1_DeleteCatalogItemRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.RecommendationEngine.V1Beta1.DeleteCatalogItemRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.RecommendationEngine.V1Beta1.ImportCatalogItemsRequest> __Marshaller_google_cloud_recommendationengine_v1beta1_ImportCatalogItemsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.RecommendationEngine.V1Beta1.ImportCatalogItemsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.Operation.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.CreateCatalogItemRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> __Method_CreateCatalogItem = new grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.CreateCatalogItemRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateCatalogItem",
        __Marshaller_google_cloud_recommendationengine_v1beta1_CreateCatalogItemRequest,
        __Marshaller_google_cloud_recommendationengine_v1beta1_CatalogItem);

    static readonly grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.GetCatalogItemRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> __Method_GetCatalogItem = new grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.GetCatalogItemRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCatalogItem",
        __Marshaller_google_cloud_recommendationengine_v1beta1_GetCatalogItemRequest,
        __Marshaller_google_cloud_recommendationengine_v1beta1_CatalogItem);

    static readonly grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsResponse> __Method_ListCatalogItems = new grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListCatalogItems",
        __Marshaller_google_cloud_recommendationengine_v1beta1_ListCatalogItemsRequest,
        __Marshaller_google_cloud_recommendationengine_v1beta1_ListCatalogItemsResponse);

    static readonly grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.UpdateCatalogItemRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> __Method_UpdateCatalogItem = new grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.UpdateCatalogItemRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateCatalogItem",
        __Marshaller_google_cloud_recommendationengine_v1beta1_UpdateCatalogItemRequest,
        __Marshaller_google_cloud_recommendationengine_v1beta1_CatalogItem);

    static readonly grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.DeleteCatalogItemRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteCatalogItem = new grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.DeleteCatalogItemRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCatalogItem",
        __Marshaller_google_cloud_recommendationengine_v1beta1_DeleteCatalogItemRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.ImportCatalogItemsRequest, global::Google.LongRunning.Operation> __Method_ImportCatalogItems = new grpc::Method<global::Google.Cloud.RecommendationEngine.V1Beta1.ImportCatalogItemsRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ImportCatalogItems",
        __Marshaller_google_cloud_recommendationengine_v1beta1_ImportCatalogItemsRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CatalogService</summary>
    [grpc::BindServiceMethod(typeof(CatalogService), "BindService")]
    public abstract partial class CatalogServiceBase
    {
      /// <summary>
      /// Creates a catalog item.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> CreateCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.CreateCatalogItemRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets a specific catalog item.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> GetCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.GetCatalogItemRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets a list of catalog items.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsResponse> ListCatalogItems(global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates a catalog item. Partial updating is supported. Non-existing
      /// items will be created.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> UpdateCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.UpdateCatalogItemRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a catalog item.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.DeleteCatalogItemRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Bulk import of multiple catalog items. Request processing may be
      /// synchronous. No partial updating supported. Non-existing items will be
      /// created.
      ///
      /// Operation.response is of type ImportResponse. Note that it is
      /// possible for a subset of the items to be successfully updated.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> ImportCatalogItems(global::Google.Cloud.RecommendationEngine.V1Beta1.ImportCatalogItemsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CatalogService</summary>
    public partial class CatalogServiceClient : grpc::ClientBase<CatalogServiceClient>
    {
      /// <summary>Creates a new client for CatalogService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CatalogServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CatalogService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CatalogServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CatalogServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CatalogServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates a catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem CreateCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.CreateCatalogItemRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateCatalogItem(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem CreateCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.CreateCatalogItemRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateCatalogItem, null, options, request);
      }
      /// <summary>
      /// Creates a catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> CreateCatalogItemAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.CreateCatalogItemRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateCatalogItemAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> CreateCatalogItemAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.CreateCatalogItemRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateCatalogItem, null, options, request);
      }
      /// <summary>
      /// Gets a specific catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem GetCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.GetCatalogItemRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCatalogItem(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a specific catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem GetCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.GetCatalogItemRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCatalogItem, null, options, request);
      }
      /// <summary>
      /// Gets a specific catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> GetCatalogItemAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.GetCatalogItemRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCatalogItemAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a specific catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> GetCatalogItemAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.GetCatalogItemRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCatalogItem, null, options, request);
      }
      /// <summary>
      /// Gets a list of catalog items.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsResponse ListCatalogItems(global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListCatalogItems(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a list of catalog items.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsResponse ListCatalogItems(global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListCatalogItems, null, options, request);
      }
      /// <summary>
      /// Gets a list of catalog items.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsResponse> ListCatalogItemsAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListCatalogItemsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a list of catalog items.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsResponse> ListCatalogItemsAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListCatalogItems, null, options, request);
      }
      /// <summary>
      /// Updates a catalog item. Partial updating is supported. Non-existing
      /// items will be created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem UpdateCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.UpdateCatalogItemRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateCatalogItem(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates a catalog item. Partial updating is supported. Non-existing
      /// items will be created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem UpdateCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.UpdateCatalogItemRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateCatalogItem, null, options, request);
      }
      /// <summary>
      /// Updates a catalog item. Partial updating is supported. Non-existing
      /// items will be created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> UpdateCatalogItemAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.UpdateCatalogItemRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateCatalogItemAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates a catalog item. Partial updating is supported. Non-existing
      /// items will be created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem> UpdateCatalogItemAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.UpdateCatalogItemRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateCatalogItem, null, options, request);
      }
      /// <summary>
      /// Deletes a catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.DeleteCatalogItemRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCatalogItem(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteCatalogItem(global::Google.Cloud.RecommendationEngine.V1Beta1.DeleteCatalogItemRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteCatalogItem, null, options, request);
      }
      /// <summary>
      /// Deletes a catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCatalogItemAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.DeleteCatalogItemRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCatalogItemAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a catalog item.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCatalogItemAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.DeleteCatalogItemRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteCatalogItem, null, options, request);
      }
      /// <summary>
      /// Bulk import of multiple catalog items. Request processing may be
      /// synchronous. No partial updating supported. Non-existing items will be
      /// created.
      ///
      /// Operation.response is of type ImportResponse. Note that it is
      /// possible for a subset of the items to be successfully updated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation ImportCatalogItems(global::Google.Cloud.RecommendationEngine.V1Beta1.ImportCatalogItemsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ImportCatalogItems(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Bulk import of multiple catalog items. Request processing may be
      /// synchronous. No partial updating supported. Non-existing items will be
      /// created.
      ///
      /// Operation.response is of type ImportResponse. Note that it is
      /// possible for a subset of the items to be successfully updated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation ImportCatalogItems(global::Google.Cloud.RecommendationEngine.V1Beta1.ImportCatalogItemsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ImportCatalogItems, null, options, request);
      }
      /// <summary>
      /// Bulk import of multiple catalog items. Request processing may be
      /// synchronous. No partial updating supported. Non-existing items will be
      /// created.
      ///
      /// Operation.response is of type ImportResponse. Note that it is
      /// possible for a subset of the items to be successfully updated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> ImportCatalogItemsAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.ImportCatalogItemsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ImportCatalogItemsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Bulk import of multiple catalog items. Request processing may be
      /// synchronous. No partial updating supported. Non-existing items will be
      /// created.
      ///
      /// Operation.response is of type ImportResponse. Note that it is
      /// possible for a subset of the items to be successfully updated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> ImportCatalogItemsAsync(global::Google.Cloud.RecommendationEngine.V1Beta1.ImportCatalogItemsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ImportCatalogItems, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CatalogServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CatalogServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CatalogServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateCatalogItem, serviceImpl.CreateCatalogItem)
          .AddMethod(__Method_GetCatalogItem, serviceImpl.GetCatalogItem)
          .AddMethod(__Method_ListCatalogItems, serviceImpl.ListCatalogItems)
          .AddMethod(__Method_UpdateCatalogItem, serviceImpl.UpdateCatalogItem)
          .AddMethod(__Method_DeleteCatalogItem, serviceImpl.DeleteCatalogItem)
          .AddMethod(__Method_ImportCatalogItems, serviceImpl.ImportCatalogItems).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CatalogServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateCatalogItem, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.RecommendationEngine.V1Beta1.CreateCatalogItemRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem>(serviceImpl.CreateCatalogItem));
      serviceBinder.AddMethod(__Method_GetCatalogItem, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.RecommendationEngine.V1Beta1.GetCatalogItemRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem>(serviceImpl.GetCatalogItem));
      serviceBinder.AddMethod(__Method_ListCatalogItems, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.ListCatalogItemsResponse>(serviceImpl.ListCatalogItems));
      serviceBinder.AddMethod(__Method_UpdateCatalogItem, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.RecommendationEngine.V1Beta1.UpdateCatalogItemRequest, global::Google.Cloud.RecommendationEngine.V1Beta1.CatalogItem>(serviceImpl.UpdateCatalogItem));
      serviceBinder.AddMethod(__Method_DeleteCatalogItem, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.RecommendationEngine.V1Beta1.DeleteCatalogItemRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteCatalogItem));
      serviceBinder.AddMethod(__Method_ImportCatalogItems, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.RecommendationEngine.V1Beta1.ImportCatalogItemsRequest, global::Google.LongRunning.Operation>(serviceImpl.ImportCatalogItems));
    }

  }
}
#endregion