# GovUKPayApiClient.Api.CardPaymentsApi

All URIs are relative to *https://publicapi.payments.service.gov.uk*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelAPayment**](CardPaymentsApi.md#cancelapayment) | **POST** /v1/payments/{paymentId}/cancel | Cancel payment
[**CaptureAPayment**](CardPaymentsApi.md#captureapayment) | **POST** /v1/payments/{paymentId}/capture | Capture payment
[**CreateAPayment**](CardPaymentsApi.md#createapayment) | **POST** /v1/payments | Create new payment
[**GetAPayment**](CardPaymentsApi.md#getapayment) | **GET** /v1/payments/{paymentId} | Find payment by ID
[**GetEventsForAPayment**](CardPaymentsApi.md#geteventsforapayment) | **GET** /v1/payments/{paymentId}/events | Return payment events by ID
[**SearchPayments**](CardPaymentsApi.md#searchpayments) | **GET** /v1/payments | Search payments


<a name="cancelapayment"></a>
# **CancelAPayment**
> void CancelAPayment (string paymentId)

Cancel payment

Cancel a payment based on the provided payment ID and the Authorisation token. The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'. A payment can only be cancelled if it's in a state that isn't finished.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class CancelAPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CardPaymentsApi(config);
            var paymentId = hu20sqlact5260q2nanm0q8u93;  // string | Payment identifier

            try
            {
                // Cancel payment
                apiInstance.CancelAPayment(paymentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardPaymentsApi.CancelAPayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentId** | **string**| Payment identifier | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Cancellation of payment failed |  -  |
| **401** | Credentials are required to access this resource |  -  |
| **404** | Not found |  -  |
| **409** | Conflict |  -  |
| **429** | Too many requests |  -  |
| **500** | Downstream system error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="captureapayment"></a>
# **CaptureAPayment**
> void CaptureAPayment (string paymentId)

Capture payment

Capture a payment based on the provided payment ID and the Authorisation token. The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'. A payment can only be captured if it's in 'submitted' state

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class CaptureAPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CardPaymentsApi(config);
            var paymentId = hu20sqlact5260q2nanm0q8u93;  // string | Payment identifier

            try
            {
                // Capture payment
                apiInstance.CaptureAPayment(paymentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardPaymentsApi.CaptureAPayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentId** | **string**| Payment identifier | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Capture of payment failed |  -  |
| **401** | Credentials are required to access this resource |  -  |
| **404** | Not found |  -  |
| **409** | Conflict |  -  |
| **429** | Too many requests |  -  |
| **500** | Downstream system error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapayment"></a>
# **CreateAPayment**
> CreatePaymentResult CreateAPayment (CreateCardPaymentRequest createCardPaymentRequest)

Create new payment

Create a new payment for the account associated to the Authorisation token. The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class CreateAPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CardPaymentsApi(config);
            var createCardPaymentRequest = new CreateCardPaymentRequest(); // CreateCardPaymentRequest | requestPayload

            try
            {
                // Create new payment
                CreatePaymentResult result = apiInstance.CreateAPayment(createCardPaymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardPaymentsApi.CreateAPayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createCardPaymentRequest** | [**CreateCardPaymentRequest**](CreateCardPaymentRequest.md)| requestPayload | 

### Return type

[**CreatePaymentResult**](CreatePaymentResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad request |  -  |
| **401** | Credentials are required to access this resource |  -  |
| **422** | Invalid attribute value: description. Must be less than or equal to 255 characters length |  -  |
| **429** | Too many requests |  -  |
| **500** | Downstream system error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapayment"></a>
# **GetAPayment**
> GetPaymentResult GetAPayment (string paymentId)

Find payment by ID

Return information about the payment The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class GetAPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CardPaymentsApi(config);
            var paymentId = hu20sqlact5260q2nanm0q8u93;  // string | Payment identifier

            try
            {
                // Find payment by ID
                GetPaymentResult result = apiInstance.GetAPayment(paymentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardPaymentsApi.GetAPayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentId** | **string**| Payment identifier | 

### Return type

[**GetPaymentResult**](GetPaymentResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Credentials are required to access this resource |  -  |
| **404** | Not found |  -  |
| **429** | Too many requests |  -  |
| **500** | Downstream system error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventsforapayment"></a>
# **GetEventsForAPayment**
> PaymentEvents GetEventsForAPayment (string paymentId)

Return payment events by ID

Return payment events information about a certain payment The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class GetEventsForAPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CardPaymentsApi(config);
            var paymentId = hu20sqlact5260q2nanm0q8u93;  // string | Payment identifier

            try
            {
                // Return payment events by ID
                PaymentEvents result = apiInstance.GetEventsForAPayment(paymentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardPaymentsApi.GetEventsForAPayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentId** | **string**| Payment identifier | 

### Return type

[**PaymentEvents**](PaymentEvents.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Credentials are required to access this resource |  -  |
| **404** | Not found |  -  |
| **429** | Too many requests |  -  |
| **500** | Downstream system error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchpayments"></a>
# **SearchPayments**
> PaymentSearchResults SearchPayments (string reference = null, string email = null, string state = null, string cardBrand = null, string fromDate = null, string toDate = null, string page = null, string displaySize = null, string cardholderName = null, string firstDigitsCardNumber = null, string lastDigitsCardNumber = null, string fromSettledDate = null, string toSettledDate = null)

Search payments

Search payments by reference, state, 'from' and 'to' date. The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class SearchPaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CardPaymentsApi(config);
            var reference = "reference_example";  // string | Your payment reference to search (exact match, case insensitive) (optional) 
            var email = "email_example";  // string | The user email used in the payment to be searched (optional) 
            var state = success;  // string | State of payments to be searched. Example=success (optional) 
            var cardBrand = "cardBrand_example";  // string | Card brand used for payment. Example=master-card (optional) 
            var fromDate = "fromDate_example";  // string | From date of payments to be searched (this date is inclusive). Example=2015-08-13T12:35:00Z (optional) 
            var toDate = "toDate_example";  // string | To date of payments to be searched (this date is exclusive). Example=2015-08-14T12:35:00Z (optional) 
            var page = "page_example";  // string | Page number requested for the search, should be a positive integer (optional, defaults to 1) (optional) 
            var displaySize = "displaySize_example";  // string | Number of results to be shown per page, should be a positive integer (optional, defaults to 500, max 500) (optional) 
            var cardholderName = "cardholderName_example";  // string | Name on card used to make payment (optional) 
            var firstDigitsCardNumber = "firstDigitsCardNumber_example";  // string | First six digits of the card used to make payment (optional) 
            var lastDigitsCardNumber = "lastDigitsCardNumber_example";  // string | Last four digits of the card used to make payment (optional) 
            var fromSettledDate = "fromSettledDate_example";  // string | From settled date of payment to be searched (this date is inclusive). Example=2015-08-13 (optional) 
            var toSettledDate = "toSettledDate_example";  // string | To settled date of payment to be searched (this date is inclusive). Example=2015-08-14 (optional) 

            try
            {
                // Search payments
                PaymentSearchResults result = apiInstance.SearchPayments(reference, email, state, cardBrand, fromDate, toDate, page, displaySize, cardholderName, firstDigitsCardNumber, lastDigitsCardNumber, fromSettledDate, toSettledDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardPaymentsApi.SearchPayments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reference** | **string**| Your payment reference to search (exact match, case insensitive) | [optional] 
 **email** | **string**| The user email used in the payment to be searched | [optional] 
 **state** | **string**| State of payments to be searched. Example&#x3D;success | [optional] 
 **cardBrand** | **string**| Card brand used for payment. Example&#x3D;master-card | [optional] 
 **fromDate** | **string**| From date of payments to be searched (this date is inclusive). Example&#x3D;2015-08-13T12:35:00Z | [optional] 
 **toDate** | **string**| To date of payments to be searched (this date is exclusive). Example&#x3D;2015-08-14T12:35:00Z | [optional] 
 **page** | **string**| Page number requested for the search, should be a positive integer (optional, defaults to 1) | [optional] 
 **displaySize** | **string**| Number of results to be shown per page, should be a positive integer (optional, defaults to 500, max 500) | [optional] 
 **cardholderName** | **string**| Name on card used to make payment | [optional] 
 **firstDigitsCardNumber** | **string**| First six digits of the card used to make payment | [optional] 
 **lastDigitsCardNumber** | **string**| Last four digits of the card used to make payment | [optional] 
 **fromSettledDate** | **string**| From settled date of payment to be searched (this date is inclusive). Example&#x3D;2015-08-13 | [optional] 
 **toSettledDate** | **string**| To settled date of payment to be searched (this date is inclusive). Example&#x3D;2015-08-14 | [optional] 

### Return type

[**PaymentSearchResults**](PaymentSearchResults.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Credentials are required to access this resource |  -  |
| **422** | Invalid parameters: from_date, to_date, status, display_size. See Public API documentation for the correct data formats |  -  |
| **429** | Too many requests |  -  |
| **500** | Downstream system error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

