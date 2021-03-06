﻿using Authentication;
using Config;
using System;

namespace HQ.API.SDK.Sample
{
    public class CompanyAPISample
    {
        public void CompanyAPI (HQAPIClient client)
        {
            // Get a company by id
            var companyById = client.CompaniesV1_GetByIdAsync(1).Result;
            Console.WriteLine("Company by Id: " + companyById.Name);

            // Modify the company name and save it using a PUT
            companyById.Name = companyById.Name + " (API)";
            companyById.DefaultAddress.Country = "DE";
            companyById = client.CompaniesV1_PutByIdAsync(companyById.Id, companyById).Result;

            // Create a new company with a default address and a company type
            var newCompany = new Company()
            {
                Name = "Unit Corp.",
                CreditorNumber = 1234,
                DebitorNumber = 3456,
                Description = "A test corporation",
                IndustrialSector = "Testing",
                DefaultAddress = new CompanyAddress()
                {
                    Street = "Am Kaiserkai 70",
                    City = "Hamburg",
                    Country = "DE",
                    DefaultForDocumentType = CompanyAddressDefaultForDocumentType.Invoice,
                },
                CompanyTypes = new System.Collections.ObjectModel.ObservableCollection<CompanyTypeOfCompany>()
                {
                    new CompanyTypeOfCompany()
                    {
                        Id = 4002, // Here, 4002 is the Id of type 'Customer'
                    }
                }
            };

            // POST the new company to create it
            var newCompanyResult = client.CompaniesV1_PostAsync(newCompany).Result;
            Console.WriteLine("New Company Id: " + newCompanyResult.Id);

            // Delete the new company
            var deletedCompany = client.CompaniesV1_DeleteByIdAsync(newCompanyResult.Id).Result;

            // Various filter and expand examples. See the OData docs for more information
            var companies = client.CompaniesV1_GetAsync().Result; // Get all companies
            //var companies = client.CompaniesV1_GetAsync(filter: "Id eq 65020").Result; // Get a company with a filter by Id
            //var companies = client.CompaniesV1_GetAsync(filter: "indexof(Name, 'Corp') ge 0").Result; // Get all companies where the name contains 'Corp'
            //var companies = client.CompaniesV1_GetAsync(filter: "UpdatedOn gt 2016-02-15T14:17:40+01:00").Result; // Get all companies modified after 15th of February 2016
            //var companies = client.CompaniesV1_GetAsync(expand: "CompanyTypes").Result; // Get all companies with their company types
            //var companies = client.CompaniesV1_GetAsync(expand: "CompanyTypes", filter: "CompanyTypes/any(companyType: companyType/Name eq 'Customer')").Result; // Returns all companies of type 'Customer'

            // Display the results
            foreach (var item in companies)
            {
                Console.WriteLine(item.Id + ": " + item.Name);
                if (item.CompanyTypes != null)
                {
                    foreach (var companyType in item.CompanyTypes)
                    {
                        Console.WriteLine("    " + companyType.Name);
                    }
                }
            }

            // Wait to show the results
            Console.ReadLine();
        }
    }
}
