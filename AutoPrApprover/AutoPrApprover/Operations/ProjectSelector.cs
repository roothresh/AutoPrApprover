using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrApprover.Operations
{
    public class ProjectSelector
    {
        private int projectId;
        public ProjectSelector(int projectId)
        {
            this.projectId = projectId;
        }

        public string GetProjectName()
        {
            switch (projectId)
            {
                case 1:
                    return Consts.ForeignTradeApiName;
                case 2:
                    return Consts.ForeignTradeWebName;
                case 3:
                    return Consts.ChequeApiName;
                case 4:
                    return Consts.ChequeWebName;
                default:
                    throw new ArgumentException("Geçersiz giriş.");
            }
        }
    }
}
