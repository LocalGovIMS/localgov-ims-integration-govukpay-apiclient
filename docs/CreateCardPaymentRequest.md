# GovUKPayApiClient.Model.CreateCardPaymentRequest
The Payment Request Payload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | amount in pence | 
**DelayedCapture** | **bool** | delayed capture flag | [optional] 
**Description** | **string** | payment description | 
**Email** | **string** | email | [optional] 
**Language** | **string** | ISO-639-1 Alpha-2 code of a supported language to use on the payment pages | [optional] 
**Metadata** | [**ExternalMetadata**](ExternalMetadata.md) |  | [optional] 
**Moto** | **bool** | Mail Order / Telephone Order (MOTO) payment flag | [optional] 
**PrefilledCardholderDetails** | [**PrefilledCardholderDetails**](PrefilledCardholderDetails.md) |  | [optional] 
**Reference** | **string** | payment reference | 
**ReturnUrl** | **string** | service return url | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

