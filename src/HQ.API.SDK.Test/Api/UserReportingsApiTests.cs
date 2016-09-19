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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using HQSB.API.SDK.Client;
using HQSB.API.SDK.Api;
using HQSB.API.SDK.Model;

namespace HQSB.API.SDK.Test
{
    /// <summary>
    ///  Class for testing UserReportingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserReportingsApiTests
    {
        private UserReportingsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserReportingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserReportingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' UserReportingsApi
            Assert.IsInstanceOf<UserReportingsApi>(instance, "instance is a UserReportingsApi");
        }

        
        /// <summary>
        /// Test UserReportingsV1DeleteById
        /// </summary>
        [Test]
        public void UserReportingsV1DeleteByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string ifMatch = null;
            //var response = instance.UserReportingsV1DeleteById(id, ifMatch);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test UserReportingsV1Get
        /// </summary>
        [Test]
        public void UserReportingsV1GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string expand = null;
            //string filter = null;
            //string select = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.UserReportingsV1Get(expand, filter, select, orderby, top, skip, count);
            //Assert.IsInstanceOf<ODataResponseListUserReporting> (response, "response is ODataResponseListUserReporting");
        }
        
        /// <summary>
        /// Test UserReportingsV1GetById
        /// </summary>
        [Test]
        public void UserReportingsV1GetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string expand = null;
            //string select = null;
            //var response = instance.UserReportingsV1GetById(id, expand, select);
            //Assert.IsInstanceOf<ODataResponseListUserReporting> (response, "response is ODataResponseListUserReporting");
        }
        
    }

}
