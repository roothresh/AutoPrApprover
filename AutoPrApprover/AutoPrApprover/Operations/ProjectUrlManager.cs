using AutoPrApprover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrApprover.Operations
{
    public class ProjectUrlManager
    {
        private string apiUrl;

        public ProjectUrlManager(UrlBuilderModel model)
        {
            apiUrl = Consts.ApiUrl
                .Replace("{organizationName}", model.OrganizationName)
                .Replace("{projectName}", model.ProjectName)
                .Replace("{repository}", model.Repository)
                .Replace("{pullRequestId}", model.PullRequestId)
                .Replace("{reviewerId}", model.ReviewerId);
        }

        public string GetApiUrl()
        {
            return apiUrl;
        }
    }
}
