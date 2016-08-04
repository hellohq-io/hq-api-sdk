# HQ.API.SDK.Api.CompanyAddressesApi

All URIs are relative to *https://yourcompany.hqlabs.de/apiv1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompanyAddressesV1Get**](CompanyAddressesApi.md#companyaddressesv1get) | **GET** /api/v1/CompanyAddresses | Returns all company addresses
[**CompanyAddressesV1GetById**](CompanyAddressesApi.md#companyaddressesv1getbyid) | **GET** /api/v1/CompanyAddresses({Id}) | Returns the company address with the specified id


<a name="companyaddressesv1get"></a>
# **CompanyAddressesV1Get**
> ODataResponseListCompanyAddress CompanyAddressesV1Get (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null)

Returns all company addresses

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class CompanyAddressesV1GetExample
    {
        public void main()
        {
            
            var apiInstance = new CompanyAddressesApi();
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 
            var count = true;  // bool? | Includes a count of the matching results in the response. (optional) 

            try
            {
                // Returns all company addresses
                ODataResponseListCompanyAddress result = apiInstance.CompanyAddressesV1Get(expand, filter, select, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyAddressesApi.CompanyAddressesV1Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expand** | **string**| Expands related entities inline. | [optional] 
 **filter** | **string**| Filters the results, based on a Boolean condition. | [optional] 
 **select** | **string**| Selects which properties to include in the response. | [optional] 
 **orderby** | **string**| Sorts the results. | [optional] 
 **top** | **int?**| Returns only the first n results. | [optional] 
 **skip** | **int?**| Skips the first n results. | [optional] 
 **count** | **bool?**| Includes a count of the matching results in the response. | [optional] 

### Return type

[**ODataResponseListCompanyAddress**](ODataResponseListCompanyAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companyaddressesv1getbyid"></a>
# **CompanyAddressesV1GetById**
> CompanyAddress CompanyAddressesV1GetById (int? id, string expand = null, string select = null)

Returns the company address with the specified id

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class CompanyAddressesV1GetByIdExample
    {
        public void main()
        {
            
            var apiInstance = new CompanyAddressesApi();
            var id = 56;  // int? | key: Id
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 

            try
            {
                // Returns the company address with the specified id
                CompanyAddress result = apiInstance.CompanyAddressesV1GetById(id, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyAddressesApi.CompanyAddressesV1GetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| key: Id | 
 **expand** | **string**| Expands related entities inline. | [optional] 
 **select** | **string**| Selects which properties to include in the response. | [optional] 

### Return type

[**CompanyAddress**](CompanyAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

