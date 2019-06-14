using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
  public class ConfirmInvoiceApi : ApiBase
  {
    public ConfirmInvoiceApi()
    {
    }

    public ConfirmInvoiceApi(Configuration config) : base(config)
    {
    }

    /// <summary>
    ///   The confirm invoice call confirms the reception of an invoice document. The Server marks the invoice as transferred
    ///   and removes it from the list of validatable/importable invoices. If an invoice is not confirmed by the ERP System, it
    ///   will be moved to the end of the downloadable invoices-list and then provided again. The confirm invoice call confirms
    ///   the reception of an invoice document. The Server marks the invoice as transferred and removes it from the list of
    ///   validatable/importable invoices. If an invoice is not confirmed by the ERP System, it will be moved to the end of the
    ///   downloadable invoices-list and then provided again.
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>  
    /// <param name="request"> (optional)</param>
    /// <returns>ConfirmationResponse</returns>
    public ConfirmationResponse PostConfirmInvoiceRequest(ConfirmInvoiceRequest request)
    {
      var localVarResponse = PostConfirmInvoiceRequestWithHttpInfo(request);
      return localVarResponse.Data;
    }

    /// <summary>
    ///   The confirm invoice call confirms the reception of an invoice document. The Server marks the invoice as transferred
    ///   and removes it from the list of validatable/importable invoices. If an invoice is not confirmed by the ERP System, it
    ///   will be moved to the end of the downloadable invoices-list and then provided again. The confirm invoice call confirms
    ///   the reception of an invoice document. The Server marks the invoice as transferred and removes it from the list of
    ///   validatable/importable invoices. If an invoice is not confirmed by the ERP System, it will be moved to the end of the
    ///   downloadable invoices-list and then provided again.
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="request"> (optional)</param>
    /// <returns>ApiResponse of ConfirmationResponse</returns>
    public ApiResponse<ConfirmationResponse> PostConfirmInvoiceRequestWithHttpInfo(ConfirmInvoiceRequest request)
    {
      var localVarPath = "/confirm/invoice";
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
        
      localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter

      // make the HTTP request
      var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi
      (
        localVarPath, Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, 
        localVarFormParams, localVarFileParams, localVarPathParams, localVarHttpContentType
      );

      var localVarStatusCode = (int) localVarResponse.StatusCode;

      var exception = ExceptionFactory?.Invoke("ConfirmInvoiceRequestinvoicePost", localVarResponse);

      if (exception != null)
      {
        throw exception;
      }

      return new ApiResponse<ConfirmationResponse>
      (
        localVarStatusCode,
        localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
        (ConfirmationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfirmationResponse))
      );
    }

    /// <summary>
    ///   The confirm invoice call confirms the reception of an invoice document. The Server marks the invoice as transferred
    ///   and removes it from the list of validatable/importable invoices. If an invoice is not confirmed by the ERP System, it
    ///   will be moved to the end of the downloadable invoices-list and then provided again. The confirm invoice call confirms
    ///   the reception of an invoice document. The Server marks the invoice as transferred and removes it from the list of
    ///   validatable/importable invoices. If an invoice is not confirmed by the ERP System, it will be moved to the end of the
    ///   downloadable invoices-list and then provided again.
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="request"> (optional)</param>
    /// <returns>Task of ConfirmationResponse</returns>
    public async Task<ConfirmationResponse> PostConfirmInvoiceRequestAsync(ConfirmInvoiceRequest request)
    {
      var localVarResponse = await PostConfirmInvoiceRequestAsyncWithHttpInfo(request);
      return localVarResponse.Data;
    }

    /// <summary>
    ///   The confirm invoice call confirms the reception of an invoice document. The Server marks the invoice as transferred
    ///   and removes it from the list of validatable/importable invoices. If an invoice is not confirmed by the ERP System, it
    ///   will be moved to the end of the downloadable invoices-list and then provided again. The confirm invoice call confirms
    ///   the reception of an invoice document. The Server marks the invoice as transferred and removes it from the list of
    ///   validatable/importable invoices. If an invoice is not confirmed by the ERP System, it will be moved to the end of the
    ///   downloadable invoices-list and then provided again.
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"> (optional)</param>
    /// <returns>Task of ApiResponse (ConfirmationResponse)</returns>
    public async Task<ApiResponse<ConfirmationResponse>> PostConfirmInvoiceRequestAsyncWithHttpInfo(ConfirmInvoiceRequest request)
    {
      var localVarPath = "/confirm/invoice";
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

      localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter

      // make the HTTP request
      var localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync
      (
        localVarPath, Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, 
        localVarFormParams, localVarFileParams, localVarPathParams, localVarHttpContentType
      );

      var localVarStatusCode = (int) localVarResponse.StatusCode;

      var exception = ExceptionFactory?.Invoke("ConfirmInvoiceRequestinvoicePost", localVarResponse);

      if (exception != null)
      {
        throw exception;
      }

      return new ApiResponse<ConfirmationResponse>
      (
        localVarStatusCode,
        localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
        (ConfirmationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfirmationResponse))
      );
    }
  }
}