# GovUKPayApiClient.Model.AuthorisationRequest
Contains the user's payment information. This information will be sent to the payment service provider to authorise the payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardNumber** | **string** | The full card number from the paying user&#39;s card. | 
**CardholderName** | **string** | The name on the paying user&#39;s card. | 
**Cvc** | **string** | The card verification code (CVC) or card verification value (CVV) on the paying user&#39;s card. | 
**ExpiryDate** | **string** | The expiry date of the paying user&#39;s card. This value must be in &#x60;MM/YY&#x60; format. | 
**OneTimeToken** | **string** | This single use token authorises your request and matches it to a payment. GOV.UK Pay generated the &#x60;one_time_token&#x60; when the payment was created. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

