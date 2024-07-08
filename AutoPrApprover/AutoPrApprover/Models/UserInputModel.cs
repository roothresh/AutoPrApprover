using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrApprover.Models
{
    public class UserInputModel
    {
        public int ProjectId { get; set; }
        public string PullRequestId { get; set; }
        public string ReviewerId { get; set; }
        public string OrganizationName { get; set; }    
        public string ProjectName { get; set; }
        public string RepositoryName { get; set; }
    }
}
