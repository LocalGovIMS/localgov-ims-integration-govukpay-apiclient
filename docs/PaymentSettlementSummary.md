# GovUKPayApiClient.Model.PaymentSettlementSummary
A structure representing information about a settlement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CaptureSubmitTime** | **string** | Date and time capture request has been submitted. May be null if capture request was not immediately acknowledged by payment gateway. | [optional] [readonly] 
**CapturedDate** | **string** | Date of the capture event. | [optional] [readonly] 
**SettledDate** | **string** | The date that the transaction was paid into the service&#39;s account. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

