# TagorClient.Api.DocumentApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DocumentGenerate**](DocumentApi.md#documentgenerate) | **POST** /Document/Generate | Document/Generate |
| [**DocumentGet**](DocumentApi.md#documentget) | **POST** /Document/Get | Document/Get |
| [**DocumentGetFile**](DocumentApi.md#documentgetfile) | **POST** /Document/GetFile | Document/GetFile |
| [**DocumentGetMergefield**](DocumentApi.md#documentgetmergefield) | **POST** /Document/GetMergefield | Document/GetMergefield |

<a id="documentgenerate"></a>
# **DocumentGenerate**
> ConfigVersion200Response DocumentGenerate (CodeGetListRequest? codeGetListRequest = null)

Document/Generate

A list of all possible `TDOCM_Id` values can be retreived with [`User/GetPermissionsList`](#operation/UserGetPermissionsList).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DocumentGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DocumentApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // Document/Generate
                ConfigVersion200Response result = apiInstance.DocumentGenerate(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentGenerate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentGenerateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Document/Generate
    ApiResponse<ConfigVersion200Response> response = apiInstance.DocumentGenerateWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentApi.DocumentGenerateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

### Return type

[**ConfigVersion200Response**](ConfigVersion200Response.md)

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

<a id="documentget"></a>
# **DocumentGet**
> DocumentGet200Response DocumentGet (DocumentGetRequest? documentGetRequest = null)

Document/Get

Get all documents on a file. `ttWebContext` requires a `TDOS_Id` element. The `Inhoud` field will always be empty here.  _Some parameters can be used to configure this endpoint:_ - `Parameter 192`: _Only show PDF files._ - `Parameter 369`: _Blacklist some security codes._ - `Parameter 430`: _Allowed `TQDISGROEP`s. Empty for all. __

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DocumentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DocumentApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Document/Get
                DocumentGet200Response result = apiInstance.DocumentGet(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Document/Get
    ApiResponse<DocumentGet200Response> response = apiInstance.DocumentGetWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentApi.DocumentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DocumentGet200Response**](DocumentGet200Response.md)

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

<a id="documentgetfile"></a>
# **DocumentGetFile**
> DocumentGet200Response DocumentGetFile (DocumentGetFileRequest? documentGetFileRequest = null)

Document/GetFile

Get a single document on a file. `ttWebContext` requires a `TDOC_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DocumentGetFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DocumentApi(config);
            var documentGetFileRequest = new DocumentGetFileRequest?(); // DocumentGetFileRequest? |  (optional) 

            try
            {
                // Document/GetFile
                DocumentGet200Response result = apiInstance.DocumentGetFile(documentGetFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentGetFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentGetFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Document/GetFile
    ApiResponse<DocumentGet200Response> response = apiInstance.DocumentGetFileWithHttpInfo(documentGetFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentApi.DocumentGetFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetFileRequest** | [**DocumentGetFileRequest?**](DocumentGetFileRequest?.md) |  | [optional]  |

### Return type

[**DocumentGet200Response**](DocumentGet200Response.md)

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

<a id="documentgetmergefield"></a>
# **DocumentGetMergefield**
> DocumentGetMergefield200Response DocumentGetMergefield (DocumentGetMergefieldRequest? documentGetMergefieldRequest = null)

Document/GetMergefield

Get one of the available mergefields on a file. `ttWebContext` requires `TDOS_Id` and `Mergefield` elements. You can get a list of all available mergefields by calling the [`User/GetPermissionsList`](#operation/UserGetPermissionsList) endpoint and passing `WL_QRY_FIELD` as type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DocumentGetMergefieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DocumentApi(config);
            var documentGetMergefieldRequest = new DocumentGetMergefieldRequest?(); // DocumentGetMergefieldRequest? |  (optional) 

            try
            {
                // Document/GetMergefield
                DocumentGetMergefield200Response result = apiInstance.DocumentGetMergefield(documentGetMergefieldRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentGetMergefield: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentGetMergefieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Document/GetMergefield
    ApiResponse<DocumentGetMergefield200Response> response = apiInstance.DocumentGetMergefieldWithHttpInfo(documentGetMergefieldRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentApi.DocumentGetMergefieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetMergefieldRequest** | [**DocumentGetMergefieldRequest?**](DocumentGetMergefieldRequest?.md) |  | [optional]  |

### Return type

[**DocumentGetMergefield200Response**](DocumentGetMergefield200Response.md)

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

