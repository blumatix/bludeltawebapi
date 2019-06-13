using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
  public class ImportableInvoiceApi : ApiBase
  {
    public ImportableInvoiceApi()
    {}

    public ImportableInvoiceApi(Configuration configuration) : base(configuration)
    {}

    /// <summary>
    ///   Get the number of validatable invoices Get the number of validatable invoices
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>CountedInvoicesResponse</returns>
    public CountedInvoicesResponse GetImportableInvoiceRequest()
    {
      var localVarResponse = GetImportableInvoiceRequestWithHttpInfo();
      return localVarResponse.Data;
    }

    /// <summary>
    ///   Get the number of validatable invoices Get the number of validatable invoices
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of CountedInvoicesResponse</returns>
    public ApiResponse<CountedInvoicesResponse> GetImportableInvoiceRequestWithHttpInfo()
    {
      var localVarPath = "/importable/invoices";
      var localVarPathParams = new Dictionary<string, string>();
      var localVarQueryParams = new Dictionary<string, string>();
      var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
      var localVarFormParams = new Dictionary<string, string>();
      var localVarFileParams = new Dictionary<string, FileParameter>();
      object localVarPostBody = null;

      // to determine the Content-Type header
      var localVarHttpContentTypes = new[] { "application/json" };
      var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

      // to determine the Accept header
      var localVarHttpHeaderAccepts = new[] { "application/json" };
      var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

      if (localVarHttpHeaderAccept != null)
      {
        localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
      }

      // make the HTTP request
      var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi
      (
        localVarPath, Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
        localVarPathParams, localVarHttpContentType
      );

      var localVarStatusCode = (int) localVarResponse.StatusCode;

      var exception = ExceptionFactory?.Invoke("ValidatableInvoiceRequestinvoicesGet", localVarResponse);

      if (exception != null)
      {
        throw exception;
      }

      return new ApiResponse<CountedInvoicesResponse>
      (
        localVarStatusCode, 
        localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
        (CountedInvoicesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CountedInvoicesResponse))
      );
    }

    /// <summary>
    ///   Get the number of validatable invoices Get the number of validatable invoices
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of CountedInvoicesResponse</returns>
    public async Task<CountedInvoicesResponse> GetImportableInvoiceRequestAsync()
    {
      var localVarResponse = await GetImportableInvoiceRequestAsyncWithHttpInfo();
      return localVarResponse.Data;
    }

    /// <summary>
    ///   Get the number of validatable invoices Get the number of validatable invoices
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (CountedInvoicesResponse)</returns>
    public async Task<ApiResponse<CountedInvoicesResponse>> GetImportableInvoiceRequestAsyncWithHttpInfo()
    {
      var localVarPath = "/importable/invoices";
      var localVarPathParams = new Dictionary<string, string>();
      var localVarQueryParams = new Dictionary<string, string>();
      var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
      var localVarFormParams = new Dictionary<string, string>();
      var localVarFileParams = new Dictionary<string, FileParameter>();
      object localVarPostBody = null;

      // to determine the Content-Type header
      var localVarHttpContentTypes = new[] { "application/json" };
      var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

      // to determine the Accept header
      var localVarHttpHeaderAccepts = new[] { "application/json" };
      var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

      if (localVarHttpHeaderAccept != null)
      {
        localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
      }

      // make the HTTP request
      var localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync
      (
        localVarPath,
        Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
        localVarPathParams, localVarHttpContentType
      );

      var localVarStatusCode = (int) localVarResponse.StatusCode;

      var exception = ExceptionFactory?.Invoke("ValidatableInvoiceRequestinvoicesGet", localVarResponse);

      if (exception != null)
      {
        throw exception;
      }

      return new ApiResponse<CountedInvoicesResponse>
      (
        localVarStatusCode,
        localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
        (CountedInvoicesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CountedInvoicesResponse))
      );
    }
  }
}