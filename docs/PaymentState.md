# GovUKPayApiClient.Model.PaymentState
A structure representing the current state of the payment in its lifecycle.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | What went wrong with the Payment if it finished with an error - error code | [optional] [readonly] 
**Finished** | **bool** | Whether the payment has finished | [optional] [readonly] 
**Message** | **string** | What went wrong with the Payment if it finished with an error - English message | [optional] [readonly] 
**Status** | **string** | Current progress of the payment in its lifecycle | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

