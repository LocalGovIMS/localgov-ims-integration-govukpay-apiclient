# GovUKPayApiClient.Api.RefundingCardPaymentsApi

All URIs are relative to *https://publicapi.payments.service.gov.uk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAPaymentRefund**](RefundingCardPaymentsApi.md#getapaymentrefund) | **GET** /v1/payments/{paymentId}/refunds/{refundId} | Find payment refund by ID |
| [**GetAllRefundsForAPayment**](RefundingCardPaymentsApi.md#getallrefundsforapayment) | **GET** /v1/payments/{paymentId}/refunds | Get all refunds for a payment |
| [**SearchRefunds**](RefundingCardPaymentsApi.md#searchrefunds) | **GET** /v1/refunds | Search refunds |
| [**SubmitARefundForAPayment**](RefundingCardPaymentsApi.md#submitarefundforapayment) | **POST** /v1/payments/{paymentId}/refunds | Submit a refund for a payment |

<a name="getapaymentrefund"></a>
# **GetAPaymentRefund**
> Refund GetAPaymentRefund (string paymentId, string refundId)

Find payment refund by ID

Return payment refund information by Refund ID The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class GetAPaymentRefundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RefundingCardPaymentsApi(config);
            var paymentId = "paymentId_example";  // string | 
            var refundId = "refundId_example";  // string | 

            try
            {
                // Find payment refund by ID
                Refund result = apiInstance.GetAPaymentRefund(paymentId, refundId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefundingCardPaymentsApi.GetAPaymentRefund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAPaymentRefundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find payment refund by ID
    ApiResponse<Refund> response = apiInstance.GetAPaymentRefundWithHttpInfo(paymentId, refundId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefundingCardPaymentsApi.GetAPaymentRefundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentId** | **string** |  |  |
| **refundId** | **string** |  |  |

### Return type

[**Refund**](Refund.md)

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

<a name="getallrefundsforapayment"></a>
# **GetAllRefundsForAPayment**
> RefundForSearchResult GetAllRefundsForAPayment (string paymentId)

Get all refunds for a payment

Return refunds for a payment. The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class GetAllRefundsForAPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RefundingCardPaymentsApi(config);
            var paymentId = "paymentId_example";  // string | 

            try
            {
                // Get all refunds for a payment
                RefundForSearchResult result = apiInstance.GetAllRefundsForAPayment(paymentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefundingCardPaymentsApi.GetAllRefundsForAPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllRefundsForAPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all refunds for a payment
    ApiResponse<RefundForSearchResult> response = apiInstance.GetAllRefundsForAPaymentWithHttpInfo(paymentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefundingCardPaymentsApi.GetAllRefundsForAPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentId** | **string** |  |  |

### Return type

[**RefundForSearchResult**](RefundForSearchResult.md)

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

<a name="searchrefunds"></a>
# **SearchRefunds**
> RefundSearchResults SearchRefunds (string fromDate = null, string toDate = null, string fromSettledDate = null, string toSettledDate = null, string page = null, string displaySize = null)

Search refunds

Search refunds by 'from' and 'to' date. The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class SearchRefundsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RefundingCardPaymentsApi(config);
            var fromDate = "fromDate_example";  // string | From date of refunds to be searched (this date is inclusive). Example=2015-08-13T12:35:00Z (optional) 
            var toDate = "toDate_example";  // string | To date of refunds to be searched (this date is exclusive). Example=2015-08-14T12:35:00Z (optional) 
            var fromSettledDate = "fromSettledDate_example";  // string | From settled date of refund to be searched (this date is inclusive). Example=2015-08-13 (optional) 
            var toSettledDate = "toSettledDate_example";  // string | To settled date of refund to be searched (this date is inclusive). Example=2015-08-13 (optional) 
            var page = "page_example";  // string | Page number requested for the search, should be a positive integer (optional, defaults to 1) (optional) 
            var displaySize = "displaySize_example";  // string | Number of results to be shown per page, should be a positive integer (optional, defaults to 500, max 500) (optional) 

            try
            {
                // Search refunds
                RefundSearchResults result = apiInstance.SearchRefunds(fromDate, toDate, fromSettledDate, toSettledDate, page, displaySize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefundingCardPaymentsApi.SearchRefunds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchRefundsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search refunds
    ApiResponse<RefundSearchResults> response = apiInstance.SearchRefundsWithHttpInfo(fromDate, toDate, fromSettledDate, toSettledDate, page, displaySize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefundingCardPaymentsApi.SearchRefundsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromDate** | **string** | From date of refunds to be searched (this date is inclusive). Example&#x3D;2015-08-13T12:35:00Z | [optional]  |
| **toDate** | **string** | To date of refunds to be searched (this date is exclusive). Example&#x3D;2015-08-14T12:35:00Z | [optional]  |
| **fromSettledDate** | **string** | From settled date of refund to be searched (this date is inclusive). Example&#x3D;2015-08-13 | [optional]  |
| **toSettledDate** | **string** | To settled date of refund to be searched (this date is inclusive). Example&#x3D;2015-08-13 | [optional]  |
| **page** | **string** | Page number requested for the search, should be a positive integer (optional, defaults to 1) | [optional]  |
| **displaySize** | **string** | Number of results to be shown per page, should be a positive integer (optional, defaults to 500, max 500) | [optional]  |

### Return type

[**RefundSearchResults**](RefundSearchResults.md)

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
| **422** | Invalid parameters. See Public API documentation for the correct data formats |  -  |
| **500** | Downstream system error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitarefundforapayment"></a>
# **SubmitARefundForAPayment**
> Refund SubmitARefundForAPayment (string paymentId, PaymentRefundRequest paymentRefundRequest)

Submit a refund for a payment

Return issued refund information. The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class SubmitARefundForAPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RefundingCardPaymentsApi(config);
            var paymentId = "paymentId_example";  // string | 
            var paymentRefundRequest = new PaymentRefundRequest(); // PaymentRefundRequest | requestPayload

            try
            {
                // Submit a refund for a payment
                Refund result = apiInstance.SubmitARefundForAPayment(paymentId, paymentRefundRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefundingCardPaymentsApi.SubmitARefundForAPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubmitARefundForAPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit a refund for a payment
    ApiResponse<Refund> response = apiInstance.SubmitARefundForAPaymentWithHttpInfo(paymentId, paymentRefundRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefundingCardPaymentsApi.SubmitARefundForAPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentId** | **string** |  |  |
| **paymentRefundRequest** | [**PaymentRefundRequest**](PaymentRefundRequest.md) | requestPayload |  |

### Return type

[**Refund**](Refund.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **202** | ACCEPTED |  -  |
| **401** | Credentials are required to access this resource |  -  |
| **404** | Not found |  -  |
| **412** | Refund amount available mismatch |  -  |
| **429** | Too many requests |  -  |
| **500** | Downstream system error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

