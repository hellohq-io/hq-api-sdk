using Authentication;
using Config;
using System;

namespace HQ.API.SDK.Sample
{
    public class CreateUserReportingAPISample
    {
        public void CreateUserReportingApi(HQAPIClient client)
        {

            //Create a new UserReporting
            var newUserReporting = new ProjectV1CreateReportingParameters()
            {
                UserId = 1,
                StartDate = new DateTime(2018, 8, 24),
                Duration = 3000,
                Description = "Description",
                TaskId = 93888
            };

            // POST the new UserReporting to create it
            var newUserReportingResul1 = client.ProjectsV1_CreateReportingByIdAsync(12, newUserReporting).Result;
            Console.WriteLine("UserReporting1 Id: " + newUserReportingResul1.Id);

        }
    }
}
