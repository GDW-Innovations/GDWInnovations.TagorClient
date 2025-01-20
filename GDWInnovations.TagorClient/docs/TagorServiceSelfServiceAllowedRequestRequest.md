# GDWInnovations.TagorClient.Model.TagorServiceSelfServiceAllowedRequestRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TDOSId** | **string** | Id of the file you want to check. This field is not required when using the &#x60;Code&#x60; authentication. In this case this endpoint will always only use the file linked to the code. | 
**Config** | **string** | Code of the config you want to validate against. Defaults to &#x60;DEF&#x60;. | [optional] 
**Telnr** | **string** | If you pass a phone number here it will be saved on the defendant as &#x60;last contact&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

