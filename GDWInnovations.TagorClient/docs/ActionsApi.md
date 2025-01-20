# GDWInnovations.TagorClient.Api.ActionsApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActionsSendMail**](ActionsApi.md#actionssendmail) | **POST** /Actions/SendMail | Actions/SendMail |
| [**ActionsSendSms**](ActionsApi.md#actionssendsms) | **POST** /Actions/SendSms | Actions/SendSms |

<a id="actionssendmail"></a>
# **ActionsSendMail**
> ActionsSendMail200Response ActionsSendMail (ActionsSendMailRequest? actionsSendMailRequest = null)

Actions/SendMail

Send a mail. This endpoint will send a mail to the party entered in `TPAR_Id` if no `TPAR_Id` is passed it will send an email to the address passed in `Emailadres`. If `TDOS_Id` is passed the mail is only send if the file exists. When both `TDOS_Id` and `TPAR_Id` are passed, the party has to be a party connected to the file for the check to pass.   _`Parameter 569` has to contain the 117 connection string. In the office management screen a mailserver and mail template has to be configured. Logging about connection with the SMTP server can be found on c:\\temp\\YYYY\\MM\\DD\\socketmail.log on the 117 server._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class ActionsSendMailExample
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

            var apiInstance = new ActionsApi(config);
            var actionsSendMailRequest = new ActionsSendMailRequest?(); // ActionsSendMailRequest? |  (optional) 

            try
            {
                // Actions/SendMail
                ActionsSendMail200Response result = apiInstance.ActionsSendMail(actionsSendMailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSendMail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActionsSendMailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actions/SendMail
    ApiResponse<ActionsSendMail200Response> response = apiInstance.ActionsSendMailWithHttpInfo(actionsSendMailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActionsApi.ActionsSendMailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actionsSendMailRequest** | [**ActionsSendMailRequest?**](ActionsSendMailRequest?.md) |  | [optional]  |

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

<a id="actionssendsms"></a>
# **ActionsSendSms**
> ActionsSendMail200Response ActionsSendSms (ActionsSendSmsRequest? actionsSendSmsRequest = null)

Actions/SendSms

Send a text. Requires `TPAR_Id`, `Gsmnr` or both. If a `TPAR_Id` is passed and the given party already has a communication number. The text will be send to this number. If not, or if you only pass the `Gsmnr` parameter the text will be send to this number instead.   _Enter the RingRing API key in `parameter 558`. `CodeSms` can also be any TQCFG value configured in the office managment screen._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class ActionsSendSmsExample
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

            var apiInstance = new ActionsApi(config);
            var actionsSendSmsRequest = new ActionsSendSmsRequest?(); // ActionsSendSmsRequest? |  (optional) 

            try
            {
                // Actions/SendSms
                ActionsSendMail200Response result = apiInstance.ActionsSendSms(actionsSendSmsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSendSms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActionsSendSmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actions/SendSms
    ApiResponse<ActionsSendMail200Response> response = apiInstance.ActionsSendSmsWithHttpInfo(actionsSendSmsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActionsApi.ActionsSendSmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actionsSendSmsRequest** | [**ActionsSendSmsRequest?**](ActionsSendSmsRequest?.md) |  | [optional]  |

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

