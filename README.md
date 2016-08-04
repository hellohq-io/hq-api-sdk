# HQ API SDK - the C# library for the HQ API Entities


This C# SDK allows convenient access to the HQ API (Preview).

- API version: v1
- SDK version: 1.0.0

## Frameworks supported
- .NET 4.0 or later

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 8.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using HQ.API.SDK.Api;
using HQ.API.SDK.Client;
using HQ.API.SDK.Model;

namespace Example
{
    public class Example
    {
        public void main()
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
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://yourcompany.hqlabs.de/apiv1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CompaniesApi* | [**CompaniesV1DeleteById**](docs/CompaniesApi.md#companiesv1deletebyid) | **DELETE** /api/v1/Companies({Id}) | Deletes a company
*CompaniesApi* | [**CompaniesV1Get**](docs/CompaniesApi.md#companiesv1get) | **GET** /api/v1/Companies | Returns all companies
*CompaniesApi* | [**CompaniesV1GetById**](docs/CompaniesApi.md#companiesv1getbyid) | **GET** /api/v1/Companies({Id}) | Returns the company with the specified id
*CompaniesApi* | [**CompaniesV1Post**](docs/CompaniesApi.md#companiesv1post) | **POST** /api/v1/Companies | Creates a new company
*CompaniesApi* | [**CompaniesV1PutById**](docs/CompaniesApi.md#companiesv1putbyid) | **PUT** /api/v1/Companies({Id}) | Updates an existing company
*CompanyAddressesApi* | [**CompanyAddressesV1Get**](docs/CompanyAddressesApi.md#companyaddressesv1get) | **GET** /api/v1/CompanyAddresses | Returns all company addresses
*CompanyAddressesApi* | [**CompanyAddressesV1GetById**](docs/CompanyAddressesApi.md#companyaddressesv1getbyid) | **GET** /api/v1/CompanyAddresses({Id}) | Returns the company address with the specified id
*CompanyTypesApi* | [**CompanyTypesV1Get**](docs/CompanyTypesApi.md#companytypesv1get) | **GET** /api/v1/CompanyTypes | Returns all company types
*CompanyTypesApi* | [**CompanyTypesV1GetById**](docs/CompanyTypesApi.md#companytypesv1getbyid) | **GET** /api/v1/CompanyTypes({Id}) | Returns the company type with the specified id
*ContactPersonsApi* | [**ContactPersonsV1Get**](docs/ContactPersonsApi.md#contactpersonsv1get) | **GET** /api/v1/ContactPersons | Returns all project roles
*ContactPersonsApi* | [**ContactPersonsV1GetById**](docs/ContactPersonsApi.md#contactpersonsv1getbyid) | **GET** /api/v1/ContactPersons({Id}) | Returns the contact person with the specified id
*CustomFieldDefinitionsApi* | [**CustomFieldDefinitionsV1Get**](docs/CustomFieldDefinitionsApi.md#customfielddefinitionsv1get) | **GET** /api/v1/CustomFieldDefinitions | Returns all customfield definitions
*CustomFieldDefinitionsApi* | [**CustomFieldDefinitionsV1GetById**](docs/CustomFieldDefinitionsApi.md#customfielddefinitionsv1getbyid) | **GET** /api/v1/CustomFieldDefinitions({Id}) | Returns the custom field definition with the specified id
*ProjectRolesApi* | [**ProjectRolesV1Get**](docs/ProjectRolesApi.md#projectrolesv1get) | **GET** /api/v1/ProjectRoles | Returns all project roles
*ProjectRolesApi* | [**ProjectRolesV1GetById**](docs/ProjectRolesApi.md#projectrolesv1getbyid) | **GET** /api/v1/ProjectRoles({Id}) | Returns all project roles
*ProjectStatusApi* | [**ProjectStatusV1Get**](docs/ProjectStatusApi.md#projectstatusv1get) | **GET** /api/v1/ProjectStatus | Returns all project status
*ProjectStatusApi* | [**ProjectStatusV1GetById**](docs/ProjectStatusApi.md#projectstatusv1getbyid) | **GET** /api/v1/ProjectStatus({Id}) | Returns all project status
*ProjectTemplatesApi* | [**ProjectTemplatesV1Get**](docs/ProjectTemplatesApi.md#projecttemplatesv1get) | **GET** /api/v1/ProjectTemplates | Returns all project templates
*ProjectTemplatesApi* | [**ProjectTemplatesV1GetById**](docs/ProjectTemplatesApi.md#projecttemplatesv1getbyid) | **GET** /api/v1/ProjectTemplates({Id}) | Returns all project templates
*ProjectsApi* | [**ProjectsV1Get**](docs/ProjectsApi.md#projectsv1get) | **GET** /api/v1/Projects | Returns all projects
*ProjectsApi* | [**ProjectsV1GetById**](docs/ProjectsApi.md#projectsv1getbyid) | **GET** /api/v1/Projects({Id}) | Returns the project with the specified id
*QuotationsApi* | [**QuotationsV1Get**](docs/QuotationsApi.md#quotationsv1get) | **GET** /api/v1/Quotations | Returns all quotations
*QuotationsApi* | [**QuotationsV1GetById**](docs/QuotationsApi.md#quotationsv1getbyid) | **GET** /api/v1/Quotations({Id}) | Returns all quotations
*UserAbsencesApi* | [**UserAbsencesV1DeleteById**](docs/UserAbsencesApi.md#userabsencesv1deletebyid) | **DELETE** /api/v1/UserAbsences({Id}) | Deletes an absence
*UserAbsencesApi* | [**UserAbsencesV1Get**](docs/UserAbsencesApi.md#userabsencesv1get) | **GET** /api/v1/UserAbsences | Returns all absences
*UserAbsencesApi* | [**UserAbsencesV1GetById**](docs/UserAbsencesApi.md#userabsencesv1getbyid) | **GET** /api/v1/UserAbsences({Id}) | Returns all absences
*UserAbsencesApi* | [**UserAbsencesV1Post**](docs/UserAbsencesApi.md#userabsencesv1post) | **POST** /api/v1/UserAbsences | Creates a new absence
*UserReportingsApi* | [**UserReportingsV1DeleteById**](docs/UserReportingsApi.md#userreportingsv1deletebyid) | **DELETE** /api/v1/UserReportings({Id}) | Deletes a user reporting
*UserReportingsApi* | [**UserReportingsV1Get**](docs/UserReportingsApi.md#userreportingsv1get) | **GET** /api/v1/UserReportings | Returns all user reportings
*UserReportingsApi* | [**UserReportingsV1GetById**](docs/UserReportingsApi.md#userreportingsv1getbyid) | **GET** /api/v1/UserReportings({Id}) | Returns all user reportings
*UsersApi* | [**UsersV1Get**](docs/UsersApi.md#usersv1get) | **GET** /api/v1/Users | Returns all users
*UsersApi* | [**UsersV1GetById**](docs/UsersApi.md#usersv1getbyid) | **GET** /api/v1/Users({Id}) | Returns all users


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Article](docs/Article.md)
 - [Model.ArticleCategory](docs/ArticleCategory.md)
 - [Model.ArticleDiscount](docs/ArticleDiscount.md)
 - [Model.ArticleSalesPrice](docs/ArticleSalesPrice.md)
 - [Model.ArticleSupplierQuotation](docs/ArticleSupplierQuotation.md)
 - [Model.Company](docs/Company.md)
 - [Model.CompanyAddress](docs/CompanyAddress.md)
 - [Model.CompanyType](docs/CompanyType.md)
 - [Model.ContactPerson](docs/ContactPerson.md)
 - [Model.CustomField](docs/CustomField.md)
 - [Model.CustomFieldDefinition](docs/CustomFieldDefinition.md)
 - [Model.CustomFieldOption](docs/CustomFieldOption.md)
 - [Model.DocumentCondition](docs/DocumentCondition.md)
 - [Model.DocumentPosition](docs/DocumentPosition.md)
 - [Model.Lead](docs/Lead.md)
 - [Model.ModelObject](docs/ModelObject.md)
 - [Model.ODataResponseListCompany](docs/ODataResponseListCompany.md)
 - [Model.ODataResponseListCompanyAddress](docs/ODataResponseListCompanyAddress.md)
 - [Model.ODataResponseListCompanyType](docs/ODataResponseListCompanyType.md)
 - [Model.ODataResponseListContactPerson](docs/ODataResponseListContactPerson.md)
 - [Model.ODataResponseListCustomFieldDefinition](docs/ODataResponseListCustomFieldDefinition.md)
 - [Model.ODataResponseListProject](docs/ODataResponseListProject.md)
 - [Model.ODataResponseListProjectRole](docs/ODataResponseListProjectRole.md)
 - [Model.ODataResponseListProjectStatus](docs/ODataResponseListProjectStatus.md)
 - [Model.ODataResponseListProjectTemplate](docs/ODataResponseListProjectTemplate.md)
 - [Model.ODataResponseListQuotation](docs/ODataResponseListQuotation.md)
 - [Model.ODataResponseListUser](docs/ODataResponseListUser.md)
 - [Model.ODataResponseListUserAbsence](docs/ODataResponseListUserAbsence.md)
 - [Model.ODataResponseListUserReporting](docs/ODataResponseListUserReporting.md)
 - [Model.Project](docs/Project.md)
 - [Model.ProjectRole](docs/ProjectRole.md)
 - [Model.ProjectStatus](docs/ProjectStatus.md)
 - [Model.ProjectTemplate](docs/ProjectTemplate.md)
 - [Model.Quotation](docs/Quotation.md)
 - [Model.Subsystem](docs/Subsystem.md)
 - [Model.Task](docs/Task.md)
 - [Model.User](docs/User.md)
 - [Model.UserAbsence](docs/UserAbsence.md)
 - [Model.UserReporting](docs/UserReporting.md)


## Documentation for Authorization

### basic

- **Type**: HTTP basic authentication

