# TagorClient.Api.PayApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PayFinish**](PayApi.md#payfinish) | **POST** /Pay/Finish | Pay/Finish |
| [**PayStart**](PayApi.md#paystart) | **POST** /Pay/Start | Pay/Start |

<a id="payfinish"></a>
# **PayFinish**
> void PayFinish (string? redirectUrl = null, string? seal = null, string? interfaceVersion = null, string? locale = null, string? data = null)

Pay/Finish

Finishes the payment process. This should only be called by the SIPS servers.  _This endpoint will use the [`TagorService/OnlinePaymentReceived`](#operation/TagorServiceOnlinePaymentReceived) endpoint to create an informative payment record on the file._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class PayFinishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            var apiInstance = new PayApi(config);
            var redirectUrl = "redirectUrl_example";  // string? |  (optional) 
            var seal = "seal_example";  // string? |  (optional) 
            var interfaceVersion = "interfaceVersion_example";  // string? |  (optional) 
            var locale = "locale_example";  // string? |  (optional) 
            var data = "data_example";  // string? |  (optional) 

            try
            {
                // Pay/Finish
                apiInstance.PayFinish(redirectUrl, seal, interfaceVersion, locale, data);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayApi.PayFinish: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PayFinishWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pay/Finish
    apiInstance.PayFinishWithHttpInfo(redirectUrl, seal, interfaceVersion, locale, data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayApi.PayFinishWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **redirectUrl** | **string?** |  | [optional]  |
| **seal** | **string?** |  | [optional]  |
| **interfaceVersion** | **string?** |  | [optional]  |
| **locale** | **string?** |  | [optional]  |
| **data** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Redirect |  * Location -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="paystart"></a>
# **PayStart**
> PayStart200Response PayStart (PayStartRequest? payStartRequest = null)

Pay/Start

Starts the payment process. This endpoint will return data that you'll have to post as a form to the given endpoint. Post `redirectionVersion` and `redirectionData` to `redirectionUrl`. You'll end up on the payment page. Look at the request samples for a javascript implementation.  _Set `parameter 576` with the return domain for the payment provider._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class PayStartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayApi(config);
            var payStartRequest = new PayStartRequest?(); // PayStartRequest? |  (optional) 

            try
            {
                // Pay/Start
                PayStart200Response result = apiInstance.PayStart(payStartRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayApi.PayStart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PayStartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pay/Start
    ApiResponse<PayStart200Response> response = apiInstance.PayStartWithHttpInfo(payStartRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayApi.PayStartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payStartRequest** | [**PayStartRequest?**](PayStartRequest?.md) |  | [optional]  |

### Return type

[**PayStart200Response**](PayStart200Response.md)

### Authorization

[Orng](../README.md#Orng), [Tgr](../README.md#Tgr)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

