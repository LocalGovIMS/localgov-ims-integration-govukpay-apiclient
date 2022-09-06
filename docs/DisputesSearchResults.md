# GovUKPayApiClient.Model.DisputesSearchResults

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **int** | Number of disputes on the current page of search results. | [optional] 
**Links** | [**SearchNavigationLinks**](SearchNavigationLinks.md) |  | [optional] 
**Page** | **int** | The page of results you’re viewing. To view other pages, make this request again using the &#39;page&#39; parameter. | [optional] 
**Results** | [**List&lt;DisputeDetailForSearch&gt;**](DisputeDetailForSearch.md) | Contains disputes matching your search criteria. | [optional] 
**Total** | **int** | Number of total disputes matching your search criteria. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

