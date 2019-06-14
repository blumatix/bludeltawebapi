using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
  public class ImportInvoiceApi : ApiBase
  {
    public ImportInvoiceApi()
    {
    }

    public ImportInvoiceApi(Configuration config) : base(config)
    {
    }

    /// <summary>
    ///   Get a single invoice together with the DetectInvoiceResponse. The client should repeat this call until the property
    ///   Available &#x3D; false. Get a single invoice together with the DetectInvoiceResponse. The client should repeat this
    ///   call until the property Available &#x3D; false.
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ImportInvoiceResponse</returns>
    public ImportInvoiceResponse GetImportInvoiceRequest()
    {
      var localVarResponse = GetImportInvoiceRequestWithHttpInfo();
      return localVarResponse.Data;
    }

    /// <summary>
    ///   Get a single invoice together with the DetectInvoiceResponse. The client should repeat this call until the property
    ///   Available &#x3D; false. Get a single invoice together with the DetectInvoiceResponse. The client should repeat this
    ///   call until the property Available &#x3D; false.
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of ImportInvoiceResponse</returns>
    public ApiResponse<ImportInvoiceResponse> GetImportInvoiceRequestWithHttpInfo()
    {
      var localVarPath = "/import/invoice";
      var localVarPathParams = new Dictionary<string, string>();
      var localVarQueryParams = new Dictionary<string, string>();
      var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
      var localVarFormParams = new Dictionary<string, string>();
      var localVarFileParams = new Dictionary<string, FileParameter>();
      object localVarPostBody = null;

      // to determine the Content-Type header
      var localVarHttpContentTypes = new [] {"application/json"};
      var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

      // to determine the Accept header
      var localVarHttpHeaderAccepts = new [] { "application/json" };
      var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

      if (localVarHttpHeaderAccept != null)
      {
        localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
      }

      // make the HTTP request
      var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi
      ( 
        localVarPath, Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, 
        localVarFormParams, localVarFileParams, localVarPathParams, localVarHttpContentType
      );

      var localVarStatusCode = (int) localVarResponse.StatusCode;

      var exception = ExceptionFactory?.Invoke("ImportInvoiceRequestinvoiceGet", localVarResponse);

      if (exception != null)
      {
        throw exception;
      }

      return new ApiResponse<ImportInvoiceResponse>
      (
        localVarStatusCode,
        localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
        (ImportInvoiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportInvoiceResponse))
      );
    }

    /// <summary>
    ///   Get a single invoice together with the DetectInvoiceResponse. The client should repeat this call until the property
    ///   Available &#x3D; false. Get a single invoice together with the DetectInvoiceResponse. The client should repeat this
    ///   call until the property Available &#x3D; false.
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accept">Accept Header</param>
    /// <returns>Task of ImportInvoiceResponse</returns>
    public async Task<ImportInvoiceResponse> GetImportInvoiceRequestAsync(string accept)
    {
      var localVarResponse = await GetImportInvoiceRequestAsyncWithHttpInfo(accept);
      return localVarResponse.Data;
    }

    /// <summary>
    ///   Get a single invoice together with the DetectInvoiceResponse. The client should repeat this call until the property
    ///   Available &#x3D; false. Get a single invoice together with the DetectInvoiceResponse. The client should repeat this
    ///   call until the property Available &#x3D; false.
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accept">Accept Header</param>
    /// <returns>Task of ApiResponse (ImportInvoiceResponse)</returns>
    public async Task<ApiResponse<ImportInvoiceResponse>> GetImportInvoiceRequestAsyncWithHttpInfo(string accept)
    {
      var localVarPath = "/import/invoice";
      var localVarPathParams = new Dictionary<string, string>();
      var localVarQueryParams = new Dictionary<string, string>();
      var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
      var localVarFormParams = new Dictionary<string, string>();
      var localVarFileParams = new Dictionary<string, FileParameter>();
      object localVarPostBody = null;

      // to determine the Content-Type header
      var localVarHttpContentTypes = new [] { "application/json" };
      var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

      // to determine the Accept header
      var localVarHttpHeaderAccepts = new [] { "application/json" };
      var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

      if (localVarHttpHeaderAccept != null)
      {
        localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
      }

      // make the HTTP request
      var localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync
      (
        localVarPath, Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, 
        localVarFormParams, localVarFileParams, localVarPathParams, localVarHttpContentType
      );

      var localVarStatusCode = (int) localVarResponse.StatusCode;

      var exception = ExceptionFactory?.Invoke("ImportInvoiceRequestinvoiceGet", localVarResponse);

      if (exception != null)
      {
        throw exception;
      }

      return new ApiResponse<ImportInvoiceResponse>
      (
        localVarStatusCode,
        localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
        (ImportInvoiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportInvoiceResponse))
      );
    }
  }
}