# GovUKPayApiClient.Model.DisputeDetailForSearch
Contains disputes matching your search criteria.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**DisputeLinksForSearch**](DisputeLinksForSearch.md) |  | [optional] 
**Amount** | **long** | The disputed amount in pence. | [optional] [readonly] 
**CreatedDate** | **string** | The date and time the user&#39;s bank told GOV.UK Pay about this dispute. | [optional] [readonly] 
**DisputeId** | **string** | The unique ID GOV.UK Pay automatically associated with this dispute when the paying user disputed the payment. | [optional] [readonly] 
**EvidenceDueDate** | **string** | The deadline for submitting your supporting evidence. This value uses Coordinated Universal Time (UTC) and ISO 8601 format | [optional] [readonly] 
**Fee** | **long** | The payment service provider’s dispute fee, in pence. | [optional] [readonly] 
**NetAmount** | **long** | The amount, in pence, your payment service provider will take for a lost dispute. &#39;net_amount&#39; is deducted from your payout after you lose the dispute. For example, a &#39;net_amount&#39; of &#39;-1500&#39; means your PSP will take £15.00 from your next payout into your bank account. &#39;net_amount&#39; is always a negative value. &#39;net_amount&#39; only appears if you lose the dispute. | [optional] [readonly] 
**PaymentId** | **string** | The unique ID GOV.UK Pay automatically associated with this payment when you created it. | [optional] [readonly] 
**Reason** | **string** | The reason the paying user gave for disputing this payment. Possible values are: &#39;credit_not_processed&#39;, &#39;duplicate&#39;, &#39;fraudulent&#39;, &#39;general&#39;, &#39;product_not_received&#39;, &#39;product_unacceptable&#39;, &#39;unrecognised&#39;, &#39;subscription_cancelled&#39;, &gt;&#39;other&#39; | [optional] [readonly] 
**SettlementSummary** | [**SettlementSummary**](SettlementSummary.md) |  | [optional] 
**Status** | **string** | The current status of the dispute. Possible values are: &#39;needs_response&#39;, &#39;won&#39;, &#39;lost&#39;, &#39;under_review&#39; | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

