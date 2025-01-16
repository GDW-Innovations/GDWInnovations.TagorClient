# TagorClient.Api.TagorServiceApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TagorServiceApprovePaymentPlan**](TagorServiceApi.md#tagorserviceapprovepaymentplan) | **POST** /TagorService/ApprovePaymentPlan | TagorService/ApprovePaymentPlan |
| [**TagorServiceClipToFile**](TagorServiceApi.md#tagorservicecliptofile) | **POST** /TagorService/ClipToFile | TagorService/ClipToFile |
| [**TagorServiceFileToHash**](TagorServiceApi.md#tagorservicefiletohash) | **POST** /TagorService/FileToHash | TagorService/FileToHash |
| [**TagorServiceGetDosInfo**](TagorServiceApi.md#tagorservicegetdosinfo) | **POST** /TagorService/GetDosInfo | TagorService/GetDosInfo |
| [**TagorServiceGetPaymentPlanCriteria**](TagorServiceApi.md#tagorservicegetpaymentplancriteria) | **POST** /TagorService/GetPaymentPlanCriteria | TagorService/GetPaymentPlanCriteria |
| [**TagorServiceGetSaldo**](TagorServiceApi.md#tagorservicegetsaldo) | **POST** /TagorService/GetSaldo | TagorService/GetSaldo |
| [**TagorServiceGetVoxtronReferentie**](TagorServiceApi.md#tagorservicegetvoxtronreferentie) | **POST** /TagorService/GetVoxtronReferentie | TagorService/GetVoxtronReferentie |
| [**TagorServiceGetVoxtronVerwByHuisNr**](TagorServiceApi.md#tagorservicegetvoxtronverwbyhuisnr) | **POST** /TagorService/GetVoxtronVerwByHuisNr | TagorService/GetVoxtronVerwByHuisNr |
| [**TagorServiceGetVoxtronVerwByPin**](TagorServiceApi.md#tagorservicegetvoxtronverwbypin) | **POST** /TagorService/GetVoxtronVerwByPin | TagorService/GetVoxtronVerwByPin |
| [**TagorServiceHashToFile**](TagorServiceApi.md#tagorservicehashtofile) | **POST** /TagorService/HashToFile | TagorService/HashToFile |
| [**TagorServiceKantoorOpen**](TagorServiceApi.md#tagorservicekantooropen) | **POST** /TagorService/KantoorOpen | TagorService/KantoorOpen |
| [**TagorServiceOnlinePaymentReceived**](TagorServiceApi.md#tagorserviceonlinepaymentreceived) | **POST** /TagorService/OnlinePaymentReceived | TagorService/OnlinePaymentReceived |
| [**TagorServicePaymentDetails**](TagorServiceApi.md#tagorservicepaymentdetails) | **POST** /TagorService/PaymentDetails | TagorService/PaymentDetails |
| [**TagorServicePaymentInfo**](TagorServiceApi.md#tagorservicepaymentinfo) | **POST** /TagorService/PaymentInfo | TagorService/PaymentInfo |
| [**TagorServicePinToFile**](TagorServiceApi.md#tagorservicepintofile) | **POST** /TagorService/PinToFile | TagorService/PinToFile |
| [**TagorServiceSavePaymentPlan**](TagorServiceApi.md#tagorservicesavepaymentplan) | **POST** /TagorService/SavePaymentPlan | TagorService/SavePaymentPlan |
| [**TagorServiceScanBarcode**](TagorServiceApi.md#tagorservicescanbarcode) | **POST** /TagorService/ScanBarcode | TagorService/ScanBarcode |
| [**TagorServiceSelfServiceAllowed**](TagorServiceApi.md#tagorserviceselfserviceallowed) | **POST** /TagorService/SelfServiceAllowed | TagorService/SelfServiceAllowed |
| [**TagorServiceSendMail**](TagorServiceApi.md#tagorservicesendmail) | **POST** /TagorService/SendMail | TagorService/SendMail |
| [**TagorServiceSendSms**](TagorServiceApi.md#tagorservicesendsms) | **POST** /TagorService/SendSms | TagorService/SendSms |
| [**TagorServiceSetUserDossier**](TagorServiceApi.md#tagorservicesetuserdossier) | **POST** /TagorService/SetUserDossier | TagorService/SetUserDossier |

<a id="tagorserviceapprovepaymentplan"></a>
# **TagorServiceApprovePaymentPlan**
> TagorServiceApprovePaymentPlan200Response TagorServiceApprovePaymentPlan (TagorServiceApprovePaymentPlanRequest? tagorServiceApprovePaymentPlanRequest = null)

TagorService/ApprovePaymentPlan

Approve the last paymentplan on a file. If the given `Telnr` is a belgian mobile number the confirmation will be send as a text to that number. If not a mail will be send to the defendant on the file.  _The formula with code `BEVAFBET` will be used as a template to send texts/mails. Be sure this record exists._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceApprovePaymentPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceApprovePaymentPlanRequest = new TagorServiceApprovePaymentPlanRequest?(); // TagorServiceApprovePaymentPlanRequest? |  (optional) 

            try
            {
                // TagorService/ApprovePaymentPlan
                TagorServiceApprovePaymentPlan200Response result = apiInstance.TagorServiceApprovePaymentPlan(tagorServiceApprovePaymentPlanRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceApprovePaymentPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceApprovePaymentPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/ApprovePaymentPlan
    ApiResponse<TagorServiceApprovePaymentPlan200Response> response = apiInstance.TagorServiceApprovePaymentPlanWithHttpInfo(tagorServiceApprovePaymentPlanRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceApprovePaymentPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceApprovePaymentPlanRequest** | [**TagorServiceApprovePaymentPlanRequest?**](TagorServiceApprovePaymentPlanRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceApprovePaymentPlan200Response**](TagorServiceApprovePaymentPlan200Response.md)

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

<a id="tagorservicecliptofile"></a>
# **TagorServiceClipToFile**
> TagorServiceClipToFile200Response TagorServiceClipToFile (TagorServiceClipToFileRequest? tagorServiceClipToFileRequest = null)

TagorService/ClipToFile

Search for a phone number. This endpoint will return only the first matching party and its corresponding files.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceClipToFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceClipToFileRequest = new TagorServiceClipToFileRequest?(); // TagorServiceClipToFileRequest? |  (optional) 

            try
            {
                // TagorService/ClipToFile
                TagorServiceClipToFile200Response result = apiInstance.TagorServiceClipToFile(tagorServiceClipToFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceClipToFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceClipToFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/ClipToFile
    ApiResponse<TagorServiceClipToFile200Response> response = apiInstance.TagorServiceClipToFileWithHttpInfo(tagorServiceClipToFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceClipToFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceClipToFileRequest** | [**TagorServiceClipToFileRequest?**](TagorServiceClipToFileRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceClipToFile200Response**](TagorServiceClipToFile200Response.md)

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

<a id="tagorservicefiletohash"></a>
# **TagorServiceFileToHash**
> ActionsSendMail200Response TagorServiceFileToHash (TagorServiceFileToHashRequest? tagorServiceFileToHashRequest = null)

TagorService/FileToHash

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceFileToHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceFileToHashRequest = new TagorServiceFileToHashRequest?(); // TagorServiceFileToHashRequest? |  (optional) 

            try
            {
                // TagorService/FileToHash
                ActionsSendMail200Response result = apiInstance.TagorServiceFileToHash(tagorServiceFileToHashRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceFileToHash: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceFileToHashWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/FileToHash
    ApiResponse<ActionsSendMail200Response> response = apiInstance.TagorServiceFileToHashWithHttpInfo(tagorServiceFileToHashRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceFileToHashWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceFileToHashRequest** | [**TagorServiceFileToHashRequest?**](TagorServiceFileToHashRequest?.md) |  | [optional]  |

### Return type

[**ActionsSendMail200Response**](ActionsSendMail200Response.md)

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

<a id="tagorservicegetdosinfo"></a>
# **TagorServiceGetDosInfo**
> TagorServiceGetDosInfo200Response TagorServiceGetDosInfo (TagorServiceGetDosInfoRequest? tagorServiceGetDosInfoRequest = null)

TagorService/GetDosInfo

Get info about a file.   _`DossiersoortId` will be mapped if a mapping with code `VOXTRON` is available. Otherwise the id will be prefixed with `DSO`. `DosbehId` depends on `parameter 259`. See the result below for possible values._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceGetDosInfoExample
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

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceGetDosInfoRequest = new TagorServiceGetDosInfoRequest?(); // TagorServiceGetDosInfoRequest? |  (optional) 

            try
            {
                // TagorService/GetDosInfo
                TagorServiceGetDosInfo200Response result = apiInstance.TagorServiceGetDosInfo(tagorServiceGetDosInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetDosInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceGetDosInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/GetDosInfo
    ApiResponse<TagorServiceGetDosInfo200Response> response = apiInstance.TagorServiceGetDosInfoWithHttpInfo(tagorServiceGetDosInfoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetDosInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceGetDosInfoRequest** | [**TagorServiceGetDosInfoRequest?**](TagorServiceGetDosInfoRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceGetDosInfo200Response**](TagorServiceGetDosInfo200Response.md)

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

<a id="tagorservicegetpaymentplancriteria"></a>
# **TagorServiceGetPaymentPlanCriteria**
> TagorServiceGetPaymentPlanCriteria200Response TagorServiceGetPaymentPlanCriteria (TagorServiceGetPaymentPlanCriteriaRequest? tagorServiceGetPaymentPlanCriteriaRequest = null)

TagorService/GetPaymentPlanCriteria

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceGetPaymentPlanCriteriaExample
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

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceGetPaymentPlanCriteriaRequest = new TagorServiceGetPaymentPlanCriteriaRequest?(); // TagorServiceGetPaymentPlanCriteriaRequest? |  (optional) 

            try
            {
                // TagorService/GetPaymentPlanCriteria
                TagorServiceGetPaymentPlanCriteria200Response result = apiInstance.TagorServiceGetPaymentPlanCriteria(tagorServiceGetPaymentPlanCriteriaRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetPaymentPlanCriteria: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceGetPaymentPlanCriteriaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/GetPaymentPlanCriteria
    ApiResponse<TagorServiceGetPaymentPlanCriteria200Response> response = apiInstance.TagorServiceGetPaymentPlanCriteriaWithHttpInfo(tagorServiceGetPaymentPlanCriteriaRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetPaymentPlanCriteriaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceGetPaymentPlanCriteriaRequest** | [**TagorServiceGetPaymentPlanCriteriaRequest?**](TagorServiceGetPaymentPlanCriteriaRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceGetPaymentPlanCriteria200Response**](TagorServiceGetPaymentPlanCriteria200Response.md)

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

<a id="tagorservicegetsaldo"></a>
# **TagorServiceGetSaldo**
> TagorServiceGetSaldo200Response TagorServiceGetSaldo (TagorServiceGetSaldoRequest? tagorServiceGetSaldoRequest = null)

TagorService/GetSaldo

Get the defendants balance on a file. This endpoint will create an info record (type `OPSV`) on the file indicating the balance was requested unless.   _The auto created info records can be disabled with `parameter 568`. This endpoint returns the balance with code `VRW` which is the defendants balance on the file._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceGetSaldoExample
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

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceGetSaldoRequest = new TagorServiceGetSaldoRequest?(); // TagorServiceGetSaldoRequest? |  (optional) 

            try
            {
                // TagorService/GetSaldo
                TagorServiceGetSaldo200Response result = apiInstance.TagorServiceGetSaldo(tagorServiceGetSaldoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetSaldo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceGetSaldoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/GetSaldo
    ApiResponse<TagorServiceGetSaldo200Response> response = apiInstance.TagorServiceGetSaldoWithHttpInfo(tagorServiceGetSaldoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetSaldoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceGetSaldoRequest** | [**TagorServiceGetSaldoRequest?**](TagorServiceGetSaldoRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceGetSaldo200Response**](TagorServiceGetSaldo200Response.md)

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

<a id="tagorservicegetvoxtronreferentie"></a>
# **TagorServiceGetVoxtronReferentie**
> TagorServiceGetVoxtronReferentie200Response TagorServiceGetVoxtronReferentie (TagorServiceGetVoxtronReferentieRequest? tagorServiceGetVoxtronReferentieRequest = null)

TagorService/GetVoxtronReferentie

`DossiersoortId` and `DosStatus` will be mapped if a mapping with code `VOXTRON` is available. Otherwise the id will be prefixed with `DSO`.`Parameter 303` effects the way the `Referentie` field is used to search for a file. `DosbehId` depends on `parameter 259`. See the result below for possible values. `Parameter 233` decides whether the file status or file stage status is returned in the `DosStatus` field.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceGetVoxtronReferentieExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceGetVoxtronReferentieRequest = new TagorServiceGetVoxtronReferentieRequest?(); // TagorServiceGetVoxtronReferentieRequest? |  (optional) 

            try
            {
                // TagorService/GetVoxtronReferentie
                TagorServiceGetVoxtronReferentie200Response result = apiInstance.TagorServiceGetVoxtronReferentie(tagorServiceGetVoxtronReferentieRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetVoxtronReferentie: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceGetVoxtronReferentieWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/GetVoxtronReferentie
    ApiResponse<TagorServiceGetVoxtronReferentie200Response> response = apiInstance.TagorServiceGetVoxtronReferentieWithHttpInfo(tagorServiceGetVoxtronReferentieRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetVoxtronReferentieWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceGetVoxtronReferentieRequest** | [**TagorServiceGetVoxtronReferentieRequest?**](TagorServiceGetVoxtronReferentieRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceGetVoxtronReferentie200Response**](TagorServiceGetVoxtronReferentie200Response.md)

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

<a id="tagorservicegetvoxtronverwbyhuisnr"></a>
# **TagorServiceGetVoxtronVerwByHuisNr**
> TagorServiceGetVoxtronVerwByHuisNr200Response TagorServiceGetVoxtronVerwByHuisNr (TagorServiceGetVoxtronVerwByHuisNrRequest? tagorServiceGetVoxtronVerwByHuisNrRequest = null)

TagorService/GetVoxtronVerwByHuisNr

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceGetVoxtronVerwByHuisNrExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceGetVoxtronVerwByHuisNrRequest = new TagorServiceGetVoxtronVerwByHuisNrRequest?(); // TagorServiceGetVoxtronVerwByHuisNrRequest? |  (optional) 

            try
            {
                // TagorService/GetVoxtronVerwByHuisNr
                TagorServiceGetVoxtronVerwByHuisNr200Response result = apiInstance.TagorServiceGetVoxtronVerwByHuisNr(tagorServiceGetVoxtronVerwByHuisNrRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetVoxtronVerwByHuisNr: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceGetVoxtronVerwByHuisNrWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/GetVoxtronVerwByHuisNr
    ApiResponse<TagorServiceGetVoxtronVerwByHuisNr200Response> response = apiInstance.TagorServiceGetVoxtronVerwByHuisNrWithHttpInfo(tagorServiceGetVoxtronVerwByHuisNrRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetVoxtronVerwByHuisNrWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceGetVoxtronVerwByHuisNrRequest** | [**TagorServiceGetVoxtronVerwByHuisNrRequest?**](TagorServiceGetVoxtronVerwByHuisNrRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceGetVoxtronVerwByHuisNr200Response**](TagorServiceGetVoxtronVerwByHuisNr200Response.md)

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

<a id="tagorservicegetvoxtronverwbypin"></a>
# **TagorServiceGetVoxtronVerwByPin**
> ActionsSendMail200Response TagorServiceGetVoxtronVerwByPin (TagorServiceGetVoxtronVerwByPinRequest? tagorServiceGetVoxtronVerwByPinRequest = null)

TagorService/GetVoxtronVerwByPin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceGetVoxtronVerwByPinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceGetVoxtronVerwByPinRequest = new TagorServiceGetVoxtronVerwByPinRequest?(); // TagorServiceGetVoxtronVerwByPinRequest? |  (optional) 

            try
            {
                // TagorService/GetVoxtronVerwByPin
                ActionsSendMail200Response result = apiInstance.TagorServiceGetVoxtronVerwByPin(tagorServiceGetVoxtronVerwByPinRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetVoxtronVerwByPin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceGetVoxtronVerwByPinWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/GetVoxtronVerwByPin
    ApiResponse<ActionsSendMail200Response> response = apiInstance.TagorServiceGetVoxtronVerwByPinWithHttpInfo(tagorServiceGetVoxtronVerwByPinRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceGetVoxtronVerwByPinWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceGetVoxtronVerwByPinRequest** | [**TagorServiceGetVoxtronVerwByPinRequest?**](TagorServiceGetVoxtronVerwByPinRequest?.md) |  | [optional]  |

### Return type

[**ActionsSendMail200Response**](ActionsSendMail200Response.md)

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

<a id="tagorservicehashtofile"></a>
# **TagorServiceHashToFile**
> TagorServiceHashToFile200Response TagorServiceHashToFile (TagorServiceHashToFileRequest? tagorServiceHashToFileRequest = null)

TagorService/HashToFile

Get the corresponding file for a file-hash.   _The tokens validity period is configurable in `parameter 502`_

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceHashToFileExample
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

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceHashToFileRequest = new TagorServiceHashToFileRequest?(); // TagorServiceHashToFileRequest? |  (optional) 

            try
            {
                // TagorService/HashToFile
                TagorServiceHashToFile200Response result = apiInstance.TagorServiceHashToFile(tagorServiceHashToFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceHashToFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceHashToFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/HashToFile
    ApiResponse<TagorServiceHashToFile200Response> response = apiInstance.TagorServiceHashToFileWithHttpInfo(tagorServiceHashToFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceHashToFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceHashToFileRequest** | [**TagorServiceHashToFileRequest?**](TagorServiceHashToFileRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceHashToFile200Response**](TagorServiceHashToFile200Response.md)

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

<a id="tagorservicekantooropen"></a>
# **TagorServiceKantoorOpen**
> TagorServiceKantoorOpen200Response TagorServiceKantoorOpen (TagorServiceKantoorOpenRequest? tagorServiceKantoorOpenRequest = null)

TagorService/KantoorOpen

Checks if an employe is available based on file type.   _Opening hours can be entered via the configuration menu in Tagor._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceKantoorOpenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceKantoorOpenRequest = new TagorServiceKantoorOpenRequest?(); // TagorServiceKantoorOpenRequest? |  (optional) 

            try
            {
                // TagorService/KantoorOpen
                TagorServiceKantoorOpen200Response result = apiInstance.TagorServiceKantoorOpen(tagorServiceKantoorOpenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceKantoorOpen: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceKantoorOpenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/KantoorOpen
    ApiResponse<TagorServiceKantoorOpen200Response> response = apiInstance.TagorServiceKantoorOpenWithHttpInfo(tagorServiceKantoorOpenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceKantoorOpenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceKantoorOpenRequest** | [**TagorServiceKantoorOpenRequest?**](TagorServiceKantoorOpenRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceKantoorOpen200Response**](TagorServiceKantoorOpen200Response.md)

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

<a id="tagorserviceonlinepaymentreceived"></a>
# **TagorServiceOnlinePaymentReceived**
> ActionsSendMail200Response TagorServiceOnlinePaymentReceived (TagorServiceOnlinePaymentReceivedRequest? tagorServiceOnlinePaymentReceivedRequest = null)

TagorService/OnlinePaymentReceived

Creates an informative payment record on a file.   _The line's nature has to be configured in Tagor's office managment tool._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceOnlinePaymentReceivedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceOnlinePaymentReceivedRequest = new TagorServiceOnlinePaymentReceivedRequest?(); // TagorServiceOnlinePaymentReceivedRequest? |  (optional) 

            try
            {
                // TagorService/OnlinePaymentReceived
                ActionsSendMail200Response result = apiInstance.TagorServiceOnlinePaymentReceived(tagorServiceOnlinePaymentReceivedRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceOnlinePaymentReceived: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceOnlinePaymentReceivedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/OnlinePaymentReceived
    ApiResponse<ActionsSendMail200Response> response = apiInstance.TagorServiceOnlinePaymentReceivedWithHttpInfo(tagorServiceOnlinePaymentReceivedRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceOnlinePaymentReceivedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceOnlinePaymentReceivedRequest** | [**TagorServiceOnlinePaymentReceivedRequest?**](TagorServiceOnlinePaymentReceivedRequest?.md) |  | [optional]  |

### Return type

[**ActionsSendMail200Response**](ActionsSendMail200Response.md)

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

<a id="tagorservicepaymentdetails"></a>
# **TagorServicePaymentDetails**
> TagorServicePaymentDetails200Response TagorServicePaymentDetails ()

TagorService/PaymentDetails

Endpoint to get a detailed overview of the file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServicePaymentDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Pin
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Hash
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);

            try
            {
                // TagorService/PaymentDetails
                TagorServicePaymentDetails200Response result = apiInstance.TagorServicePaymentDetails();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServicePaymentDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServicePaymentDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/PaymentDetails
    ApiResponse<TagorServicePaymentDetails200Response> response = apiInstance.TagorServicePaymentDetailsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServicePaymentDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TagorServicePaymentDetails200Response**](TagorServicePaymentDetails200Response.md)

### Authorization

[Pin](../README.md#Pin), [Hash](../README.md#Hash)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tagorservicepaymentinfo"></a>
# **TagorServicePaymentInfo**
> TagorServicePaymentInfo200Response TagorServicePaymentInfo (TagorServicePaymentInfoRequest? tagorServicePaymentInfoRequest = null)

TagorService/PaymentInfo

Get info about ongoing payment plans on a file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServicePaymentInfoExample
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

            var apiInstance = new TagorServiceApi(config);
            var tagorServicePaymentInfoRequest = new TagorServicePaymentInfoRequest?(); // TagorServicePaymentInfoRequest? |  (optional) 

            try
            {
                // TagorService/PaymentInfo
                TagorServicePaymentInfo200Response result = apiInstance.TagorServicePaymentInfo(tagorServicePaymentInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServicePaymentInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServicePaymentInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/PaymentInfo
    ApiResponse<TagorServicePaymentInfo200Response> response = apiInstance.TagorServicePaymentInfoWithHttpInfo(tagorServicePaymentInfoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServicePaymentInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServicePaymentInfoRequest** | [**TagorServicePaymentInfoRequest?**](TagorServicePaymentInfoRequest?.md) |  | [optional]  |

### Return type

[**TagorServicePaymentInfo200Response**](TagorServicePaymentInfo200Response.md)

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

<a id="tagorservicepintofile"></a>
# **TagorServicePinToFile**
> TagorServicePinToFile200Response TagorServicePinToFile (TagorServicePinToFileRequest? tagorServicePinToFileRequest = null)

TagorService/PinToFile

Get the file id from a filename/pin combination. The value used in combination with the pin doesn't have to be a file name. This is configurable in Tagor.   _The value used in combination with the pincode is set in `parameter 590`. Pincodes are generated with mergefield `M_0077`._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServicePinToFileExample
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

            var apiInstance = new TagorServiceApi(config);
            var tagorServicePinToFileRequest = new TagorServicePinToFileRequest?(); // TagorServicePinToFileRequest? |  (optional) 

            try
            {
                // TagorService/PinToFile
                TagorServicePinToFile200Response result = apiInstance.TagorServicePinToFile(tagorServicePinToFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServicePinToFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServicePinToFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/PinToFile
    ApiResponse<TagorServicePinToFile200Response> response = apiInstance.TagorServicePinToFileWithHttpInfo(tagorServicePinToFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServicePinToFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServicePinToFileRequest** | [**TagorServicePinToFileRequest?**](TagorServicePinToFileRequest?.md) |  | [optional]  |

### Return type

[**TagorServicePinToFile200Response**](TagorServicePinToFile200Response.md)

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

<a id="tagorservicesavepaymentplan"></a>
# **TagorServiceSavePaymentPlan**
> TagorServiceSavePaymentPlan200Response TagorServiceSavePaymentPlan (TagorServiceSavePaymentPlanRequest? tagorServiceSavePaymentPlanRequest = null)

TagorService/SavePaymentPlan

Add a payment plan to a file. This will always create a new payment plan and put all existing payment plans inactive. The input data is validated. Periodes has to be less than configured on the file type. An info records will be generated to indicate a new payment plan was requested.   _Payment plans can be auto accepted with `parameter 358`. The auto created info records can be disabled with `parameter 568. The default date can be configured in the file type config and in the office managment. `_

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceSavePaymentPlanExample
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

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceSavePaymentPlanRequest = new TagorServiceSavePaymentPlanRequest?(); // TagorServiceSavePaymentPlanRequest? |  (optional) 

            try
            {
                // TagorService/SavePaymentPlan
                TagorServiceSavePaymentPlan200Response result = apiInstance.TagorServiceSavePaymentPlan(tagorServiceSavePaymentPlanRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceSavePaymentPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceSavePaymentPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/SavePaymentPlan
    ApiResponse<TagorServiceSavePaymentPlan200Response> response = apiInstance.TagorServiceSavePaymentPlanWithHttpInfo(tagorServiceSavePaymentPlanRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceSavePaymentPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceSavePaymentPlanRequest** | [**TagorServiceSavePaymentPlanRequest?**](TagorServiceSavePaymentPlanRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceSavePaymentPlan200Response**](TagorServiceSavePaymentPlan200Response.md)

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

<a id="tagorservicescanbarcode"></a>
# **TagorServiceScanBarcode**
> TagorServiceScanBarcode200Response TagorServiceScanBarcode (TagorServiceScanBarcodeRequest? tagorServiceScanBarcodeRequest = null)

TagorService/ScanBarcode

Get the file/financial line connected to a barcode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceScanBarcodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Pin
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Hash
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceScanBarcodeRequest = new TagorServiceScanBarcodeRequest?(); // TagorServiceScanBarcodeRequest? |  (optional) 

            try
            {
                // TagorService/ScanBarcode
                TagorServiceScanBarcode200Response result = apiInstance.TagorServiceScanBarcode(tagorServiceScanBarcodeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceScanBarcode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceScanBarcodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/ScanBarcode
    ApiResponse<TagorServiceScanBarcode200Response> response = apiInstance.TagorServiceScanBarcodeWithHttpInfo(tagorServiceScanBarcodeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceScanBarcodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceScanBarcodeRequest** | [**TagorServiceScanBarcodeRequest?**](TagorServiceScanBarcodeRequest?.md) |  | [optional]  |

### Return type

[**TagorServiceScanBarcode200Response**](TagorServiceScanBarcode200Response.md)

### Authorization

[Pin](../README.md#Pin), [Hash](../README.md#Hash)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tagorserviceselfserviceallowed"></a>
# **TagorServiceSelfServiceAllowed**
> ActionsSendMail200Response TagorServiceSelfServiceAllowed (TagorServiceSelfServiceAllowedRequest? tagorServiceSelfServiceAllowedRequest = null)

TagorService/SelfServiceAllowed

Checks whether a user is allowed to request his/her file.   _Configuration should be done in Tagor's office management tool._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceSelfServiceAllowedExample
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

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceSelfServiceAllowedRequest = new TagorServiceSelfServiceAllowedRequest?(); // TagorServiceSelfServiceAllowedRequest? |  (optional) 

            try
            {
                // TagorService/SelfServiceAllowed
                ActionsSendMail200Response result = apiInstance.TagorServiceSelfServiceAllowed(tagorServiceSelfServiceAllowedRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceSelfServiceAllowed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceSelfServiceAllowedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/SelfServiceAllowed
    ApiResponse<ActionsSendMail200Response> response = apiInstance.TagorServiceSelfServiceAllowedWithHttpInfo(tagorServiceSelfServiceAllowedRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceSelfServiceAllowedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceSelfServiceAllowedRequest** | [**TagorServiceSelfServiceAllowedRequest?**](TagorServiceSelfServiceAllowedRequest?.md) |  | [optional]  |

### Return type

[**ActionsSendMail200Response**](ActionsSendMail200Response.md)

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

<a id="tagorservicesendmail"></a>
# **TagorServiceSendMail**
> ActionsSendMail200Response TagorServiceSendMail (TagorServiceSendMailRequest? tagorServiceSendMailRequest = null)

TagorService/SendMail

Deprecated in favor of [`Actions/SendMail`](#operation/sendMail). **Will be removed in 1.08.3000B0**.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceSendMailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceSendMailRequest = new TagorServiceSendMailRequest?(); // TagorServiceSendMailRequest? |  (optional) 

            try
            {
                // TagorService/SendMail
                ActionsSendMail200Response result = apiInstance.TagorServiceSendMail(tagorServiceSendMailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceSendMail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceSendMailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/SendMail
    ApiResponse<ActionsSendMail200Response> response = apiInstance.TagorServiceSendMailWithHttpInfo(tagorServiceSendMailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceSendMailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceSendMailRequest** | [**TagorServiceSendMailRequest?**](TagorServiceSendMailRequest?.md) |  | [optional]  |

### Return type

[**ActionsSendMail200Response**](ActionsSendMail200Response.md)

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

<a id="tagorservicesendsms"></a>
# **TagorServiceSendSms**
> ActionsSendMail200Response TagorServiceSendSms (TagorServiceSendSmsRequest? tagorServiceSendSmsRequest = null)

TagorService/SendSms

Deprecated in favor of [`Actions/SendSms`](#operation/sendSms). **Will be removed in 1.08.3000B0**.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceSendSmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceSendSmsRequest = new TagorServiceSendSmsRequest?(); // TagorServiceSendSmsRequest? |  (optional) 

            try
            {
                // TagorService/SendSms
                ActionsSendMail200Response result = apiInstance.TagorServiceSendSms(tagorServiceSendSmsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceSendSms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceSendSmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/SendSms
    ApiResponse<ActionsSendMail200Response> response = apiInstance.TagorServiceSendSmsWithHttpInfo(tagorServiceSendSmsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceSendSmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceSendSmsRequest** | [**TagorServiceSendSmsRequest?**](TagorServiceSendSmsRequest?.md) |  | [optional]  |

### Return type

[**ActionsSendMail200Response**](ActionsSendMail200Response.md)

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

<a id="tagorservicesetuserdossier"></a>
# **TagorServiceSetUserDossier**
> ActionsSendMail200Response TagorServiceSetUserDossier (TagorServiceSetUserDossierRequest? tagorServiceSetUserDossierRequest = null)

TagorService/SetUserDossier

Adds shortcut to a specific file for a specific user in Tagor.   _Default info type can be changed in the `CURCALL` mapping._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class TagorServiceSetUserDossierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TagorServiceApi(config);
            var tagorServiceSetUserDossierRequest = new TagorServiceSetUserDossierRequest?(); // TagorServiceSetUserDossierRequest? |  (optional) 

            try
            {
                // TagorService/SetUserDossier
                ActionsSendMail200Response result = apiInstance.TagorServiceSetUserDossier(tagorServiceSetUserDossierRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagorServiceApi.TagorServiceSetUserDossier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagorServiceSetUserDossierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TagorService/SetUserDossier
    ApiResponse<ActionsSendMail200Response> response = apiInstance.TagorServiceSetUserDossierWithHttpInfo(tagorServiceSetUserDossierRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagorServiceApi.TagorServiceSetUserDossierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagorServiceSetUserDossierRequest** | [**TagorServiceSetUserDossierRequest?**](TagorServiceSetUserDossierRequest?.md) |  | [optional]  |

### Return type

[**ActionsSendMail200Response**](ActionsSendMail200Response.md)

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

