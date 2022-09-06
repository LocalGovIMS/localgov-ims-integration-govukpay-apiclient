# GovUKPayApiClient.Api.DisputesApi

All URIs are relative to *https://publicapi.payments.service.gov.uk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SearchDisputes**](DisputesApi.md#searchdisputes) | **GET** /v1/disputes | Search disputes |

<a name="searchdisputes"></a>
# **SearchDisputes**
> DisputesSearchResults SearchDisputes (string fromDate = null, string toDate = null, string fromSettledDate = null, string toSettledDate = null, string status = null, string page = null, string displaySize = null)

Search disputes

Search disputes by status, 'from' and 'to' date, and 'from' and 'to' settled_date. The Authorisation token needs to be specified in the 'authorization' header as 'authorization: Bearer YOUR_API_KEY_HERE'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class SearchDisputesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DisputesApi(config);
            var fromDate = "fromDate_example";  // string | Returns disputes raised on or after the 'from_date' Date and time must be coordinated Universal Time (UTC) and ISO 8601 format to second-level accuracy - 'YYYY-MM-DDTHH:MM:SSZ'. (optional) 
            var toDate = "toDate_example";  // string | Returns disputes raised before the 'to_date' Date and time must be coordinated Universal Time (UTC) and ISO 8601 format to second-level accuracy - 'YYYY-MM-DDTHH:MM:SSZ'. (optional) 
            var fromSettledDate = "fromSettledDate_example";  // string | Returns disputes settled on or after the 'from_settled_date'. Date must be in ISO 8601 format to date-level accuracy - 'YYYY-MM-DD'. Disputes are settled when your payment service provider takes the disputed amount from a payout to your bank account.You can only use 'from_settled_date' to find disputes raised on or after 8 August 2022. (optional) 
            var toSettledDate = "toSettledDate_example";  // string | Returns disputes settled before the 'to_settled_date'. 'Date must be in ISO 8601 format to date-level accuracy - 'YYYY-MM-DD'.Disputes are settled when your payment service provider takes the disputed amount from a payout to your bank account. You can only use 'to_settled_date' to find disputes raised on or after 8 August 2022. (optional) 
            var status = won;  // string | Returns disputes with a matching 'status'. 'status' reflects what stage of the dispute process a dispute is at. (optional) 
            var page = "page_example";  // string | Returns a specific page of results. Defaults to '1'. (optional) 
            var displaySize = "displaySize_example";  // string | The number of disputes returned per results page. Defaults to '500'. Maximum value is '500' (optional) 

            try
            {
                // Search disputes
                DisputesSearchResults result = apiInstance.SearchDisputes(fromDate, toDate, fromSettledDate, toSettledDate, status, page, displaySize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisputesApi.SearchDisputes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchDisputesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search disputes
    ApiResponse<DisputesSearchResults> response = apiInstance.SearchDisputesWithHttpInfo(fromDate, toDate, fromSettledDate, toSettledDate, status, page, displaySize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisputesApi.SearchDisputesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromDate** | **string** | Returns disputes raised on or after the &#39;from_date&#39; Date and time must be coordinated Universal Time (UTC) and ISO 8601 format to second-level accuracy - &#39;YYYY-MM-DDTHH:MM:SSZ&#39;. | [optional]  |
| **toDate** | **string** | Returns disputes raised before the &#39;to_date&#39; Date and time must be coordinated Universal Time (UTC) and ISO 8601 format to second-level accuracy - &#39;YYYY-MM-DDTHH:MM:SSZ&#39;. | [optional]  |
| **fromSettledDate** | **string** | Returns disputes settled on or after the &#39;from_settled_date&#39;. Date must be in ISO 8601 format to date-level accuracy - &#39;YYYY-MM-DD&#39;. Disputes are settled when your payment service provider takes the disputed amount from a payout to your bank account.You can only use &#39;from_settled_date&#39; to find disputes raised on or after 8 August 2022. | [optional]  |
| **toSettledDate** | **string** | Returns disputes settled before the &#39;to_settled_date&#39;. &#39;Date must be in ISO 8601 format to date-level accuracy - &#39;YYYY-MM-DD&#39;.Disputes are settled when your payment service provider takes the disputed amount from a payout to your bank account. You can only use &#39;to_settled_date&#39; to find disputes raised on or after 8 August 2022. | [optional]  |
| **status** | **string** | Returns disputes with a matching &#39;status&#39;. &#39;status&#39; reflects what stage of the dispute process a dispute is at. | [optional]  |
| **page** | **string** | Returns a specific page of results. Defaults to &#39;1&#39;. | [optional]  |
| **displaySize** | **string** | The number of disputes returned per results page. Defaults to &#39;500&#39;. Maximum value is &#39;500&#39; | [optional]  |

### Return type

[**DisputesSearchResults**](DisputesSearchResults.md)

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
| **422** | Invalid parameters: from_date, to_date, from_settled_date, to_settled_date, status, display_size. See Public API documentation for the correct data formats |  -  |
| **429** | Too many requests |  -  |
| **500** | Downstream system error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

