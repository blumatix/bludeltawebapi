using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
  /// <summary>
  /// Provides methods for uploading a new invoice to the bludeltawebapi service
  /// </summary>
  public class UploadInvoiceApi
  {
    private ExceptionFactory _exceptionFactory = (name, response) => null;

    public UploadInvoiceApi()
    {
      // use the default one in Configuration
      Configuration = Configuration.Default;

      ExceptionFactory = Configuration.DefaultExceptionFactory;

      // ensure API client has configuration ready
      if (Configuration.ApiClient.Configuration == null)
      {
        Configuration.ApiClient.Configuration = Configuration;
      }
    }

    public Configuration Configuration { get; set; }

    /// <summary>
    /// Provides a factory method hook for the creation of exceptions.
    /// </summary>
    public ExceptionFactory ExceptionFactory
    {
      get
      {
        if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
        {
          throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
        }
        return _exceptionFactory;
      }
      set => _exceptionFactory = value;
    }

    /// <summary>
    /// Upload an InvoiceContainer
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="request"></param>
    /// <returns>UploadInvoiceContainerResponse</returns>
    public UploadInvoiceContainerResponse UploadInvoiceContainer(UploadInvoiceContainerRequest request)
    {
      var localVarResponse = UploadInvoiceContainerWithHttpInfo(request);

      return localVarResponse.Data;
    }

    /// <summary>
    /// Upload an InvoiceContainer
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="request"> (optional)</param>
    /// <returns>ApiResponse of UploadInvoiceContainerResponse</returns>
    public ApiResponse<UploadInvoiceContainerResponse> UploadInvoiceContainerWithHttpInfo(UploadInvoiceContainerRequest request)
    {
      var localVarPath = "/upload/invoiceContainer";
      var localVarPathParams = new Dictionary<string, string>();
      var localVarQueryParams = new Dictionary<string, string>();
      var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
      var localVarFormParams = new Dictionary<string, string>();
      var localVarFileParams = new Dictionary<string, FileParameter>();

      // to determine the Content-Type header
      var localVarHttpContentTypes = new[] { "application/json" };
      var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

      // to determine the Accept header
      var localVarHttpHeaderAccepts = new[] { "application/json" };
      var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

      if (localVarHttpHeaderAccept != null)
        localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

      // http body (model) parameter
      var localVarPostBody = Configuration.ApiClient.Serialize(request);

      // make the HTTP request
      var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi
      (
        localVarPath, Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams,
        localVarFormParams, localVarFileParams, localVarPathParams, localVarHttpContentType
      );

      var localVarStatusCode = (int)localVarResponse.StatusCode;

      var exception = ExceptionFactory?.Invoke("UploadInvoiceContainer", localVarResponse);

      if (exception != null)
      {
        throw exception;
      }

      return new ApiResponse<UploadInvoiceContainerResponse>
      (
        localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
        (UploadInvoiceContainerResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadInvoiceContainerResponse))
      );
    }

    /// <summary>
    /// Upload an InvoiceContainer
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="request"> (optional)</param>
    /// <returns>Task of UploadInvoiceContainerResponse</returns>
    public async Task<UploadInvoiceContainerResponse> UploadInvoiceContainerAsync(UploadInvoiceContainerRequest request)
    {
      var localVarResponse = await UploadInvoiceContainerWithHttpInfoAsync(request);

      return localVarResponse.Data;

    }

    /// <summary>
    /// Upload an InvoiceContainer
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="request"></param>
    /// <returns>Task of ApiResponse (UploadInvoiceContainerResponse)</returns>
    public async Task<ApiResponse<UploadInvoiceContainerResponse>> UploadInvoiceContainerWithHttpInfoAsync(UploadInvoiceContainerRequest request)
    {
      var localVarPath = "/upload/invoiceContainer";
      var localVarPathParams = new Dictionary<string, string>();
      var localVarQueryParams = new Dictionary<string, string>();
      var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
      var localVarFormParams = new Dictionary<string, string>();
      var localVarFileParams = new Dictionary<string, FileParameter>();

      // to determine the Content-Type header
      var localVarHttpContentTypes = new[] { "application/json" };
      var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

      // to determine the Accept header
      var localVarHttpHeaderAccepts = new[] { "application/json" };
      var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

      if (localVarHttpHeaderAccept != null)
        localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

      // http body (model) parameter
      var localVarPostBody = Configuration.ApiClient.Serialize(request);

      // make the HTTP request
      var localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync
      (
        localVarPath, Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams,
        localVarFormParams, localVarFileParams, localVarPathParams, localVarHttpContentType
      );

      var localVarStatusCode = (int)localVarResponse.StatusCode;

      var exception = ExceptionFactory?.Invoke("UploadInvoiceContainer", localVarResponse);

      if (exception != null)
      {
        throw exception;
      }

      return new ApiResponse<UploadInvoiceContainerResponse>
      (
        localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
        (UploadInvoiceContainerResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UploadInvoiceContainerResponse))
      );
    }

  }
}