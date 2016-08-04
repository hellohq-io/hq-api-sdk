# HQ.API.SDK.Api.UserReportingsApi

All URIs are relative to *https://yourcompany.hqlabs.de/apiv1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserReportingsV1DeleteById**](UserReportingsApi.md#userreportingsv1deletebyid) | **DELETE** /api/v1/UserReportings({Id}) | Deletes a user reporting
[**UserReportingsV1Get**](UserReportingsApi.md#userreportingsv1get) | **GET** /api/v1/UserReportings | Returns all user reportings
[**UserReportingsV1GetById**](UserReportingsApi.md#userreportingsv1getbyid) | **GET** /api/v1/UserReportings({Id}) | Returns all user reportings


<a name="userreportingsv1deletebyid"></a>
# **UserReportingsV1DeleteById**
> Object UserReportingsV1DeleteById (int? id, string ifMatch = null)

Deletes a user reporting

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class UserReportingsV1DeleteByIdExample
    {
        public void main()
        {
            
            var apiInstance = new UserReportingsApi();
            var id = 56;  // int? | key: Id
            var ifMatch = ifMatch_example;  // string | If-Match header (optional) 

            try
            {
                // Deletes a user reporting
                Object result = apiInstance.UserReportingsV1DeleteById(id, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserReportingsApi.UserReportingsV1DeleteById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| key: Id | 
 **ifMatch** | **string**| If-Match header | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userreportingsv1get"></a>
# **UserReportingsV1Get**
> ODataResponseListUserReporting UserReportingsV1Get (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null)

Returns all user reportings

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class UserReportingsV1GetExample
    {
        public void main()
        {
            
            var apiInstance = new UserReportingsApi();
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 
            var count = true;  // bool? | Includes a count of the matching results in the response. (optional) 

            try
            {
                // Returns all user reportings
                ODataResponseListUserReporting result = apiInstance.UserReportingsV1Get(expand, filter, select, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserReportingsApi.UserReportingsV1Get: " + e.Message );
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

[**ODataResponseListUserReporting**](ODataResponseListUserReporting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userreportingsv1getbyid"></a>
# **UserReportingsV1GetById**
> ODataResponseListUserReporting UserReportingsV1GetById (int? id, string expand = null, string select = null)

Returns all user reportings

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class UserReportingsV1GetByIdExample
    {
        public void main()
        {
            
            var apiInstance = new UserReportingsApi();
            var id = 56;  // int? | key: Id
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 

            try
            {
                // Returns all user reportings
                ODataResponseListUserReporting result = apiInstance.UserReportingsV1GetById(id, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserReportingsApi.UserReportingsV1GetById: " + e.Message );
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

[**ODataResponseListUserReporting**](ODataResponseListUserReporting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
