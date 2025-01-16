# TagorClient.Api.SolvencyReportApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SolvencyReportGet**](SolvencyReportApi.md#solvencyreportget) | **POST** /SolvencyReport/Get | SolvencyReport/Get |
| [**SolvencyReportGetList**](SolvencyReportApi.md#solvencyreportgetlist) | **POST** /SolvencyReport/GetList | SolvencyReport/GetList |
| [**SolvencyReportSave**](SolvencyReportApi.md#solvencyreportsave) | **POST** /SolvencyReport/Save | SolvencyReport/Save |

<a id="solvencyreportget"></a>
# **SolvencyReportGet**
> SolvencyReportGet200Response SolvencyReportGet (CodeGetListRequest? codeGetListRequest = null)

SolvencyReport/Get

This endpoint expects some values in ttWebContext. See example.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class SolvencyReportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SolvencyReportApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // SolvencyReport/Get
                SolvencyReportGet200Response result = apiInstance.SolvencyReportGet(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolvencyReportApi.SolvencyReportGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SolvencyReportGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SolvencyReport/Get
    ApiResponse<SolvencyReportGet200Response> response = apiInstance.SolvencyReportGetWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolvencyReportApi.SolvencyReportGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

### Return type

[**SolvencyReportGet200Response**](SolvencyReportGet200Response.md)

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

<a id="solvencyreportgetlist"></a>
# **SolvencyReportGetList**
> CodeGetDescription200Response SolvencyReportGetList (CodeGetListRequest? codeGetListRequest = null)

SolvencyReport/GetList

You can pass an additional `TQDOSSOORT_Id` to get file type specific config.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class SolvencyReportGetListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SolvencyReportApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // SolvencyReport/GetList
                CodeGetDescription200Response result = apiInstance.SolvencyReportGetList(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolvencyReportApi.SolvencyReportGetList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SolvencyReportGetListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SolvencyReport/GetList
    ApiResponse<CodeGetDescription200Response> response = apiInstance.SolvencyReportGetListWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolvencyReportApi.SolvencyReportGetListWithHttpInfo: " + e.Message);
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

<a id="solvencyreportsave"></a>
# **SolvencyReportSave**
> SolvencyReportSave200Response SolvencyReportSave (SolvencyReportSaveRequest? solvencyReportSaveRequest = null)

SolvencyReport/Save

This endpoint expects some values in ttWebContext. See example.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class SolvencyReportSaveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SolvencyReportApi(config);
            var solvencyReportSaveRequest = new SolvencyReportSaveRequest?(); // SolvencyReportSaveRequest? |  (optional) 

            try
            {
                // SolvencyReport/Save
                SolvencyReportSave200Response result = apiInstance.SolvencyReportSave(solvencyReportSaveRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SolvencyReportApi.SolvencyReportSave: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SolvencyReportSaveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SolvencyReport/Save
    ApiResponse<SolvencyReportSave200Response> response = apiInstance.SolvencyReportSaveWithHttpInfo(solvencyReportSaveRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SolvencyReportApi.SolvencyReportSaveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **solvencyReportSaveRequest** | [**SolvencyReportSaveRequest?**](SolvencyReportSaveRequest?.md) |  | [optional]  |

### Return type

[**SolvencyReportSave200Response**](SolvencyReportSave200Response.md)

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

