# GDWInnovations.TagorClient.Model.TagorServiceSavePaymentPlanRequestRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TDOSId** | **string** | Id of the file you want to create a payment plan on. This field is not required when using the &#x60;Code&#x60; authentication. In this case this endpoint will always only use the file linked to the code. | 
**TPARId** | **string** | The party to link with the payment plan | [optional] 
**Bedrag** | **decimal** | Enter either this one or &#x60;Periodes&#x60; | [optional] 
**Periodes** | **decimal** | Enter either this one or &#x60;Bedrag&#x60; | [optional] 
**Startdatum** | **DateOnly** | Defaults to today plus a configured amount of days. | [optional] 
**IPadres** | **string** | When entered the payment plan will get the source &#x60;WEB&#x60; | [optional] 
**Telnr** | **string** | When entered the payment plan will get the source &#x60;CEN&#x60; | [optional] 
**RekeningId** | **string** | Not in use | [optional] 
**OverrideChecks** | **bool** | This disables all checks on the input data. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

