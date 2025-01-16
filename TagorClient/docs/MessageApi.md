# TagorClient.Api.MessageApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MessageAdd**](MessageApi.md#messageadd) | **POST** /Message/Add | Message/Add |
| [**MessageGetListFilter**](MessageApi.md#messagegetlistfilter) | **POST** /Message/GetListFilter | Message/GetListFilter |
| [**MessageGetLog**](MessageApi.md#messagegetlog) | **POST** /Message/GetLog | Message/GetLog |
| [**MessageGetMessage**](MessageApi.md#messagegetmessage) | **POST** /Message/GetMessage | Message/GetMessage |
| [**MessageGetSenderReceiverList**](MessageApi.md#messagegetsenderreceiverlist) | **POST** /Message/GetSenderReceiverList | Message/GetSenderReceiverList |
| [**MessageToggleRead**](MessageApi.md#messagetoggleread) | **POST** /Message/ToggleRead | Message/ToggleRead |

<a id="messageadd"></a>
# **MessageAdd**
> MessageAdd200Response MessageAdd (MessageAddRequest? messageAddRequest = null)

Message/Add

`ttWebContext` requires a `TDOS_Id` element. Pass a message in `dsTBERICHTWeb`. Optional attachments can be passed in `dsAttachmentWeb`.  _`Param 436` will be used to determine the message's disgroep. Defaults to `7006`_

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class MessageAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MessageApi(config);
            var messageAddRequest = new MessageAddRequest?(); // MessageAddRequest? |  (optional) 

            try
            {
                // Message/Add
                MessageAdd200Response result = apiInstance.MessageAdd(messageAddRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.MessageAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Message/Add
    ApiResponse<MessageAdd200Response> response = apiInstance.MessageAddWithHttpInfo(messageAddRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.MessageAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageAddRequest** | [**MessageAddRequest?**](MessageAddRequest?.md) |  | [optional]  |

### Return type

[**MessageAdd200Response**](MessageAdd200Response.md)

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

<a id="messagegetlistfilter"></a>
# **MessageGetListFilter**
> MessageAdd200Response MessageGetListFilter (DossierSearchRequest? dossierSearchRequest = null)

Message/GetListFilter

Same endpoint as [`Message/GetList`](#operation/MessageGetList). See this endpoint for the possible values in `dsWebContext`. This endpoint also accepts a `dsFilter` object that works the same as [`Dossier/Search`](#operation/DossierSearch).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class MessageGetListFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MessageApi(config);
            var dossierSearchRequest = new DossierSearchRequest?(); // DossierSearchRequest? |  (optional) 

            try
            {
                // Message/GetListFilter
                MessageAdd200Response result = apiInstance.MessageGetListFilter(dossierSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.MessageGetListFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageGetListFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Message/GetListFilter
    ApiResponse<MessageAdd200Response> response = apiInstance.MessageGetListFilterWithHttpInfo(dossierSearchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.MessageGetListFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dossierSearchRequest** | [**DossierSearchRequest?**](DossierSearchRequest?.md) |  | [optional]  |

### Return type

[**MessageAdd200Response**](MessageAdd200Response.md)

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

<a id="messagegetlog"></a>
# **MessageGetLog**
> MessageAdd200Response MessageGetLog (CodeGetListRequest? codeGetListRequest = null)

Message/GetLog

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class MessageGetLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MessageApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // Message/GetLog
                MessageAdd200Response result = apiInstance.MessageGetLog(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.MessageGetLog: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageGetLogWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Message/GetLog
    ApiResponse<MessageAdd200Response> response = apiInstance.MessageGetLogWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.MessageGetLogWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

### Return type

[**MessageAdd200Response**](MessageAdd200Response.md)

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

<a id="messagegetmessage"></a>
# **MessageGetMessage**
> MessageGetMessage200Response MessageGetMessage (MessageGetMessageRequest? messageGetMessageRequest = null)

Message/GetMessage

Gets a single message based on id. `ttWebContext` requires a `TBERICHT_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class MessageGetMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MessageApi(config);
            var messageGetMessageRequest = new MessageGetMessageRequest?(); // MessageGetMessageRequest? |  (optional) 

            try
            {
                // Message/GetMessage
                MessageGetMessage200Response result = apiInstance.MessageGetMessage(messageGetMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.MessageGetMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageGetMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Message/GetMessage
    ApiResponse<MessageGetMessage200Response> response = apiInstance.MessageGetMessageWithHttpInfo(messageGetMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.MessageGetMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageGetMessageRequest** | [**MessageGetMessageRequest?**](MessageGetMessageRequest?.md) |  | [optional]  |

### Return type

[**MessageGetMessage200Response**](MessageGetMessage200Response.md)

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

<a id="messagegetsenderreceiverlist"></a>
# **MessageGetSenderReceiverList**
> ConfigInfo200Response MessageGetSenderReceiverList (CodeGetListRequest? codeGetListRequest = null)

Message/GetSenderReceiverList

When this endpoint is called without any `ttWebContext` records it will return all groups a user belongs to. Other options are optional: - `Type` (enum `senders` or `receivers`): when `senders` is passed `TPAR_Id` is required. - `TDOS_Id`: active file you want to send a message on. This is required to get the groups of the user. Otherwise only the active user will be returned (if this user is allowed to send messages). - `TPAR_Id`: Id of the party you want to send messages to/from.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class MessageGetSenderReceiverListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MessageApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // Message/GetSenderReceiverList
                ConfigInfo200Response result = apiInstance.MessageGetSenderReceiverList(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.MessageGetSenderReceiverList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageGetSenderReceiverListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Message/GetSenderReceiverList
    ApiResponse<ConfigInfo200Response> response = apiInstance.MessageGetSenderReceiverListWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.MessageGetSenderReceiverListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

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

<a id="messagetoggleread"></a>
# **MessageToggleRead**
> MessageGetMessage200Response MessageToggleRead (CodeGetListRequest? codeGetListRequest = null)

Message/ToggleRead

Toggles the status of a message. `ttWebContext` requires a `TBERICHT_Id` element.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TagorClient.Api;
using TagorClient.Client;
using TagorClient.Model;

namespace Example
{
    public class MessageToggleReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MessageApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // Message/ToggleRead
                MessageGetMessage200Response result = apiInstance.MessageToggleRead(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.MessageToggleRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageToggleReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Message/ToggleRead
    ApiResponse<MessageGetMessage200Response> response = apiInstance.MessageToggleReadWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.MessageToggleReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

### Return type

[**MessageGetMessage200Response**](MessageGetMessage200Response.md)

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

