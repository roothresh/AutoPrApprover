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
    public class InitializeAdvanced : IHelperInterface
    {
        public string GetApiUrl(UserInputModel model)
        {
            UrlBuilderModel urlBuilderModel = new UrlBuilderModel{
                OrganizationName = model.OrganizationName,
                ProjectName = model.ProjectName,
                PullRequestId = model.PullRequestId,
                Repository = model.RepositoryName,
                ReviewerId = model.ReviewerId
            };

            ProjectUrlManager urlManager = new ProjectUrlManager(urlBuilderModel);
            return urlManager.GetApiUrl();
        }

        public AuthModel GetAuth()
        {
            AuthModel authModel = new AuthModel();

            Console.WriteLine(Consts.EnterPersonelAccessToken);
            authModel.Password = Console.ReadLine();

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

            Console.WriteLine(Consts.EnterOrganizationName);
            userInputModel.OrganizationName = Console.ReadLine();

            Console.WriteLine(Consts.EnterProjectName);
            userInputModel.ProjectName = Console.ReadLine();

            Console.WriteLine(Consts.EnterRepositoryName);
            userInputModel.RepositoryName = Console.ReadLine();

            Console.WriteLine(Consts.EnterPullRequest);
            userInputModel.PullRequestId = Console.ReadLine();

            Console.WriteLine(Consts.EnterReviewerId);
            userInputModel.ReviewerId = Console.ReadLine();

            return userInputModel;
        }
    }
}
