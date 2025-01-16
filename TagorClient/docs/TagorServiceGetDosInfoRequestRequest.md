# TagorClient.Model.TagorServiceGetDosInfoRequestRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TDOSId** | **string** | Id of the file you want to retreive. This field is not required when using the &#x60;Code&#x60; authentication. In this case this endpoint will always only return the file linked to the code. | 
**TPARId** | **string** | When this id is passed, the party this id represents is returned (if its a party on the file). This is useful when a file has multiple parties of the same type and you want to get a specific party instead of the first one in the list. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

