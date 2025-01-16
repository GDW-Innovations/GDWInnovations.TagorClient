# TagorClient.Api.DossierApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DossierAddAttachment**](DossierApi.md#dossieraddattachment) | **POST** /Dossier/AddAttachment | Dossier/AddAttachment |
| [**DossierCreateAgenda**](DossierApi.md#dossiercreateagenda) | **POST** /Dossier/CreateAgenda | Dossier/CreateAgenda |
| [**DossierCreateInfoLine**](DossierApi.md#dossiercreateinfoline) | **POST** /Dossier/CreateInfoLine | Dossier/CreateInfoLine |
| [**DossierCreateLine**](DossierApi.md#dossiercreateline) | **POST** /Dossier/CreateLine | Dossier/CreateLine |
| [**DossierGet**](DossierApi.md#dossierget) | **POST** /Dossier/Get | Dossier/Get |
| [**DossierGetAgenda**](DossierApi.md#dossiergetagenda) | **POST** /Dossier/GetAgenda | Dossier/GetAgenda |
| [**DossierGetAppearance**](DossierApi.md#dossiergetappearance) | **POST** /Dossier/GetAppearance | Dossier/GetAppearance |
| [**DossierGetBalances**](DossierApi.md#dossiergetbalances) | **POST** /Dossier/GetBalances | Dossier/GetBalances |
| [**DossierGetByDefendant**](DossierApi.md#dossiergetbydefendant) | **POST** /Dossier/GetByDefendant | Dossier/GetByDefendant |
| [**DossierGetCorrespondence**](DossierApi.md#dossiergetcorrespondence) | **POST** /Dossier/GetCorrespondence | Dossier/GetCorrespondence |
| [**DossierGetInfo**](DossierApi.md#dossiergetinfo) | **POST** /Dossier/GetInfo | Dossier/GetInfo |
| [**DossierGetLines**](DossierApi.md#dossiergetlines) | **POST** /Dossier/GetLines | Dossier/GetLines |
| [**DossierGetParties**](DossierApi.md#dossiergetparties) | **POST** /Dossier/GetParties | Dossier/GetParties |
| [**DossierGetPaymentPlans**](DossierApi.md#dossiergetpaymentplans) | **POST** /Dossier/GetPaymentPlans | Dossier/GetPaymentPlans |
| [**DossierGetSub**](DossierApi.md#dossiergetsub) | **POST** /Dossier/GetSub | Dossier/GetSub |
| [**DossierGetTitle**](DossierApi.md#dossiergettitle) | **POST** /Dossier/GetTitle | Dossier/GetTitle |
| [**DossierSearch**](DossierApi.md#dossiersearch) | **POST** /Dossier/Search | Dossier/Search |
| [**DossierStop**](DossierApi.md#dossierstop) | **POST** /Dossier/Stop | Dossier/Stop |

<a id="dossieraddattachment"></a>
# **DossierAddAttachment**
> DossierAddAttachment200Response DossierAddAttachment (DossierAddAttachmentRequest? dossierAddAttachmentRequest = null)

Dossier/AddAttachment

Add a document to a file. `ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierAddAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var dossierAddAttachmentRequest = new DossierAddAttachmentRequest?(); // DossierAddAttachmentRequest? |  (optional) 

            try
            {
                // Dossier/AddAttachment
                DossierAddAttachment200Response result = apiInstance.DossierAddAttachment(dossierAddAttachmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierAddAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierAddAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/AddAttachment
    ApiResponse<DossierAddAttachment200Response> response = apiInstance.DossierAddAttachmentWithHttpInfo(dossierAddAttachmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierAddAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierAddAttachmentRequest** | [**DossierAddAttachmentRequest?**](DossierAddAttachmentRequest?.md) |  | [optional]  |

### Return type

[**DossierAddAttachment200Response**](DossierAddAttachment200Response.md)

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

<a id="dossiercreateagenda"></a>
# **DossierCreateAgenda**
> DossierCreateAgenda200Response DossierCreateAgenda (DossierCreateAgendaRequest? dossierCreateAgendaRequest = null)

Dossier/CreateAgenda

Create an agenda record in a file. To update an existing record add the correct `TJOB_Id`. To create a new record, you don't need to add the `TJOB_Id`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierCreateAgendaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var dossierCreateAgendaRequest = new DossierCreateAgendaRequest?(); // DossierCreateAgendaRequest? |  (optional) 

            try
            {
                // Dossier/CreateAgenda
                DossierCreateAgenda200Response result = apiInstance.DossierCreateAgenda(dossierCreateAgendaRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierCreateAgenda: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierCreateAgendaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/CreateAgenda
    ApiResponse<DossierCreateAgenda200Response> response = apiInstance.DossierCreateAgendaWithHttpInfo(dossierCreateAgendaRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierCreateAgendaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierCreateAgendaRequest** | [**DossierCreateAgendaRequest?**](DossierCreateAgendaRequest?.md) |  | [optional]  |

### Return type

[**DossierCreateAgenda200Response**](DossierCreateAgenda200Response.md)

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

<a id="dossiercreateinfoline"></a>
# **DossierCreateInfoLine**
> DossierCreateInfoLine200Response DossierCreateInfoLine (DossierCreateInfoLineRequest? dossierCreateInfoLineRequest = null)

Dossier/CreateInfoLine

Create an info record in a file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierCreateInfoLineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var dossierCreateInfoLineRequest = new DossierCreateInfoLineRequest?(); // DossierCreateInfoLineRequest? |  (optional) 

            try
            {
                // Dossier/CreateInfoLine
                DossierCreateInfoLine200Response result = apiInstance.DossierCreateInfoLine(dossierCreateInfoLineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierCreateInfoLine: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierCreateInfoLineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/CreateInfoLine
    ApiResponse<DossierCreateInfoLine200Response> response = apiInstance.DossierCreateInfoLineWithHttpInfo(dossierCreateInfoLineRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierCreateInfoLineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierCreateInfoLineRequest** | [**DossierCreateInfoLineRequest?**](DossierCreateInfoLineRequest?.md) |  | [optional]  |

### Return type

[**DossierCreateInfoLine200Response**](DossierCreateInfoLine200Response.md)

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

<a id="dossiercreateline"></a>
# **DossierCreateLine**
> DossierCreateLine200Response DossierCreateLine (DossierCreateLineRequest? dossierCreateLineRequest = null)

Dossier/CreateLine

Add a transaction to a file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierCreateLineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var dossierCreateLineRequest = new DossierCreateLineRequest?(); // DossierCreateLineRequest? |  (optional) 

            try
            {
                // Dossier/CreateLine
                DossierCreateLine200Response result = apiInstance.DossierCreateLine(dossierCreateLineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierCreateLine: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierCreateLineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/CreateLine
    ApiResponse<DossierCreateLine200Response> response = apiInstance.DossierCreateLineWithHttpInfo(dossierCreateLineRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierCreateLineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierCreateLineRequest** | [**DossierCreateLineRequest?**](DossierCreateLineRequest?.md) |  | [optional]  |

### Return type

[**DossierCreateLine200Response**](DossierCreateLine200Response.md)

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

<a id="dossierget"></a>
# **DossierGet**
> DossierGet200Response DossierGet (DocumentGetRequest? documentGetRequest = null)

Dossier/Get

Get a single file. `ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/Get
                DossierGet200Response result = apiInstance.DossierGet(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/Get
    ApiResponse<DossierGet200Response> response = apiInstance.DossierGetWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DossierGet200Response**](DossierGet200Response.md)

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

<a id="dossiergetagenda"></a>
# **DossierGetAgenda**
> DossierGetAgenda200Response DossierGetAgenda (DocumentGetRequest? documentGetRequest = null)

Dossier/GetAgenda

Get all calendar items for a single file. `ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetAgendaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/GetAgenda
                DossierGetAgenda200Response result = apiInstance.DossierGetAgenda(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetAgenda: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetAgendaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetAgenda
    ApiResponse<DossierGetAgenda200Response> response = apiInstance.DossierGetAgendaWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetAgendaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DossierGetAgenda200Response**](DossierGetAgenda200Response.md)

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

<a id="dossiergetappearance"></a>
# **DossierGetAppearance**
> DossierGetAppearance200Response DossierGetAppearance (DocumentGetRequest? documentGetRequest = null)

Dossier/GetAppearance

`ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetAppearanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/GetAppearance
                DossierGetAppearance200Response result = apiInstance.DossierGetAppearance(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetAppearance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetAppearanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetAppearance
    ApiResponse<DossierGetAppearance200Response> response = apiInstance.DossierGetAppearanceWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetAppearanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DossierGetAppearance200Response**](DossierGetAppearance200Response.md)

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

<a id="dossiergetbalances"></a>
# **DossierGetBalances**
> DossierGetBalances200Response DossierGetBalances (DocumentGetRequest? documentGetRequest = null)

Dossier/GetBalances

Get all balances of a file i.e. returns a summarized version of [`Dossier/GetLines`](#operation/DossierGetLines). `ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/GetBalances
                DossierGetBalances200Response result = apiInstance.DossierGetBalances(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetBalances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetBalancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetBalances
    ApiResponse<DossierGetBalances200Response> response = apiInstance.DossierGetBalancesWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetBalancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DossierGetBalances200Response**](DossierGetBalances200Response.md)

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

<a id="dossiergetbydefendant"></a>
# **DossierGetByDefendant**
> DossierGetByDefendant200Response DossierGetByDefendant (DossierGetByDefendantRequest? dossierGetByDefendantRequest = null)

Dossier/GetByDefendant

`ttWebContext` requires a `TPAR_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetByDefendantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var dossierGetByDefendantRequest = new DossierGetByDefendantRequest?(); // DossierGetByDefendantRequest? |  (optional) 

            try
            {
                // Dossier/GetByDefendant
                DossierGetByDefendant200Response result = apiInstance.DossierGetByDefendant(dossierGetByDefendantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetByDefendant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetByDefendantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetByDefendant
    ApiResponse<DossierGetByDefendant200Response> response = apiInstance.DossierGetByDefendantWithHttpInfo(dossierGetByDefendantRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetByDefendantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierGetByDefendantRequest** | [**DossierGetByDefendantRequest?**](DossierGetByDefendantRequest?.md) |  | [optional]  |

### Return type

[**DossierGetByDefendant200Response**](DossierGetByDefendant200Response.md)

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

<a id="dossiergetcorrespondence"></a>
# **DossierGetCorrespondence**
> DossierGetCorrespondence200Response DossierGetCorrespondence (DocumentGetRequest? documentGetRequest = null)

Dossier/GetCorrespondence

Returns all correspondence on a file. `ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetCorrespondenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/GetCorrespondence
                DossierGetCorrespondence200Response result = apiInstance.DossierGetCorrespondence(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetCorrespondence: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetCorrespondenceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetCorrespondence
    ApiResponse<DossierGetCorrespondence200Response> response = apiInstance.DossierGetCorrespondenceWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetCorrespondenceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DossierGetCorrespondence200Response**](DossierGetCorrespondence200Response.md)

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

<a id="dossiergetinfo"></a>
# **DossierGetInfo**
> DossierGetInfo200Response DossierGetInfo (DocumentGetRequest? documentGetRequest = null)

Dossier/GetInfo

Returns all info records on a file. `ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/GetInfo
                DossierGetInfo200Response result = apiInstance.DossierGetInfo(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetInfo
    ApiResponse<DossierGetInfo200Response> response = apiInstance.DossierGetInfoWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DossierGetInfo200Response**](DossierGetInfo200Response.md)

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

<a id="dossiergetlines"></a>
# **DossierGetLines**
> DossierGetLines200Response DossierGetLines (CodeGetListRequest? codeGetListRequest = null)

Dossier/GetLines

Returns all transaction records on a file. `ttWebContext` requires a `TDOS_Id` element. Other options are optional: - `is-defendant` (boolean): returns the overview from the defendants perspective. - `evolution-only` (boolean): only returns records the office marked as 'important in the evolution of the file'. - `unfinished-deeds` (boolean)   _To get files in the `evolution-only` view you have to mark `TQAARD` records as evolution._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // Dossier/GetLines
                DossierGetLines200Response result = apiInstance.DossierGetLines(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetLines
    ApiResponse<DossierGetLines200Response> response = apiInstance.DossierGetLinesWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

### Return type

[**DossierGetLines200Response**](DossierGetLines200Response.md)

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

<a id="dossiergetparties"></a>
# **DossierGetParties**
> ConfigInfo200Response DossierGetParties (DocumentGetRequest? documentGetRequest = null)

Dossier/GetParties

`ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetPartiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/GetParties
                ConfigInfo200Response result = apiInstance.DossierGetParties(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetParties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetPartiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetParties
    ApiResponse<ConfigInfo200Response> response = apiInstance.DossierGetPartiesWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetPartiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**ConfigInfo200Response**](ConfigInfo200Response.md)

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

<a id="dossiergetpaymentplans"></a>
# **DossierGetPaymentPlans**
> DossierGetPaymentPlans200Response DossierGetPaymentPlans (DocumentGetRequest? documentGetRequest = null)

Dossier/GetPaymentPlans

`ttWebContext` requires a `TDOS_Id` element. Other options are optional: - `active-only` (boolean): only return active payment plans.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetPaymentPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/GetPaymentPlans
                DossierGetPaymentPlans200Response result = apiInstance.DossierGetPaymentPlans(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetPaymentPlans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetPaymentPlansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetPaymentPlans
    ApiResponse<DossierGetPaymentPlans200Response> response = apiInstance.DossierGetPaymentPlansWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetPaymentPlansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DossierGetPaymentPlans200Response**](DossierGetPaymentPlans200Response.md)

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

<a id="dossiergetsub"></a>
# **DossierGetSub**
> DossierGetSub200Response DossierGetSub (DocumentGetRequest? documentGetRequest = null)

Dossier/GetSub

`ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetSubExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/GetSub
                DossierGetSub200Response result = apiInstance.DossierGetSub(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetSub: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetSubWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetSub
    ApiResponse<DossierGetSub200Response> response = apiInstance.DossierGetSubWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetSubWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DossierGetSub200Response**](DossierGetSub200Response.md)

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

<a id="dossiergettitle"></a>
# **DossierGetTitle**
> DossierGetTitle200Response DossierGetTitle (DocumentGetRequest? documentGetRequest = null)

Dossier/GetTitle

`ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierGetTitleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/GetTitle
                DossierGetTitle200Response result = apiInstance.DossierGetTitle(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierGetTitle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierGetTitleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/GetTitle
    ApiResponse<DossierGetTitle200Response> response = apiInstance.DossierGetTitleWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierGetTitleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DossierGetTitle200Response**](DossierGetTitle200Response.md)

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

<a id="dossiersearch"></a>
# **DossierSearch**
> DossierSearch200Response DossierSearch (DossierSearchRequest? dossierSearchRequest = null)

Dossier/Search

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var dossierSearchRequest = new DossierSearchRequest?(); // DossierSearchRequest? |  (optional) 

            try
            {
                // Dossier/Search
                DossierSearch200Response result = apiInstance.DossierSearch(dossierSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/Search
    ApiResponse<DossierSearch200Response> response = apiInstance.DossierSearchWithHttpInfo(dossierSearchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierSearchRequest** | [**DossierSearchRequest?**](DossierSearchRequest?.md) |  | [optional]  |

### Return type

[**DossierSearch200Response**](DossierSearch200Response.md)

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

<a id="dossierstop"></a>
# **DossierStop**
> DossierGet200Response DossierStop (DocumentGetRequest? documentGetRequest = null)

Dossier/Stop

`ttWebContext` requires a `TDOS_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class DossierStopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DossierApi(config);
            var documentGetRequest = new DocumentGetRequest?(); // DocumentGetRequest? |  (optional) 

            try
            {
                // Dossier/Stop
                DossierGet200Response result = apiInstance.DossierStop(documentGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DossierApi.DossierStop: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DossierStopWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dossier/Stop
    ApiResponse<DossierGet200Response> response = apiInstance.DossierStopWithHttpInfo(documentGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DossierApi.DossierStopWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentGetRequest** | [**DocumentGetRequest?**](DocumentGetRequest?.md) |  | [optional]  |

### Return type

[**DossierGet200Response**](DossierGet200Response.md)

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

