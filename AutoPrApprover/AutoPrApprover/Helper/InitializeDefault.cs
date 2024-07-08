using AutoPrApprover.Interfaces;
using AutoPrApprover.Models;
using AutoPrApprover.Operations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrApprover.Helper
{
    public class InitializeDefault : IHelperInterface
    {
        public string GetApiUrl(UserInputModel model)
        {
            UrlBuilderModel urlBuilderModel = new UrlBuilderModel{
                OrganizationName = model.OrganizationName,
                ProjectName = model.ProjectName,
                PullRequestId = model.PullRequestId,
                Repository = model.RepositoryName,
                ReviewerId = model.ReviewerId,
            };

            ProjectUrlManager urlManager = new ProjectUrlManager(urlBuilderModel);
            return urlManager.GetApiUrl();
        }

        public AuthModel GetAuth()
        {
            AuthModel authModel = new AuthModel();
            authModel.Password = Consts.defaultPersonelAccessToken;
            return authModel;
        }

        public string GetJsonStringBody(string reviewerId)
        {
            var jsonBody = new
            {
                hasDeclined = false,
                id = reviewerId,
                vote = 10
            };

            string jsonString = JsonConvert.SerializeObject(jsonBody);

            return jsonString;
        }

        public UserInputModel GetUserInput()
        {
            UserInputModel userInputModel = new UserInputModel();

            Console.WriteLine(Consts.SelectProject);
            Console.WriteLine(Consts.ProjectSelectionString);
            userInputModel.ProjectId = Convert.ToInt32(Console.ReadLine());
            ProjectSelector projectSelector = new ProjectSelector(userInputModel.ProjectId);
            userInputModel.RepositoryName = projectSelector.GetProjectName();

            Console.WriteLine(Consts.EnterPullRequest);
            userInputModel.PullRequestId = Console.ReadLine();

            userInputModel.ReviewerId = Consts.defaultReviewerId;
            userInputModel.OrganizationName = Consts.defaultOrganizationName;
            userInputModel.ProjectName = Consts.defaultProjectName;

            return userInputModel;
        }
    }
}
