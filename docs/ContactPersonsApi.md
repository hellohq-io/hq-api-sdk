# HQ.API.SDK.Api.ContactPersonsApi

All URIs are relative to *https://yourcompany.hqlabs.de/apiv1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContactPersonsV1Get**](ContactPersonsApi.md#contactpersonsv1get) | **GET** /api/v1/ContactPersons | Returns all project roles
[**ContactPersonsV1GetById**](ContactPersonsApi.md#contactpersonsv1getbyid) | **GET** /api/v1/ContactPersons({Id}) | Returns the contact person with the specified id


<a name="contactpersonsv1get"></a>
# **ContactPersonsV1Get**
> ODataResponseListContactPerson ContactPersonsV1Get (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null)

Returns all project roles

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class ContactPersonsV1GetExample
    {
        public void main()
        {
            
            var apiInstance = new ContactPersonsApi();
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 
            var count = true;  // bool? | Includes a count of the matching results in the response. (optional) 

            try
            {
                // Returns all project roles
                ODataResponseListContactPerson result = apiInstance.ContactPersonsV1Get(expand, filter, select, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactPersonsApi.ContactPersonsV1Get: " + e.Message );
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

[**ODataResponseListContactPerson**](ODataResponseListContactPerson.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactpersonsv1getbyid"></a>
# **ContactPersonsV1GetById**
> ContactPerson ContactPersonsV1GetById (int? id, string expand = null, string select = null)

Returns the contact person with the specified id

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class ContactPersonsV1GetByIdExample
    {
        public void main()
        {
            
            var apiInstance = new ContactPersonsApi();
            var id = 56;  // int? | key: Id
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 

            try
            {
                // Returns the contact person with the specified id
                ContactPerson result = apiInstance.ContactPersonsV1GetById(id, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactPersonsApi.ContactPersonsV1GetById: " + e.Message );
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

[**ContactPerson**](ContactPerson.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

