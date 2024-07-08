using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrApprover.Models
{
    public class UrlBuilderModel : BaseModel
    {
        public string OrganizationName { get; set; }
        public string ProjectName { get; set; }
        public string Repository { get; set; }
        public string PullRequestId { get; set; }
    }
}
