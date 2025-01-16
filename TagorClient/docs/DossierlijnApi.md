# TagorClient.Api.DossierlijnApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DossierlijnCreateInfoLine**](DossierlijnApi.md#dossierlijncreateinfoline) | **POST** /Dossierlijn/CreateInfoLine | Dossierlijn/CreateInfoLine |
| [**DossierlijnDeleteInfoLine**](DossierlijnApi.md#dossierlijndeleteinfoline) | **POST** /Dossierlijn/DeleteInfoLine | Dossierlijn/DeleteInfoLine |
| [**DossierlijnGetInfo**](DossierlijnApi.md#dossierlijngetinfo) | **POST** /Dossierlijn/GetInfo | Dossierlijn/GetInfo |

<a id="dossierlijncreateinfoline"></a>
# **DossierlijnCreateInfoLine**
> DossierlijnCreateInfoLine200Response DossierlijnCreateInfoLine (DossierlijnCreateInfoLineRequest? dossierlijnCreateInfoLineRequest = null)

Dossierlijn/CreateInfoLine

Create an info record on a financial record

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierlijnCreateInfoLineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierlijnApi(config);
            var dossierlijnCreateInfoLineRequest = new DossierlijnCreateInfoLineRequest?(); // DossierlijnCreateInfoLineRequest? |  (optional) 

            try
            {
                // Dossierlijn/CreateInfoLine
                DossierlijnCreateInfoLine200Response result = apiInstance.DossierlijnCreateInfoLine(dossierlijnCreateInfoLineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierlijnApi.DossierlijnCreateInfoLine: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierlijnCreateInfoLineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossierlijn/CreateInfoLine
    ApiResponse<DossierlijnCreateInfoLine200Response> response = apiInstance.DossierlijnCreateInfoLineWithHttpInfo(dossierlijnCreateInfoLineRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierlijnApi.DossierlijnCreateInfoLineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierlijnCreateInfoLineRequest** | [**DossierlijnCreateInfoLineRequest?**](DossierlijnCreateInfoLineRequest?.md) |  | [optional]  |

### Return type

[**DossierlijnCreateInfoLine200Response**](DossierlijnCreateInfoLine200Response.md)

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

<a id="dossierlijndeleteinfoline"></a>
# **DossierlijnDeleteInfoLine**
> PartyDeleteContactDetail200Response DossierlijnDeleteInfoLine (DossierlijnDeleteInfoLineRequest? dossierlijnDeleteInfoLineRequest = null)

Dossierlijn/DeleteInfoLine

Deletes a single info record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierlijnDeleteInfoLineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierlijnApi(config);
            var dossierlijnDeleteInfoLineRequest = new DossierlijnDeleteInfoLineRequest?(); // DossierlijnDeleteInfoLineRequest? |  (optional) 

            try
            {
                // Dossierlijn/DeleteInfoLine
                PartyDeleteContactDetail200Response result = apiInstance.DossierlijnDeleteInfoLine(dossierlijnDeleteInfoLineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierlijnApi.DossierlijnDeleteInfoLine: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierlijnDeleteInfoLineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossierlijn/DeleteInfoLine
    ApiResponse<PartyDeleteContactDetail200Response> response = apiInstance.DossierlijnDeleteInfoLineWithHttpInfo(dossierlijnDeleteInfoLineRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierlijnApi.DossierlijnDeleteInfoLineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierlijnDeleteInfoLineRequest** | [**DossierlijnDeleteInfoLineRequest?**](DossierlijnDeleteInfoLineRequest?.md) |  | [optional]  |

### Return type

[**PartyDeleteContactDetail200Response**](PartyDeleteContactDetail200Response.md)

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

<a id="dossierlijngetinfo"></a>
# **DossierlijnGetInfo**
> DossierlijnGetInfo200Response DossierlijnGetInfo (DossierlijnGetInfoRequest? dossierlijnGetInfoRequest = null)

Dossierlijn/GetInfo

Returns all info records on a financial record. `ttWebContext` requires a `TDOSLIJN_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierlijnGetInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierlijnApi(config);
            var dossierlijnGetInfoRequest = new DossierlijnGetInfoRequest?(); // DossierlijnGetInfoRequest? |  (optional) 

            try
            {
                // Dossierlijn/GetInfo
                DossierlijnGetInfo200Response result = apiInstance.DossierlijnGetInfo(dossierlijnGetInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierlijnApi.DossierlijnGetInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierlijnGetInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossierlijn/GetInfo
    ApiResponse<DossierlijnGetInfo200Response> response = apiInstance.DossierlijnGetInfoWithHttpInfo(dossierlijnGetInfoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierlijnApi.DossierlijnGetInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierlijnGetInfoRequest** | [**DossierlijnGetInfoRequest?**](DossierlijnGetInfoRequest?.md) |  | [optional]  |

### Return type

[**DossierlijnGetInfo200Response**](DossierlijnGetInfo200Response.md)

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

