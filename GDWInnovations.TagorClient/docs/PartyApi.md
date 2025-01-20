# GDWInnovations.TagorClient.Api.PartyApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PartyAddContactDetail**](PartyApi.md#partyaddcontactdetail) | **POST** /Party/AddContactDetail | Party/AddContactDetail |
| [**PartyDeleteContactDetail**](PartyApi.md#partydeletecontactdetail) | **POST** /Party/DeleteContactDetail | Party/DeleteContactDetail |
| [**PartyGetAddresses**](PartyApi.md#partygetaddresses) | **POST** /Party/GetAddresses | Party/GetAddresses |
| [**PartyGetContactDetails**](PartyApi.md#partygetcontactdetails) | **POST** /Party/GetContactDetails | Party/GetContactDetails |
| [**PartySearch**](PartyApi.md#partysearch) | **POST** /Party/Search | Party/Search |

<a id="partyaddcontactdetail"></a>
# **PartyAddContactDetail**
> PartyAddContactDetail200Response PartyAddContactDetail (PartyAddContactDetailRequest? partyAddContactDetailRequest = null)

Party/AddContactDetail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class PartyAddContactDetailExample
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

            var apiInstance = new PartyApi(config);
            var partyAddContactDetailRequest = new PartyAddContactDetailRequest?(); // PartyAddContactDetailRequest? |  (optional) 

            try
            {
                // Party/AddContactDetail
                PartyAddContactDetail200Response result = apiInstance.PartyAddContactDetail(partyAddContactDetailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartyApi.PartyAddContactDetail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PartyAddContactDetailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Party/AddContactDetail
    ApiResponse<PartyAddContactDetail200Response> response = apiInstance.PartyAddContactDetailWithHttpInfo(partyAddContactDetailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartyApi.PartyAddContactDetailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **partyAddContactDetailRequest** | [**PartyAddContactDetailRequest?**](PartyAddContactDetailRequest?.md) |  | [optional]  |

### Return type

[**PartyAddContactDetail200Response**](PartyAddContactDetail200Response.md)

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

<a id="partydeletecontactdetail"></a>
# **PartyDeleteContactDetail**
> PartyDeleteContactDetail200Response PartyDeleteContactDetail (PartyDeleteContactDetailRequest? partyDeleteContactDetailRequest = null)

Party/DeleteContactDetail

Deletes a single contact record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class PartyDeleteContactDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PartyApi(config);
            var partyDeleteContactDetailRequest = new PartyDeleteContactDetailRequest?(); // PartyDeleteContactDetailRequest? |  (optional) 

            try
            {
                // Party/DeleteContactDetail
                PartyDeleteContactDetail200Response result = apiInstance.PartyDeleteContactDetail(partyDeleteContactDetailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartyApi.PartyDeleteContactDetail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PartyDeleteContactDetailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Party/DeleteContactDetail
    ApiResponse<PartyDeleteContactDetail200Response> response = apiInstance.PartyDeleteContactDetailWithHttpInfo(partyDeleteContactDetailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartyApi.PartyDeleteContactDetailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **partyDeleteContactDetailRequest** | [**PartyDeleteContactDetailRequest?**](PartyDeleteContactDetailRequest?.md) |  | [optional]  |

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

<a id="partygetaddresses"></a>
# **PartyGetAddresses**
> PartyGetAddresses200Response PartyGetAddresses (CodeGetListRequest? codeGetListRequest = null)

Party/GetAddresses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class PartyGetAddressesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PartyApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // Party/GetAddresses
                PartyGetAddresses200Response result = apiInstance.PartyGetAddresses(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartyApi.PartyGetAddresses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PartyGetAddressesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Party/GetAddresses
    ApiResponse<PartyGetAddresses200Response> response = apiInstance.PartyGetAddressesWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartyApi.PartyGetAddressesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

### Return type

[**PartyGetAddresses200Response**](PartyGetAddresses200Response.md)

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

<a id="partygetcontactdetails"></a>
# **PartyGetContactDetails**
> PartyGetContactDetails200Response PartyGetContactDetails (DossierGetByDefendantRequest? dossierGetByDefendantRequest = null)

Party/GetContactDetails

Get all contact details for a single party.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class PartyGetContactDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PartyApi(config);
            var dossierGetByDefendantRequest = new DossierGetByDefendantRequest?(); // DossierGetByDefendantRequest? |  (optional) 

            try
            {
                // Party/GetContactDetails
                PartyGetContactDetails200Response result = apiInstance.PartyGetContactDetails(dossierGetByDefendantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartyApi.PartyGetContactDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PartyGetContactDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Party/GetContactDetails
    ApiResponse<PartyGetContactDetails200Response> response = apiInstance.PartyGetContactDetailsWithHttpInfo(dossierGetByDefendantRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartyApi.PartyGetContactDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierGetByDefendantRequest** | [**DossierGetByDefendantRequest?**](DossierGetByDefendantRequest?.md) |  | [optional]  |

### Return type

[**PartyGetContactDetails200Response**](PartyGetContactDetails200Response.md)

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

<a id="partysearch"></a>
# **PartySearch**
> PartySearch200Response PartySearch (DossierSearchRequest? dossierSearchRequest = null)

Party/Search

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class PartySearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PartyApi(config);
            var dossierSearchRequest = new DossierSearchRequest?(); // DossierSearchRequest? |  (optional) 

            try
            {
                // Party/Search
                PartySearch200Response result = apiInstance.PartySearch(dossierSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartyApi.PartySearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PartySearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Party/Search
    ApiResponse<PartySearch200Response> response = apiInstance.PartySearchWithHttpInfo(dossierSearchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartyApi.PartySearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierSearchRequest** | [**DossierSearchRequest?**](DossierSearchRequest?.md) |  | [optional]  |

### Return type

[**PartySearch200Response**](PartySearch200Response.md)

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

