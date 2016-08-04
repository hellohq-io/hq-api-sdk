using HQSB.API.SDK.Api;
using HQSB.API.SDK.Client;
using HQSB.API.SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQ.API.SDK.Sample
{
    class CustomerSample
    {
        static void Main(string[] args)
        {
            // Initial configuration
            Configuration.Default = new Configuration(
                baseUrl: "https://yourcompany.hqlabs.de/apiv1",
                username: "your-api-user",
                password: "your-api-key");

            // Access to the companies api
            CompaniesApi companiesApi = new CompaniesApi();

            // Get one company by id
            Company companyById = companiesApi.CompaniesV1GetById(56);
            Console.WriteLine("Id {0}: {1}", companyById.Id, companyById.Name);

            // Change the company name and update it through the api
            companyById.Name = "New Name";
            companiesApi.CompaniesV1PutById(companyById.Id, companyById);

            // Create a new company with all details. A company always needs a CompanyType and should have a default address.
            var newCompany = new Company()
            {
                Name = "Unit Corp.",
                DebitorNumber = 3456,
                CreditorNumber = 1234,
                Description = "A test corporation",
                IndustrialSector = "Testing",
                DefaultAddress = new CompanyAddress()
                {
                    Street = "1 Union Drive",
                    City = "SF",
                    Country = "US",
                },
                CompanyTypes = new List<CompanyType>()
                {
                    new CompanyType()
                    {
                        Id = 4002,
                    }
                }
            };

            var newCompanySaved = companiesApi.CompaniesV1Post(newCompany);

            // Delete the company
            var deletedCompany = companiesApi.CompaniesV1DeleteById(newCompanySaved.Id);

            // Various filters on the companies
            //var companies = companiesApi.CompaniesV1Get();
            //var companies = companiesApi.CompaniesV1Get(filter: "Id eq 65020");
            //var companies = companiesApi.CompaniesV1Get(filter: "indexof(Name, 'EU') ge 0");
            //var companies = companiesApi.CompaniesV1Get(filter: "UpdatedOn gt 2016-02-15T14:17:40+01:00");
            var companies = companiesApi.CompaniesV1Get(expand: "CompanyTypes");
            //var companies = companiesApi.CompaniesV1Get(expand: "CompanyTypes", filter:"CompanyTypes/any(companyType: companyType/Name eq 'Kunde')");

            // Print the company results
            var count = 1;
            foreach (var company in companies)
            {
                Console.WriteLine("{0}: {1}", count++, company.Name);

                if (company.CompanyTypes != null)
                {
                    foreach (var companyType in company.CompanyTypes)
                    {
                        Console.WriteLine(" => {0}", companyType.Name);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
