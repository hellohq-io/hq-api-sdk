# HQ.API.SDK.Api.CustomFieldDefinitionsApi

All URIs are relative to *https://yourcompany.hqlabs.de/apiv1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomFieldDefinitionsV1Get**](CustomFieldDefinitionsApi.md#customfielddefinitionsv1get) | **GET** /api/v1/CustomFieldDefinitions | Returns all customfield definitions
[**CustomFieldDefinitionsV1GetById**](CustomFieldDefinitionsApi.md#customfielddefinitionsv1getbyid) | **GET** /api/v1/CustomFieldDefinitions({Id}) | Returns the custom field definition with the specified id


<a name="customfielddefinitionsv1get"></a>
# **CustomFieldDefinitionsV1Get**
> ODataResponseListCustomFieldDefinition CustomFieldDefinitionsV1Get (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null)

Returns all customfield definitions

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class CustomFieldDefinitionsV1GetExample
    {
        public void main()
        {
            
            var apiInstance = new CustomFieldDefinitionsApi();
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 
            var count = true;  // bool? | Includes a count of the matching results in the response. (optional) 

            try
            {
                // Returns all customfield definitions
                ODataResponseListCustomFieldDefinition result = apiInstance.CustomFieldDefinitionsV1Get(expand, filter, select, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldDefinitionsApi.CustomFieldDefinitionsV1Get: " + e.Message );
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

[**ODataResponseListCustomFieldDefinition**](ODataResponseListCustomFieldDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customfielddefinitionsv1getbyid"></a>
# **CustomFieldDefinitionsV1GetById**
> CustomFieldDefinition CustomFieldDefinitionsV1GetById (int? id, string expand = null, string select = null)

Returns the custom field definition with the specified id

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class CustomFieldDefinitionsV1GetByIdExample
    {
        public void main()
        {
            
            var apiInstance = new CustomFieldDefinitionsApi();
            var id = 56;  // int? | key: Id
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 

            try
            {
                // Returns the custom field definition with the specified id
                CustomFieldDefinition result = apiInstance.CustomFieldDefinitionsV1GetById(id, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldDefinitionsApi.CustomFieldDefinitionsV1GetById: " + e.Message );
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

[**CustomFieldDefinition**](CustomFieldDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

