using Authentication;
using Config;
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
            var client = new HQAPIClient(new HQAPIClientConfiguration("https://oauth.hqlabs.de")
            {
                Credentials = new BearerTokenCredentials("j5PNg55onNarKtapRIt1sER2sVGRrkGdUvVlkTDRKwA0FbzmMMxZLEPHsr9lo4ld5rZ_Cz1uCid4ug8RDu-nQPP1Rg2AnOGcNXD1hYrSZl2awznHn8b_dRICc6eRuZYdCcUOfxFB0GgGHqFnKIjkpW5WvAHqi39wHu7EUPwOilQqjwWmCpkrdjGjQUnF8Q-YY_6q9XztVMRoOfBSxnwGAiDT6CIIhY9I8LQ35Pfuc7tnp3T92JbGRmrfcocrSkGIwpVZcqehvs56CypEI2H_UwzMJIEaHAmq18riHNdyckj2pd9L")
            });

            // Get one company by id
            Company companyById = client.CompaniesV1_GetByIdAsync(61011).Result;
            Console.WriteLine("Id {0}: {1}", companyById.Id, companyById.Name);

            // Change the company name and update it through the api
            companyById.Name = companyById.Name + " (API)";
            var changedCompany = client.CompaniesV1_PutByIdAsync(companyById.Id, companyById).Result;
            
            var customerCompanyType = client.CompanyTypesV1_GetAsync(filter: "Name eq 'Kunde'").Result.FirstOrDefault();

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
                    Street = "Am Kaiserkai 70",
                    City = "Hamburg",
                    Country = "DE",
                },
                CompanyTypes = new System.Collections.ObjectModel.ObservableCollection<CompanyTypeOfCompany>()
                {
                    new CompanyTypeOfCompany()
                    {
                        Id = customerCompanyType.Id,
                    }
                }
            };

            var newCompanySaved = client.CompaniesV1_PostAsync(newCompany).Result;

            // Delete the company
            var deletedCompany = client.CompaniesV1_DeleteByIdAsync(newCompanySaved.Id).Result;

            // Various filters on the companies
            //var companies = client.CompaniesV1_GetAsync().Result;
            //var companies = client.CompaniesV1_GetAsync(filter: "Id eq 65020").Result;
            //var companies = client.CompaniesV1_GetAsync(filter: "indexof(Name, 'EU') ge 0").Result;
            //var companies = client.CompaniesV1_GetAsync(filter: "UpdatedOn gt 2016-02-15T14:17:40+01:00").Result;
            var companies = client.CompaniesV1_GetAsync(expand: "CompanyTypes").Result;
            //var companies = client.CompaniesV1_GetAsync(expand: "CompanyTypes", filter: "CompanyTypes/any(companyType: companyType/Name eq 'Kunde')").Result;

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
