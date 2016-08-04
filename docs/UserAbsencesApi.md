# HQ.API.SDK.Api.UserAbsencesApi

All URIs are relative to *https://yourcompany.hqlabs.de/apiv1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserAbsencesV1DeleteById**](UserAbsencesApi.md#userabsencesv1deletebyid) | **DELETE** /api/v1/UserAbsences({Id}) | Deletes an absence
[**UserAbsencesV1Get**](UserAbsencesApi.md#userabsencesv1get) | **GET** /api/v1/UserAbsences | Returns all absences
[**UserAbsencesV1GetById**](UserAbsencesApi.md#userabsencesv1getbyid) | **GET** /api/v1/UserAbsences({Id}) | Returns all absences
[**UserAbsencesV1Post**](UserAbsencesApi.md#userabsencesv1post) | **POST** /api/v1/UserAbsences | Creates a new absence


<a name="userabsencesv1deletebyid"></a>
# **UserAbsencesV1DeleteById**
> Object UserAbsencesV1DeleteById (int? id, string ifMatch = null)

Deletes an absence

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class UserAbsencesV1DeleteByIdExample
    {
        public void main()
        {
            
            var apiInstance = new UserAbsencesApi();
            var id = 56;  // int? | key: Id
            var ifMatch = ifMatch_example;  // string | If-Match header (optional) 

            try
            {
                // Deletes an absence
                Object result = apiInstance.UserAbsencesV1DeleteById(id, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAbsencesApi.UserAbsencesV1DeleteById: " + e.Message );
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

<a name="userabsencesv1get"></a>
# **UserAbsencesV1Get**
> ODataResponseListUserAbsence UserAbsencesV1Get (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null)

Returns all absences

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class UserAbsencesV1GetExample
    {
        public void main()
        {
            
            var apiInstance = new UserAbsencesApi();
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 
            var count = true;  // bool? | Includes a count of the matching results in the response. (optional) 

            try
            {
                // Returns all absences
                ODataResponseListUserAbsence result = apiInstance.UserAbsencesV1Get(expand, filter, select, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAbsencesApi.UserAbsencesV1Get: " + e.Message );
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

[**ODataResponseListUserAbsence**](ODataResponseListUserAbsence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userabsencesv1getbyid"></a>
# **UserAbsencesV1GetById**
> ODataResponseListUserAbsence UserAbsencesV1GetById (int? id, string expand = null, string select = null)

Returns all absences

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class UserAbsencesV1GetByIdExample
    {
        public void main()
        {
            
            var apiInstance = new UserAbsencesApi();
            var id = 56;  // int? | key: Id
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 

            try
            {
                // Returns all absences
                ODataResponseListUserAbsence result = apiInstance.UserAbsencesV1GetById(id, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAbsencesApi.UserAbsencesV1GetById: " + e.Message );
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

[**ODataResponseListUserAbsence**](ODataResponseListUserAbsence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userabsencesv1post"></a>
# **UserAbsencesV1Post**
> Object UserAbsencesV1Post (UserAbsence userAbsence, string expand = null, string select = null)

Creates a new absence

The value for the start and end depends on the type of the absence. Refer to the following table for more details.

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class UserAbsencesV1PostExample
    {
        public void main()
        {
            
            var apiInstance = new UserAbsencesApi();
            var userAbsence = new UserAbsence(); // UserAbsence | The entity to post
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 

            try
            {
                // Creates a new absence
                Object result = apiInstance.UserAbsencesV1Post(userAbsence, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAbsencesApi.UserAbsencesV1Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userAbsence** | [**UserAbsence**](UserAbsence.md)| The entity to post | 
 **expand** | **string**| Expands related entities inline. | [optional] 
 **select** | **string**| Selects which properties to include in the response. | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

