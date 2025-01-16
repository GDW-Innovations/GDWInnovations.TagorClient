# TagorClient.Api.CodeApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CodeGetDescription**](CodeApi.md#codegetdescription) | **POST** /Code/GetDescription | Code/GetDescription |
| [**CodeGetList**](CodeApi.md#codegetlist) | **POST** /Code/GetList | Code/GetList |

<a id="codegetdescription"></a>
# **CodeGetDescription**
> CodeGetDescription200Response CodeGetDescription (CodeGetDescriptionRequest? codeGetDescriptionRequest = null)

Code/GetDescription

Converts code ids. Pass `ttCodetabelIDs` records with either `Id` or `Code` fields filled in. This endpoint will update the other fields and return the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class CodeGetDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Pin
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Hash
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CodeApi(config);
            var codeGetDescriptionRequest = new CodeGetDescriptionRequest?(); // CodeGetDescriptionRequest? |  (optional) 

            try
            {
                // Code/GetDescription
                CodeGetDescription200Response result = apiInstance.CodeGetDescription(codeGetDescriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CodeApi.CodeGetDescription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CodeGetDescriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Code/GetDescription
    ApiResponse<CodeGetDescription200Response> response = apiInstance.CodeGetDescriptionWithHttpInfo(codeGetDescriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CodeApi.CodeGetDescriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetDescriptionRequest** | [**CodeGetDescriptionRequest?**](CodeGetDescriptionRequest?.md) |  | [optional]  |

### Return type

[**CodeGetDescription200Response**](CodeGetDescription200Response.md)

### Authorization

[Pin](../README.md#Pin), [Orng](../README.md#Orng), [Hash](../README.md#Hash), [Tgr](../README.md#Tgr)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="codegetlist"></a>
# **CodeGetList**
> CodeGetDescription200Response CodeGetList (CodeGetListRequest? codeGetListRequest = null)

Code/GetList

Returns a whole list of code ids. This endpoint can be used to populate dropdown lists in a front-end application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class CodeGetListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CodeApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // Code/GetList
                CodeGetDescription200Response result = apiInstance.CodeGetList(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CodeApi.CodeGetList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CodeGetListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Code/GetList
    ApiResponse<CodeGetDescription200Response> response = apiInstance.CodeGetListWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CodeApi.CodeGetListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

### Return type

[**CodeGetDescription200Response**](CodeGetDescription200Response.md)

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

