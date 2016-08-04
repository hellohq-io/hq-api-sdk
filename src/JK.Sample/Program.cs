using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JK.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial configuration
            Configuration.Default = new Configuration(
                baseUrl: "https://yourcompany.hqlabs.de/apiv1",
                username: "hqsb",
                password: "85QAY7edsd7YUUnrrfN6p66eKfDtTaXP2VtYMGTHJAG45nYQ");

            // Access to the companies api
            CompaniesApi companiesApi = new CompaniesApi();
            // Get one company by id
            Company companyById = companiesApi.CompaniesV1GetById(65020);
            Console.WriteLine("Id {0}: {1}", companyById.Id, companyById.Name);

            // Change the company name and update it through the api
            companyById.Name = "Neuer Name";
            companiesApi.CompaniesV1PutById(companyById.Id, companyById);

            UserReportingsApi userReportingsApi = new UserReportingsApi();

            // Various filters on the companies
            //var companies = companiesApi.CompaniesV1Get();
            //var companies = companiesApi.CompaniesV1Get(filter: "Id eq 65020");
            //var companies = companiesApi.CompaniesV1Get(filter: "indexof(Name, 'EU') ge 0");
            var companies = companiesApi.CompaniesV1Get(filter: "UpdatedOn gt 2016-02-15T14:17:40+01:00");
            //var companies = companiesApi.CompaniesV1Get(expand: "CompanyTypes");
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
