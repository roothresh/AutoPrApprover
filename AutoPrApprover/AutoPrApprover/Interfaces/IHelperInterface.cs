using AutoPrApprover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrApprover.Interfaces
{
    internal interface IHelperInterface
    {
        UserInputModel GetUserInput();
        string GetApiUrl(UserInputModel model);
        AuthModel GetAuth();
        string GetJsonStringBody(string reviewerId);
    }
}
