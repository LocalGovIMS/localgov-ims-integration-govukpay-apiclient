# GovUKPayApiClient.Model.CreatePaymentResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**PaymentLinks**](PaymentLinks.md) |  | [optional] 
**Amount** | **long** | The amount in pence. | [optional] 
**CardDetails** | [**CardDetails**](CardDetails.md) |  | [optional] 
**CreatedDate** | **string** | The date you created the payment. | [optional] 
**DelayedCapture** | **bool** | Whether to [delay capturing](https://docs.payments.service.gov.uk/optional_features/delayed_capture/) this payment. | [optional] [readonly] 
**Description** | **string** | The human-readable description you gave the payment. | [optional] 
**Email** | **string** | The email address of your user. | [optional] 
**Language** | **string** | Which language your users will see on the payment pages when they make a payment. | [optional] 
**Metadata** | [**ExternalMetadata**](ExternalMetadata.md) |  | [optional] 
**Moto** | **bool** | Mail Order / Telephone Order (MOTO) payment flag. | [optional] 
**PaymentId** | **string** | The unique identifier of the payment. | [optional] 
**PaymentProvider** | **string** |  | [optional] 
**ProviderId** | **string** | The reference number the payment gateway associated with the payment. | [optional] 
**Reference** | **string** | The reference number you associated with this payment. | [optional] 
**RefundSummary** | [**RefundSummary**](RefundSummary.md) |  | [optional] 
**ReturnUrl** | **string** | An HTTPS URL on your site that your user will be sent back to once they have completed their payment attempt on GOV.UK Pay. | [optional] 
**SettlementSummary** | [**PaymentSettlementSummary**](PaymentSettlementSummary.md) |  | [optional] 
**State** | [**PaymentState**](PaymentState.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

