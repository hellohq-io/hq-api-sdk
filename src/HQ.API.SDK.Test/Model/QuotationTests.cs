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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HQSB.API.SDK.Api;
using HQSB.API.SDK.Model;
using HQSB.API.SDK.Client;
using System.Reflection;

namespace HQSB.API.SDK.Test
{
    /// <summary>
    ///  Class for testing Quotation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class QuotationTests
    {
        // TODO uncomment below to declare an instance variable for Quotation
        //private Quotation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Quotation
            //instance = new Quotation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Quotation
        /// </summary>
        [Test]
        public void QuotationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Quotation
            //Assert.IsInstanceOfType<Quotation> (instance, "variable 'instance' is a Quotation");
        }

        /// <summary>
        /// Test the property 'QuotationDate'
        /// </summary>
        [Test]
        public void QuotationDateTest()
        {
            // TODO unit test for the property 'QuotationDate'
        }
        /// <summary>
        /// Test the property 'ValidUntilDate'
        /// </summary>
        [Test]
        public void ValidUntilDateTest()
        {
            // TODO unit test for the property 'ValidUntilDate'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Positions'
        /// </summary>
        [Test]
        public void PositionsTest()
        {
            // TODO unit test for the property 'Positions'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'ExchangeRate'
        /// </summary>
        [Test]
        public void ExchangeRateTest()
        {
            // TODO unit test for the property 'ExchangeRate'
        }
        /// <summary>
        /// Test the property 'DeliveryDate'
        /// </summary>
        [Test]
        public void DeliveryDateTest()
        {
            // TODO unit test for the property 'DeliveryDate'
        }
        /// <summary>
        /// Test the property 'PaymentConditionId'
        /// </summary>
        [Test]
        public void PaymentConditionIdTest()
        {
            // TODO unit test for the property 'PaymentConditionId'
        }
        /// <summary>
        /// Test the property 'DeliveryConditionId'
        /// </summary>
        [Test]
        public void DeliveryConditionIdTest()
        {
            // TODO unit test for the property 'DeliveryConditionId'
        }
        /// <summary>
        /// Test the property 'PaymentCondition'
        /// </summary>
        [Test]
        public void PaymentConditionTest()
        {
            // TODO unit test for the property 'PaymentCondition'
        }
        /// <summary>
        /// Test the property 'DeliveryCondition'
        /// </summary>
        [Test]
        public void DeliveryConditionTest()
        {
            // TODO unit test for the property 'DeliveryCondition'
        }
        /// <summary>
        /// Test the property 'DiscountType'
        /// </summary>
        [Test]
        public void DiscountTypeTest()
        {
            // TODO unit test for the property 'DiscountType'
        }
        /// <summary>
        /// Test the property 'Discount'
        /// </summary>
        [Test]
        public void DiscountTest()
        {
            // TODO unit test for the property 'Discount'
        }
        /// <summary>
        /// Test the property 'Margin'
        /// </summary>
        [Test]
        public void MarginTest()
        {
            // TODO unit test for the property 'Margin'
        }
        /// <summary>
        /// Test the property 'TaxOption'
        /// </summary>
        [Test]
        public void TaxOptionTest()
        {
            // TODO unit test for the property 'TaxOption'
        }
        /// <summary>
        /// Test the property 'ServiceOption'
        /// </summary>
        [Test]
        public void ServiceOptionTest()
        {
            // TODO unit test for the property 'ServiceOption'
        }
        /// <summary>
        /// Test the property 'NetTotal'
        /// </summary>
        [Test]
        public void NetTotalTest()
        {
            // TODO unit test for the property 'NetTotal'
        }
        /// <summary>
        /// Test the property 'GrossTotal'
        /// </summary>
        [Test]
        public void GrossTotalTest()
        {
            // TODO unit test for the property 'GrossTotal'
        }
        /// <summary>
        /// Test the property 'VatTotal'
        /// </summary>
        [Test]
        public void VatTotalTest()
        {
            // TODO unit test for the property 'VatTotal'
        }
        /// <summary>
        /// Test the property 'PaidTotal'
        /// </summary>
        [Test]
        public void PaidTotalTest()
        {
            // TODO unit test for the property 'PaidTotal'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'TypeText'
        /// </summary>
        [Test]
        public void TypeTextTest()
        {
            // TODO unit test for the property 'TypeText'
        }
        /// <summary>
        /// Test the property 'AddressText'
        /// </summary>
        [Test]
        public void AddressTextTest()
        {
            // TODO unit test for the property 'AddressText'
        }
        /// <summary>
        /// Test the property 'CompanyAddressId'
        /// </summary>
        [Test]
        public void CompanyAddressIdTest()
        {
            // TODO unit test for the property 'CompanyAddressId'
        }
        /// <summary>
        /// Test the property 'CompanyAddress'
        /// </summary>
        [Test]
        public void CompanyAddressTest()
        {
            // TODO unit test for the property 'CompanyAddress'
        }
        /// <summary>
        /// Test the property 'Subject'
        /// </summary>
        [Test]
        public void SubjectTest()
        {
            // TODO unit test for the property 'Subject'
        }
        /// <summary>
        /// Test the property 'Header'
        /// </summary>
        [Test]
        public void HeaderTest()
        {
            // TODO unit test for the property 'Header'
        }
        /// <summary>
        /// Test the property 'Footer'
        /// </summary>
        [Test]
        public void FooterTest()
        {
            // TODO unit test for the property 'Footer'
        }
        /// <summary>
        /// Test the property 'DocumentTemplateId'
        /// </summary>
        [Test]
        public void DocumentTemplateIdTest()
        {
            // TODO unit test for the property 'DocumentTemplateId'
        }
        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Test]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'ContactPersonId'
        /// </summary>
        [Test]
        public void ContactPersonIdTest()
        {
            // TODO unit test for the property 'ContactPersonId'
        }
        /// <summary>
        /// Test the property 'ContactPerson'
        /// </summary>
        [Test]
        public void ContactPersonTest()
        {
            // TODO unit test for the property 'ContactPerson'
        }
        /// <summary>
        /// Test the property 'CompanyId'
        /// </summary>
        [Test]
        public void CompanyIdTest()
        {
            // TODO unit test for the property 'CompanyId'
        }
        /// <summary>
        /// Test the property 'Company'
        /// </summary>
        [Test]
        public void CompanyTest()
        {
            // TODO unit test for the property 'Company'
        }
        /// <summary>
        /// Test the property 'InternalContactPersonId'
        /// </summary>
        [Test]
        public void InternalContactPersonIdTest()
        {
            // TODO unit test for the property 'InternalContactPersonId'
        }
        /// <summary>
        /// Test the property 'InternalContactPerson'
        /// </summary>
        [Test]
        public void InternalContactPersonTest()
        {
            // TODO unit test for the property 'InternalContactPerson'
        }
        /// <summary>
        /// Test the property 'LeadId'
        /// </summary>
        [Test]
        public void LeadIdTest()
        {
            // TODO unit test for the property 'LeadId'
        }
        /// <summary>
        /// Test the property 'Lead'
        /// </summary>
        [Test]
        public void LeadTest()
        {
            // TODO unit test for the property 'Lead'
        }
        /// <summary>
        /// Test the property 'SyncId'
        /// </summary>
        [Test]
        public void SyncIdTest()
        {
            // TODO unit test for the property 'SyncId'
        }
        /// <summary>
        /// Test the property 'ProjectId'
        /// </summary>
        [Test]
        public void ProjectIdTest()
        {
            // TODO unit test for the property 'ProjectId'
        }
        /// <summary>
        /// Test the property 'Project'
        /// </summary>
        [Test]
        public void ProjectTest()
        {
            // TODO unit test for the property 'Project'
        }
        /// <summary>
        /// Test the property 'Note'
        /// </summary>
        [Test]
        public void NoteTest()
        {
            // TODO unit test for the property 'Note'
        }
        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Test]
        public void LanguageTest()
        {
            // TODO unit test for the property 'Language'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Test]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
        }
        /// <summary>
        /// Test the property 'UpdatedBy'
        /// </summary>
        [Test]
        public void UpdatedByTest()
        {
            // TODO unit test for the property 'UpdatedBy'
        }
        /// <summary>
        /// Test the property 'CreatedOn'
        /// </summary>
        [Test]
        public void CreatedOnTest()
        {
            // TODO unit test for the property 'CreatedOn'
        }
        /// <summary>
        /// Test the property 'UpdatedOn'
        /// </summary>
        [Test]
        public void UpdatedOnTest()
        {
            // TODO unit test for the property 'UpdatedOn'
        }

    }

}
