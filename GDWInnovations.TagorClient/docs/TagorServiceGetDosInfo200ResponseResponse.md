# GDWInnovations.TagorClient.Model.TagorServiceGetDosInfo200ResponseResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** |  | [optional] 
**Error** | **string** |  | [optional] 
**Dossiernaam** | **string** |  | [optional] 
**Aanlegger** | **string** |  | [optional] 
**Verweerder** | **string** | Full name of the defendant. | [optional] 
**DossiersoortId** | **string** | This field will contain the file type. If a mapping with code &#x60;VOXTRON&#x60; is found in tagor, the id will converted. Otherwise &#x60;DSO + {filetype_id}&#x60; will be returned. | [optional] 
**StatusId** | **string** |  | [optional] 
**StadiumId** | **string** |  | [optional] 
**StadiumKlantId** | **string** |  | [optional] 
**StopstatusId** | **string** |  | [optional] 
**AlarmstatusId** | **string** |  | [optional] 
**DosbehId** | **string** | This field can contain the &#x60;file name&#x60;, the &#x60;file admin&#39;s username&#x60; or  &#x60;&#39;DBH&#39; + the file admin&#39;s user id&#x60; | [optional] 
**EmailVerweerder** | **string** | Email address of the first defendant or the one with the id passed as &#x60;TPAR_Id&#x60; in the request. | [optional] 
**GsmVerweerder** | **string** | Mobile of the first defendant or the one with the id passed as &#x60;TPAR_Id&#x60; in the request. | [optional] 
**DatumLtstBet** | **DateOnly** | Date of the last payment. | [optional] 
**BedragLtstBet** | **float** | Amount of the last payment in general. Could be the same as &#x60;BedragLtstOnbvBet&#x60; | [optional] 
**DatumLtstOnbvBet** | **DateOnly** |  | [optional] 
**BedragLtstOnbvBet** | **float** | Amount of the last payment which hasn&#39;t been confimed yet | [optional] 
**UrlFAQ** | **string** | Url pointing to the FAQ page | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

