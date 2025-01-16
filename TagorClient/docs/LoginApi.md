# TagorClient.Api.LoginApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LoginToken**](LoginApi.md#logintoken) | **POST** /Login/Token | Login/Token |

<a id="logintoken"></a>
# **LoginToken**
> LoginResponse LoginToken (string grantType, string clientSecret, string? clientId = null)

Login/Token

If you received an API key from Organi there is no need to call this endpoint. The API key can be passed directly in the `Authorization` header. - `client_credentials` requires you to pass the Tagor credentials in `client_id` and `client_secret`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class LoginTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            var apiInstance = new LoginApi(config);
            var grantType = "client_credentials";  // string | 
            var clientSecret = "clientSecret_example";  // string | 
            var clientId = "clientId_example";  // string? |  (optional) 

            try
            {
                // Login/Token
                LoginResponse result = apiInstance.LoginToken(grantType, clientSecret, clientId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginApi.LoginToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Login/Token
    ApiResponse<LoginResponse> response = apiInstance.LoginTokenWithHttpInfo(grantType, clientSecret, clientId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginApi.LoginTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **grantType** | **string** |  |  |
| **clientSecret** | **string** |  |  |
| **clientId** | **string?** |  | [optional]  |

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Multiple return values. See Resonse samples. |  -  |
| **401** | Client authentication failed. |  -  |
| **422** | Client issue. Contact Organi. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

