/* 
 * HQ API Entities
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using HQSB.API.SDK.Client;
using HQSB.API.SDK.Model;

namespace HQSB.API.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProjectTemplatesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns all project templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="filter">Filters the results, based on a Boolean condition. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <param name="orderby">Sorts the results. (optional)</param>
        /// <param name="top">Returns only the first n results. (optional)</param>
        /// <param name="skip">Skips the first n results. (optional)</param>
        /// <param name="count">Includes a count of the matching results in the response. (optional)</param>
        /// <returns>ODataResponseListProjectTemplate</returns>
        ODataResponseListProjectTemplate ProjectTemplatesV1Get (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null);

        /// <summary>
        /// Returns all project templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="filter">Filters the results, based on a Boolean condition. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <param name="orderby">Sorts the results. (optional)</param>
        /// <param name="top">Returns only the first n results. (optional)</param>
        /// <param name="skip">Skips the first n results. (optional)</param>
        /// <param name="count">Includes a count of the matching results in the response. (optional)</param>
        /// <returns>ApiResponse of ODataResponseListProjectTemplate</returns>
        ApiResponse<ODataResponseListProjectTemplate> ProjectTemplatesV1GetWithHttpInfo (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null);
        /// <summary>
        /// Returns all project templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">key: Id</param>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <returns>ODataResponseListProjectTemplate</returns>
        ODataResponseListProjectTemplate ProjectTemplatesV1GetById (int? id, string expand = null, string select = null);

        /// <summary>
        /// Returns all project templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">key: Id</param>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <returns>ApiResponse of ODataResponseListProjectTemplate</returns>
        ApiResponse<ODataResponseListProjectTemplate> ProjectTemplatesV1GetByIdWithHttpInfo (int? id, string expand = null, string select = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns all project templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="filter">Filters the results, based on a Boolean condition. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <param name="orderby">Sorts the results. (optional)</param>
        /// <param name="top">Returns only the first n results. (optional)</param>
        /// <param name="skip">Skips the first n results. (optional)</param>
        /// <param name="count">Includes a count of the matching results in the response. (optional)</param>
        /// <returns>Task of ODataResponseListProjectTemplate</returns>
        System.Threading.Tasks.Task<ODataResponseListProjectTemplate> ProjectTemplatesV1GetAsync (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null);

        /// <summary>
        /// Returns all project templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="filter">Filters the results, based on a Boolean condition. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <param name="orderby">Sorts the results. (optional)</param>
        /// <param name="top">Returns only the first n results. (optional)</param>
        /// <param name="skip">Skips the first n results. (optional)</param>
        /// <param name="count">Includes a count of the matching results in the response. (optional)</param>
        /// <returns>Task of ApiResponse (ODataResponseListProjectTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ODataResponseListProjectTemplate>> ProjectTemplatesV1GetAsyncWithHttpInfo (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null);
        /// <summary>
        /// Returns all project templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">key: Id</param>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <returns>Task of ODataResponseListProjectTemplate</returns>
        System.Threading.Tasks.Task<ODataResponseListProjectTemplate> ProjectTemplatesV1GetByIdAsync (int? id, string expand = null, string select = null);

        /// <summary>
        /// Returns all project templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">key: Id</param>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <returns>Task of ApiResponse (ODataResponseListProjectTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ODataResponseListProjectTemplate>> ProjectTemplatesV1GetByIdAsyncWithHttpInfo (int? id, string expand = null, string select = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProjectTemplatesApi : IProjectTemplatesApi
    {
        private HQSB.API.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProjectTemplatesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = HQSB.API.SDK.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProjectTemplatesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = HQSB.API.SDK.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public HQSB.API.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns all project templates 
        /// </summary>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="filter">Filters the results, based on a Boolean condition. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <param name="orderby">Sorts the results. (optional)</param>
        /// <param name="top">Returns only the first n results. (optional)</param>
        /// <param name="skip">Skips the first n results. (optional)</param>
        /// <param name="count">Includes a count of the matching results in the response. (optional)</param>
        /// <returns>ODataResponseListProjectTemplate</returns>
        public ODataResponseListProjectTemplate ProjectTemplatesV1Get (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null)
        {
             ApiResponse<ODataResponseListProjectTemplate> localVarResponse = ProjectTemplatesV1GetWithHttpInfo(expand, filter, select, orderby, top, skip, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns all project templates 
        /// </summary>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="filter">Filters the results, based on a Boolean condition. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <param name="orderby">Sorts the results. (optional)</param>
        /// <param name="top">Returns only the first n results. (optional)</param>
        /// <param name="skip">Skips the first n results. (optional)</param>
        /// <param name="count">Includes a count of the matching results in the response. (optional)</param>
        /// <returns>ApiResponse of ODataResponseListProjectTemplate</returns>
        public ApiResponse< ODataResponseListProjectTemplate > ProjectTemplatesV1GetWithHttpInfo (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null)
        {

            var localVarPath = "/api/v1/ProjectTemplates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (expand != null) localVarQueryParams.Add("$expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) localVarQueryParams.Add("$filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (select != null) localVarQueryParams.Add("$select", Configuration.ApiClient.ParameterToString(select)); // query parameter
            if (orderby != null) localVarQueryParams.Add("$orderby", Configuration.ApiClient.ParameterToString(orderby)); // query parameter
            if (top != null) localVarQueryParams.Add("$top", Configuration.ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) localVarQueryParams.Add("$skip", Configuration.ApiClient.ParameterToString(skip)); // query parameter
            if (count != null) localVarQueryParams.Add("$count", Configuration.ApiClient.ParameterToString(count)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProjectTemplatesV1Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ODataResponseListProjectTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ODataResponseListProjectTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ODataResponseListProjectTemplate)));
            
        }

        /// <summary>
        /// Returns all project templates 
        /// </summary>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="filter">Filters the results, based on a Boolean condition. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <param name="orderby">Sorts the results. (optional)</param>
        /// <param name="top">Returns only the first n results. (optional)</param>
        /// <param name="skip">Skips the first n results. (optional)</param>
        /// <param name="count">Includes a count of the matching results in the response. (optional)</param>
        /// <returns>Task of ODataResponseListProjectTemplate</returns>
        public async System.Threading.Tasks.Task<ODataResponseListProjectTemplate> ProjectTemplatesV1GetAsync (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null)
        {
             ApiResponse<ODataResponseListProjectTemplate> localVarResponse = await ProjectTemplatesV1GetAsyncWithHttpInfo(expand, filter, select, orderby, top, skip, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns all project templates 
        /// </summary>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="filter">Filters the results, based on a Boolean condition. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <param name="orderby">Sorts the results. (optional)</param>
        /// <param name="top">Returns only the first n results. (optional)</param>
        /// <param name="skip">Skips the first n results. (optional)</param>
        /// <param name="count">Includes a count of the matching results in the response. (optional)</param>
        /// <returns>Task of ApiResponse (ODataResponseListProjectTemplate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ODataResponseListProjectTemplate>> ProjectTemplatesV1GetAsyncWithHttpInfo (string expand = null, string filter = null, string select = null, string orderby = null, int? top = null, int? skip = null, bool? count = null)
        {

            var localVarPath = "/api/v1/ProjectTemplates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (expand != null) localVarQueryParams.Add("$expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) localVarQueryParams.Add("$filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (select != null) localVarQueryParams.Add("$select", Configuration.ApiClient.ParameterToString(select)); // query parameter
            if (orderby != null) localVarQueryParams.Add("$orderby", Configuration.ApiClient.ParameterToString(orderby)); // query parameter
            if (top != null) localVarQueryParams.Add("$top", Configuration.ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) localVarQueryParams.Add("$skip", Configuration.ApiClient.ParameterToString(skip)); // query parameter
            if (count != null) localVarQueryParams.Add("$count", Configuration.ApiClient.ParameterToString(count)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProjectTemplatesV1Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ODataResponseListProjectTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ODataResponseListProjectTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ODataResponseListProjectTemplate)));
            
        }

        /// <summary>
        /// Returns all project templates 
        /// </summary>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">key: Id</param>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <returns>ODataResponseListProjectTemplate</returns>
        public ODataResponseListProjectTemplate ProjectTemplatesV1GetById (int? id, string expand = null, string select = null)
        {
             ApiResponse<ODataResponseListProjectTemplate> localVarResponse = ProjectTemplatesV1GetByIdWithHttpInfo(id, expand, select);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns all project templates 
        /// </summary>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">key: Id</param>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <returns>ApiResponse of ODataResponseListProjectTemplate</returns>
        public ApiResponse< ODataResponseListProjectTemplate > ProjectTemplatesV1GetByIdWithHttpInfo (int? id, string expand = null, string select = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProjectTemplatesApi->ProjectTemplatesV1GetById");

            var localVarPath = "/api/v1/ProjectTemplates({Id})";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("Id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (expand != null) localVarQueryParams.Add("$expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (select != null) localVarQueryParams.Add("$select", Configuration.ApiClient.ParameterToString(select)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProjectTemplatesV1GetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ODataResponseListProjectTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ODataResponseListProjectTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ODataResponseListProjectTemplate)));
            
        }

        /// <summary>
        /// Returns all project templates 
        /// </summary>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">key: Id</param>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <returns>Task of ODataResponseListProjectTemplate</returns>
        public async System.Threading.Tasks.Task<ODataResponseListProjectTemplate> ProjectTemplatesV1GetByIdAsync (int? id, string expand = null, string select = null)
        {
             ApiResponse<ODataResponseListProjectTemplate> localVarResponse = await ProjectTemplatesV1GetByIdAsyncWithHttpInfo(id, expand, select);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns all project templates 
        /// </summary>
        /// <exception cref="HQSB.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">key: Id</param>
        /// <param name="expand">Expands related entities inline. (optional)</param>
        /// <param name="select">Selects which properties to include in the response. (optional)</param>
        /// <returns>Task of ApiResponse (ODataResponseListProjectTemplate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ODataResponseListProjectTemplate>> ProjectTemplatesV1GetByIdAsyncWithHttpInfo (int? id, string expand = null, string select = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProjectTemplatesApi->ProjectTemplatesV1GetById");

            var localVarPath = "/api/v1/ProjectTemplates({Id})";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("Id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (expand != null) localVarQueryParams.Add("$expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (select != null) localVarQueryParams.Add("$select", Configuration.ApiClient.ParameterToString(select)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProjectTemplatesV1GetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ODataResponseListProjectTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ODataResponseListProjectTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ODataResponseListProjectTemplate)));
            
        }

    }
}
