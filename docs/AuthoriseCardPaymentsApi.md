# GovUKPayApiClient.Api.AuthoriseCardPaymentsApi

All URIs are relative to *https://publicapi.payments.service.gov.uk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthoriseAMOTOPayment**](AuthoriseCardPaymentsApi.md#authoriseamotopayment) | **POST** /v1/auth | Authorise a MOTO payment |

<a name="authoriseamotopayment"></a>
# **AuthoriseAMOTOPayment**
> void AuthoriseAMOTOPayment (AuthorisationRequest authorisationRequest)

Authorise a MOTO payment

Authorise a payment that was created with `authorisation_mode` set to `moto_api`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GovUKPayApiClient.Api;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace Example
{
    public class AuthoriseAMOTOPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://publicapi.payments.service.gov.uk";
            var apiInstance = new AuthoriseCardPaymentsApi(config);
            var authorisationRequest = new AuthorisationRequest(); // AuthorisationRequest | 

            try
            {
                // Authorise a MOTO payment
                apiInstance.AuthoriseAMOTOPayment(authorisationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthoriseCardPaymentsApi.AuthoriseAMOTOPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthoriseAMOTOPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authorise a MOTO payment
    apiInstance.AuthoriseAMOTOPaymentWithHttpInfo(authorisationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthoriseCardPaymentsApi.AuthoriseAMOTOPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorisationRequest** | [**AuthorisationRequest**](AuthorisationRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Your authorisation request was successful. |  -  |
| **400** | Your request is invalid. Check the &#x60;code&#x60; and &#x60;description&#x60; in the response to find out why your request failed. |  -  |
| **402** | The &#x60;card_number&#x60; you sent is not a valid card number or you chose not to accept this card type. Check the &#x60;code&#x60; and &#x60;description&#x60; fields in the response to find out why your request failed. |  -  |
| **422** | A value you sent is invalid or missing. Check the &#x60;code&#x60; and &#x60;description&#x60; in the response to find out why your request failed. |  -  |
| **500** | There is something wrong with GOV.UK Pay. If there are no issues on our status page (https://payments.statuspage.io), you can contact us with your error code and we&#39;ll investigate. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

