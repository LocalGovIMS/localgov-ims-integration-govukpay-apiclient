# GovUKPayApiClient.Model.CardDetails
A structure representing the payment card

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingAddress** | [**Address**](Address.md) |  | [optional] 
**CardBrand** | **string** |  | [optional] [readonly] 
**CardType** | **string** | The card type, &#x60;debit&#x60; or &#x60;credit&#x60; or &#x60;null&#x60; if not able to determine | [optional] [readonly] 
**CardholderName** | **string** |  | [optional] 
**ExpiryDate** | **string** | The expiry date of the card in MM/yy format | [optional] [readonly] 
**FirstDigitsCardNumber** | **string** |  | [optional] [readonly] 
**LastDigitsCardNumber** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

