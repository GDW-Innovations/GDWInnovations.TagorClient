# TagorClient.Model.TagorServiceGetVoxtronReferentie200ResponseResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** |  | [optional] 
**Error** | **string** |  | [optional] 
**DosSoortId** | **string** | This field will contain the file type. If a mapping with code &#x60;VOXTRON&#x60; is found in tagor, the id will converted. Otherwise &#x60;DSO + {filetype_id}&#x60; will be returned. | [optional] 
**DosBehId** | **string** | This field can contain the &#x60;file name&#x60;, the &#x60;file admin&#39;s username&#x60; or  &#x60;&#39;DBH&#39; + the file admin&#39;s user id&#x60; | [optional] 
**DosStatus** | **string** | This field will contain the file status or file stage status. If a mapping with code &#x60;VOXTRON&#x60; is found in tagor, the id will converted. Otherwise &#x60;DSO + {status_id}&#x60; will be returned. | [optional] 
**AantalVerw** | **int** | Amount of defendants on a file. | [optional] 
**VolgNrVerw** | **int** | Index number of the defendant. | [optional] 
**DosId** | **string** |  | [optional] 
**Dagvaarding** | **bool** | Indicate if there&#39;s been a subpoena. | [optional] 
**ReturnCode** | **string** | - &#x60;0&#x60;: Success - &#x60;-1&#x60;: Unknown file or wrong index number passed in &#x60;Referentie&#x60;. - &#x60;-2&#x60;: Multiple files found. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

