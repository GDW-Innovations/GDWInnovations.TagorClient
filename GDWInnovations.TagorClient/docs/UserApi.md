# GDWInnovations.TagorClient.Api.UserApi

All URIs are relative to *https://localhost/v1/web*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserAdd**](UserApi.md#useradd) | **POST** /User/Add | User/Add |
| [**UserCanAccess**](UserApi.md#usercanaccess) | **POST** /User/CanAccess | User/CanAccess |
| [**UserGet**](UserApi.md#userget) | **POST** /User/Get | User/Get |
| [**UserGetPermissions**](UserApi.md#usergetpermissions) | **POST** /User/GetPermissions | User/GetPermissions |
| [**UserGetPermissionsList**](UserApi.md#usergetpermissionslist) | **POST** /User/GetPermissionsList | User/GetPermissionsList |
| [**UserSavePermissions**](UserApi.md#usersavepermissions) | **POST** /User/SavePermissions | User/SavePermissions |
| [**UserSavePermissionsList**](UserApi.md#usersavepermissionslist) | **POST** /User/SavePermissionsList | User/SavePermissionsList |

<a id="useradd"></a>
# **UserAdd**
> UserAdd200Response UserAdd (UserAddRequest? userAddRequest = null)

User/Add

Add/Create a user. Pass the `TPAR_Id` if you want to create a `User` for an existing `Party`.  Optional you can pass a `BASE-USER` context record with as value a `TUSER_Id` to inherit the web configuration of this user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class UserAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var userAddRequest = new UserAddRequest?(); // UserAddRequest? |  (optional) 

            try
            {
                // User/Add
                UserAdd200Response result = apiInstance.UserAdd(userAddRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User/Add
    ApiResponse<UserAdd200Response> response = apiInstance.UserAddWithHttpInfo(userAddRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userAddRequest** | [**UserAddRequest?**](UserAddRequest?.md) |  | [optional]  |

### Return type

[**UserAdd200Response**](UserAdd200Response.md)

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

<a id="usercanaccess"></a>
# **UserCanAccess**
> UserCanAccess200Response UserCanAccess (CodeGetListRequest? codeGetListRequest = null)

User/CanAccess

This endpoint returns the users that have access to the given asset. E.g. If you pass `TQDOSSOORT_Id`, you'll get all users allowed to view files of this type. Pass one or more of the following filetypes: - `TQDOSSOORT_Id` - `TPAR_Id`. For filtering a party regardless of type. - `TPAR|TQPARSOORT_Id`. For filtering a party with matching party type. Pass both `TPAR_Id` and `TQPARSOORT_Id` in a context record separated by a pipe. ex: `9000000000000000001|9000000000000000001`.   _This searches the values configured on the web configuration tab in the user managment._

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class UserCanAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // User/CanAccess
                UserCanAccess200Response result = apiInstance.UserCanAccess(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCanAccess: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCanAccessWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User/CanAccess
    ApiResponse<UserCanAccess200Response> response = apiInstance.UserCanAccessWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCanAccessWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

### Return type

[**UserCanAccess200Response**](UserCanAccess200Response.md)

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

<a id="userget"></a>
# **UserGet**
> UserGet200Response UserGet (UserGetRequest? userGetRequest = null)

User/Get

Get a user by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class UserGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var userGetRequest = new UserGetRequest?(); // UserGetRequest? |  (optional) 

            try
            {
                // User/Get
                UserGet200Response result = apiInstance.UserGet(userGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User/Get
    ApiResponse<UserGet200Response> response = apiInstance.UserGetWithHttpInfo(userGetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGetRequest** | [**UserGetRequest?**](UserGetRequest?.md) |  | [optional]  |

### Return type

[**UserGet200Response**](UserGet200Response.md)

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

<a id="usergetpermissions"></a>
# **UserGetPermissions**
> UserGetPermissions200Response UserGetPermissions (CodeGetListRequest? codeGetListRequest = null)

User/GetPermissions

Get all (single) permissions of a user. This will return all the permissions that are represented as a toggle in Tagor. i.e. all permissions on the `Web permissies` tab.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class UserGetPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // User/GetPermissions
                UserGetPermissions200Response result = apiInstance.UserGetPermissions(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User/GetPermissions
    ApiResponse<UserGetPermissions200Response> response = apiInstance.UserGetPermissionsWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetPermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

### Return type

[**UserGetPermissions200Response**](UserGetPermissions200Response.md)

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

<a id="usergetpermissionslist"></a>
# **UserGetPermissionsList**
> UserGetPermissionsList200Response UserGetPermissionsList (CodeGetListRequest? codeGetListRequest = null)

User/GetPermissionsList

List all permissions of a user by type. Via this endpoint you'll be able to retreive al permissions with mutliple values. In general this endpoint is for all permissions on the `Web configuratie` tab in Tagor.  Possible type values: - `WEBT3001` or `TPAR` = Party   - Get a list of parties + party types. These have to be on a file for a user to be allowed to view the file.   - Unlike the other types this will return a pipe separated value of both party id and party type id   - `WEBT3002` or `TQDOSSOORT` = File type   - Returns a list of all file types a user is allowed to see   - `WEBT3006` or `TQDISGROEP` = Document types   - Returns a list of all document types a user can use when adding a document   - `WEBT3007` or `WL_QRY_FIELD` = Mergefields   - Returns a list of all mergefields a user is able to request with [`Document/GetMergefield`](#operation/DocumentGetMergefield)   - If a user doesn't have any mergefields configured the default setting from the office configuration screen will be used.   - `WEBT3005` or `TDOCM` = Document types   - Returns a list of all `TDOCM_Ids` a user is able to request in [`Document/Generate`](#operation/DocumentGenerate)   - `WEBT3004` or `TQDOCSECURITY` = Document security   - Returns a list of all document security types a user is able to see

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class UserGetPermissionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var codeGetListRequest = new CodeGetListRequest?(); // CodeGetListRequest? |  (optional) 

            try
            {
                // User/GetPermissionsList
                UserGetPermissionsList200Response result = apiInstance.UserGetPermissionsList(codeGetListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetPermissionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetPermissionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User/GetPermissionsList
    ApiResponse<UserGetPermissionsList200Response> response = apiInstance.UserGetPermissionsListWithHttpInfo(codeGetListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetPermissionsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeGetListRequest** | [**CodeGetListRequest?**](CodeGetListRequest?.md) |  | [optional]  |

### Return type

[**UserGetPermissionsList200Response**](UserGetPermissionsList200Response.md)

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

<a id="usersavepermissions"></a>
# **UserSavePermissions**
> UserGetPermissions200Response UserSavePermissions (UserSavePermissionsRequest? userSavePermissionsRequest = null)

User/SavePermissions

Save all (single) permissions of a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class UserSavePermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var userSavePermissionsRequest = new UserSavePermissionsRequest?(); // UserSavePermissionsRequest? |  (optional) 

            try
            {
                // User/SavePermissions
                UserGetPermissions200Response result = apiInstance.UserSavePermissions(userSavePermissionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSavePermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSavePermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User/SavePermissions
    ApiResponse<UserGetPermissions200Response> response = apiInstance.UserSavePermissionsWithHttpInfo(userSavePermissionsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSavePermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSavePermissionsRequest** | [**UserSavePermissionsRequest?**](UserSavePermissionsRequest?.md) |  | [optional]  |

### Return type

[**UserGetPermissions200Response**](UserGetPermissions200Response.md)

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

<a id="usersavepermissionslist"></a>
# **UserSavePermissionsList**
> UserGetPermissionsList200Response UserSavePermissionsList (UserSavePermissionsListRequest? userSavePermissionsListRequest = null)

User/SavePermissionsList

Save a list of all permissions of a user by type. See [`User/GetPermissionsList`](#operation/UserGetPermissionsList) for all possible type values. All current values for the specified user + type will be deleted and overwritten with the posted valued. If you want to add a value use [`User/GetPermissionsList`](#operation/UserGetPermissionsList) to get all current values, add the value to the array and post it to this endpoint. Note: for the `TPAR` permissions two values are required and should be passed in the id field, seperated by a pipe.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace Example
{
    public class UserSavePermissionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/v1/web";
            // Configure Bearer token for authorization: Orng
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure Bearer token for authorization: Tgr
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var userSavePermissionsListRequest = new UserSavePermissionsListRequest?(); // UserSavePermissionsListRequest? |  (optional) 

            try
            {
                // User/SavePermissionsList
                UserGetPermissionsList200Response result = apiInstance.UserSavePermissionsList(userSavePermissionsListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSavePermissionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSavePermissionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User/SavePermissionsList
    ApiResponse<UserGetPermissionsList200Response> response = apiInstance.UserSavePermissionsListWithHttpInfo(userSavePermissionsListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSavePermissionsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSavePermissionsListRequest** | [**UserSavePermissionsListRequest?**](UserSavePermissionsListRequest?.md) |  | [optional]  |

### Return type

[**UserGetPermissionsList200Response**](UserGetPermissionsList200Response.md)

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

