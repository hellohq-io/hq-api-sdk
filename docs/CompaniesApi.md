# HQ.API.SDK.Api.CompaniesApi

All URIs are relative to *https://yourcompany.hqlabs.de/apiv1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompaniesV1DeleteById**](CompaniesApi.md#companiesv1deletebyid) | **DELETE** /api/v1/Companies({Id}) | Deletes a company
[**CompaniesV1Get**](CompaniesApi.md#companiesv1get) | **GET** /api/v1/Companies | Returns all companies
[**CompaniesV1GetById**](CompaniesApi.md#companiesv1getbyid) | **GET** /api/v1/Companies({Id}) | Returns the company with the specified id
[**CompaniesV1Post**](CompaniesApi.md#companiesv1post) | **POST** /api/v1/Companies | Creates a new company
[**CompaniesV1PutById**](CompaniesApi.md#companiesv1putbyid) | **PUT** /api/v1/Companies({Id}) | Updates an existing company


<a name="companiesv1deletebyid"></a>
# **CompaniesV1DeleteById**
> Object CompaniesV1DeleteById (int? id, string ifMatch = null)

Deletes a company

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class CompaniesV1DeleteByIdExample
    {
        public void main()
        {
            
            var apiInstance = new CompaniesApi();
            var id = 56;  // int? | key: Id
            var ifMatch = ifMatch_example;  // string | If-Match header (optional) 

            try
            {
                // Deletes a company
                Object result = apiInstance.CompaniesV1DeleteById(id, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesV1DeleteById: " + e.Message );
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

<a name="companiesv1get"></a>
# **CompaniesV1Get**
> List<Company> CompaniesV1Get (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null)

Returns all companies

This list of all companies includes the <a href=\"#!/CompanyTypes/CompanyTypes_Get\">CompanyType</a>.

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class CompaniesV1GetExample
    {
        public void main()
        {
            
            var apiInstance = new CompaniesApi();
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 
            var count = true;  // bool? | Includes a count of the matching results in the response. (optional) 

            try
            {
                // Returns all companies
                List&lt;Company&gt; result = apiInstance.CompaniesV1Get(expand, filter, select, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesV1Get: " + e.Message );
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

[**List<Company>**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesv1getbyid"></a>
# **CompaniesV1GetById**
> Company CompaniesV1GetById (int? id, string expand = null, string select = null)

Returns the company with the specified id

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class CompaniesV1GetByIdExample
    {
        public void main()
        {
            
            var apiInstance = new CompaniesApi();
            var id = 56;  // int? | key: Id
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 

            try
            {
                // Returns the company with the specified id
                Company result = apiInstance.CompaniesV1GetById(id, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesV1GetById: " + e.Message );
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

[**Company**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesv1post"></a>
# **CompaniesV1Post**
> Object CompaniesV1Post (Company company, string expand = null, string select = null)

Creates a new company

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class CompaniesV1PostExample
    {
        public void main()
        {
            
            var apiInstance = new CompaniesApi();
            var company = new Company(); // Company | 
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 

            try
            {
                // Creates a new company
                Object result = apiInstance.CompaniesV1Post(company, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesV1Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | [**Company**](Company.md)|  | 
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

<a name="companiesv1putbyid"></a>
# **CompaniesV1PutById**
> Object CompaniesV1PutById (int? id, Company company, string expand = null, string select = null)

Updates an existing company

### Example
```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class CompaniesV1PutByIdExample
    {
        public void main()
        {
            
            var apiInstance = new CompaniesApi();
            var id = 56;  // int? | key: Id
            var company = new Company(); // Company | 
            var expand = expand_example;  // string | Expands related entities inline. (optional) 
            var select = select_example;  // string | Selects which properties to include in the response. (optional) 

            try
            {
                // Updates an existing company
                Object result = apiInstance.CompaniesV1PutById(id, company, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesV1PutById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| key: Id | 
 **company** | [**Company**](Company.md)|  | 
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

