# GovUKPayApiClient.Model.PaymentDetailForSearch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**PaymentLinksForSearch**](PaymentLinksForSearch.md) |  | [optional] 
**Amount** | **long** |  | [optional] 
**AuthorisationSummary** | [**AuthorisationSummary**](AuthorisationSummary.md) |  | [optional] 
**CardBrand** | **string** | Card Brand. Deprecated, please use card_details.card_brand instead | [optional] [readonly] 
**CardDetails** | [**CardDetails**](CardDetails.md) |  | [optional] 
**CorporateCardSurcharge** | **long** |  | [optional] [readonly] 
**CreatedDate** | **string** |  | [optional] [readonly] 
**DelayedCapture** | **bool** | delayed capture flag | [optional] [readonly] 
**Description** | **string** |  | [optional] 
**Email** | **string** |  | [optional] 
**Fee** | **long** | processing fee taken by the GOV.UK Pay platform, in pence. Only available depending on payment service provider | [optional] [readonly] 
**Language** | **string** |  | [optional] 
**Metadata** | [**ExternalMetadata**](ExternalMetadata.md) |  | [optional] 
**Moto** | **bool** | Mail Order / Telephone Order (MOTO) payment flag | [optional] 
**NetAmount** | **long** | amount including all surcharges and less all fees, in pence. Only available depending on payment service provider | [optional] [readonly] 
**PaymentId** | **string** |  | [optional] [readonly] 
**PaymentProvider** | **string** |  | [optional] [readonly] 
**ProviderId** | **string** |  | [optional] [readonly] 
**Reference** | **string** |  | [optional] 
**RefundSummary** | [**RefundSummary**](RefundSummary.md) |  | [optional] 
**ReturnUrl** | **string** |  | [optional] [readonly] 
**SettlementSummary** | [**PaymentSettlementSummary**](PaymentSettlementSummary.md) |  | [optional] 
**State** | [**PaymentState**](PaymentState.md) |  | [optional] 
**TotalAmount** | **long** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

