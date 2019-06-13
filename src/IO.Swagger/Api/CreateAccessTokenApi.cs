using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
  public class CreateAccessTokenApi : ApiBase
  {
    public CreateAccessTokenApi()
    {
    }

    public CreateAccessTokenApi(Configuration configuration) : base(configuration)
    {
    }

    /// <summary>
    ///   The Access Token is used in all following API calls as authentication token The Access Token is used in all following
    ///   API calls as authentication token
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="request"> (optional)</param>
    /// <returns>AccessTokenResponse</returns>
    public AccessTokenResponse AccessTokenRequest(AccessTokenRequest request)
    {
      var localVarResponse = AccessTokenRequestWithHttpInfo(request);

      return localVarResponse.Data;
    }

    /// <summary>
    ///   The Access Token is used in all following API calls as authentication token The Access Token is used in all following
    ///   API calls as authentication token
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="request"> (optional)</param>
    /// <returns>ApiResponse of AccessTokenResponse</returns>
    public ApiResponse<AccessTokenResponse> AccessTokenRequestWithHttpInfo(AccessTokenRequest request)
    {
      var localVarPath = "/create/accesstoken";
      var localVarPathParams = new Dictionary<string, string>();
      var localVarQueryParams = new Dictionary<string, string>();
      var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
      var localVarFormParams = new Dictionary<string, string>();
      var localVarFileParams = new Dictionary<string, FileParameter>();
      object localVarPostBody = null;

      // to determine the Content-Type header
      var localVarHttpContentTypes = new [] {"application/x-www-form-urlencoded"};
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
        localVarPath, Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
        localVarFileParams, localVarPathParams, localVarHttpContentType
      );

      var localVarStatusCode = (int) localVarResponse.StatusCode;

      var exception = ExceptionFactory?.Invoke("AccessTokenRequestaccesstokenPost", localVarResponse);

      if (exception != null)
      {
        throw exception;
      }

      return new ApiResponse<AccessTokenResponse>
      (
        localVarStatusCode, 
        localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
        (AccessTokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccessTokenResponse))
      );
    }

    /// <summary>
    ///   The Access Token is used in all following API calls as authentication token The Access Token is used in all following
    ///   API calls as authentication token
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="request"> (optional)</param>
    /// <returns>Task of AccessTokenResponse</returns>
    public async Task<AccessTokenResponse> AccessTokenRequestAsync(AccessTokenRequest request)
    {
      var localVarResponse = await AccessTokenRequestAsyncWithHttpInfo(request);

      return localVarResponse.Data;
    }

    /// <summary>
    ///   The Access Token is used in all following API calls as authentication token The Access Token is used in all following
    ///   API calls as authentication token
    /// </summary>
    /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="request"> (optional)</param>
    /// <returns>Task of ApiResponse (AccessTokenResponse)</returns>
    public async Task<ApiResponse<AccessTokenResponse>> AccessTokenRequestAsyncWithHttpInfo(AccessTokenRequest request)
    {
      var localVarPath = "/create/accesstoken";
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

      localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter

      // make the HTTP request
      var localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync
      (
        localVarPath, Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
        localVarFileParams, localVarPathParams, localVarHttpContentType
      );

      var localVarStatusCode = (int) localVarResponse.StatusCode;

      var exception = ExceptionFactory?.Invoke("AccessTokenRequestaccesstokenPost", localVarResponse);

      if (exception != null)
      {
        throw exception;
      }

      return new ApiResponse<AccessTokenResponse>
      (
        localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
        (AccessTokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccessTokenResponse))
      );
    }
  }
}